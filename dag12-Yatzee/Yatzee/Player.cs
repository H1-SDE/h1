using System;
using System.Threading;

namespace Yatzee
{
    internal class Player
    {
        private string name;
        private int[] score = new int[13];
        private Dice[] dice;
        private bool[] categoriesUsed = new bool[13];

        public Player(string name)
        {
            this.name = name;
            dice = new Dice[5];
            for (int i = 0; i < 5; i++)
            {
                dice[i] = new Dice();
            }
        }

        public void Play()
        {
            PrintDice();
            ChooseCategory();
        }

        private void PrintDice()
        {
            Console.WriteLine(name + "'s turn:");
            for (int i = 0; i < 5; i++)
            {
                dice[i].Roll();
                Thread.Sleep(50);
                Console.Write("\r\n" + dice[i].Value + "\r\n");
                switch (dice[i].Value)
                {
                    case 1:
                        Console.Write("-----\r\n|   |\r\n| o |\r\n|   |\r\n-----");
                        break;
                    case 2:
                        Console.Write("-----\r\n|o  |\r\n|   |\r\n|  o|\r\n-----");
                        break;
                    case 3:
                        Console.Write("-----\r\n|o  |\r\n| o |\r\n|  o|\r\n-----");
                        break;
                    case 4:
                        Console.Write("-----\r\n|o o|\r\n|   |\r\n|o o|\r\n-----");
                        break;
                    case 5:
                        Console.Write("-----\r\n|o o|\r\n| o |\r\n|o o|\r\n-----");
                        break;
                    case 6:
                        Console.Write("-----\r\n|o o|\r\n|o o|\r\n|o o|\r\n-----");
                        break;
                }
            }
            Console.WriteLine();
        }

        private void ChooseCategory()
        {
            Console.WriteLine("Choose a category:");
            for (int i = 0; i < 13; i++)
            {
                if (!categoriesUsed[i])
                {
                    Console.WriteLine(i + 1 + ": " + GetCategoryName(i));
                }
            }
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                choice = int.Parse(Console.ReadLine()) - 1;
                if (categoriesUsed[choice])
                {
                    Console.WriteLine("Category already used. Choose another.");
                    ChooseCategory();
                }
                else
                {
                    categoriesUsed[choice] = true;
                    score[choice] = CalculateScore(choice);
                    PrintScore();
                }
            }
        }

        public void PrintScore()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("╠══════════════════════════════════════════════════════════╣");
                Console.WriteLine("║" + GetCategoryName(i) + ": " + score[i] + "              ║");
            }
        }

        private int CalculateScore(int choice)
        {
            int[] values = new int[7];
            for (int i = 0; i < 5; i++)
            {
                values[dice[i].Value]++;
            }
            switch (choice)
            {
                case 0:
                    return values[1];
                case 1:
                    return values[2] * 2;
                case 2:
                    return values[3] * 3;
                case 3:
                    return values[4] * 4;
                case 4:
                    return values[5] * 5;
                case 5:
                    return values[6] * 6;
                case 6:
                    for (int i = 1; i <= 6; i++)
                    {
                        if (values[i] >= 3)
                        {
                            return SumDice();
                        }
                    }
                    return 0;
                case 7:
                    for (int i = 1; i <= 6; i++)
                    {
                        if (values[i] >= 4)
                        {
                            return SumDice();
                        }
                    }
                    return 0;
                case 8:
                    bool two = false;
                    bool three = false;
                    for (int i = 1; i <= 6; i++)
                    {
                        if (values[i] == 2)
                        {
                            two = true;
                        }
                        if (values[i] == 3)
                        {
                            three = true;
                        }
                    }
                    if (two && three)
                    {
                        return 25;
                    }
                    return 0;
                case 9:
                    for (int i = 1; i <= 3; i++)
                    {
                        if (values[i] >= 1 && values[i + 1] >= 1 && values[i + 2] >= 1 && values[i + 3] >= 1)
                        {
                            return 30;
                        }
                    }
                    return 0;
                case 10:
                    for (int i = 1; i <= 2; i++)
                    {
                        if (values[i] >= 1 && values[i + 1] >= 1 && values[i + 2] >= 1 && values[i + 3] >= 1 && values[i + 4] >= 1)
                        {
                            return 40;
                        }
                    }
                    return 0;
                case 11:
                    for (int i = 1; i <= 6; i++)
                    {
                        if (values[i] == 5)
                        {
                            return 50;
                        }
                    }
                    return 0;
                case 12:
                    return SumDice();
                default:
                    return 0;
            }
        }
        private int SumDice()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += dice[i].Value;
            }
            return sum;
        }

        private string GetCategoryName(int index)
        {
            string[] categories = { "Ones", "Twos", "Threes", "Fours", "Fives", "Sixes", "Three of a Kind", "Four of a Kind", "Full House", "Small Straight", "Large Straight", "Yahtzee", "Chance" };
            return categories[index];
        }
    }
}