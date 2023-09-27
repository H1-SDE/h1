using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { };
            arr = SortCharactersDescending(new int[] { 1, 2, 3, 4 });
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine(LengthOfAString("dhd hdhd dkhd"));
            Console.ReadLine();


        }

        static int[] SortCharactersDescending(int[] numbers)
        {
            Array.Reverse(numbers);
                return numbers;
        }

        static int LengthOfAString(string input)
        {
            GetLength(input);
            CountWords(input); 
            return input.Length;

            int GetLength(string input1)
            {
                int output = 0;
                foreach (char c in input1)
                {
                    output = output + 1;



                }
                return output;
            }
            int CountWords(string input2)
            {
                int output = 0;
                input = input.Trim();
                foreach (char b in input2)
                {

                    if (b == ' ')
                    {
                        output++;
                    }

                }
                return output + 1;
            }
            Console.WriteLine(AddSeparator("didjdiojwo", "-"));
            Console.WriteLine(IsPalindrome("hallo"));
            Console.WriteLine(StringInReverseOrder("hallo"));
            Console.WriteLine(RevertWordsOrder("hallo hallo1- hallo2, hallo3."));
            Console.WriteLine(HowManyOccurrences("do it now", "do"));
            Console.WriteLine(HowManyOccurrences("empty", "d"));
            CompressString("kkkktttrrrrrrrrrr");


            Console.ReadLine();

        }

        static string AddSeparator(string word, string sep)
        {
            string Word1 = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                Word1 += i < word.Length - 1 ? word[i] + sep : word[i].ToString();
            }
            return Word1;
        }

        static bool IsPalindrome(string word)
        {
            string reverseString = string.Empty;

            foreach (char c in word)
            {
                reverseString = c + reverseString;
            }

            if (reverseString == word) 
            {
                return true;
            }
            return false;

        }

        static string StringInReverseOrder(string word)
        {
            string reverseString = string.Empty;

            foreach (char c in word)
            {
                reverseString = c + reverseString;
            }
            return reverseString;
        }

        static string RevertWordsOrder(string word)
        {
            string[] halfReverseString = word.Split(' ');
            string reverseString = string.Empty;
            foreach (var word1 in halfReverseString)
            {
                reverseString = word1 + " " + reverseString;
            }
            return reverseString;
        }

        static int HowManyOccurrences(string words, string word2)
        {
            string[] halfReverseString = words.Split(' ');
            int numberOfTimes = 0;
            foreach (var word in halfReverseString)
            {
                if(word == word2)
                {
                    numberOfTimes++;
                }
            }
            return numberOfTimes;
        }

        static void CompressString(string text)
        {
            char[] chars = text.ToCharArray();
            Console.WriteLine("hey " + chars[1]);
            int times = 0;
            string word = string.Empty;
            int chaLength = chars.Length;

            for (int i = 0; i != chaLength; i++)
            {
                if (i == chaLength - 1)
                {
                        if (chars[i] == chars[chaLength - 1])
                        {
                            times++;
                            word = word + chars[i] + (times + 1);
                            times = 0;
                        }
                    break;
                }
                if (chars[i] == chars[i + 1])
                {
                        times++;
                }
                else
                {
                    word = word + chars[i] + (times + 1);
                    times = 0;
                }
                Console.WriteLine(i != chaLength - 1);
            }
            Console.WriteLine(word);
            int[] arr = new int[] { };
            arr = SortCharactersDescending(new int[] { 1, 2, 3, 4 });
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine(LengthOfAString("dhd hdhd dkhd"));
            Console.ReadLine();


        }

        static int[] SortCharactersDescending(int[] numbers)
        {
            Array.Reverse(numbers);
            return numbers;
        }

        static int LengthOfAString(string input)
        {
            GetLength(input);
            CountWords(input);
            return input.Length;

            int GetLength(string input1)
            {
                int output = 0;
                foreach (char c in input1)
                {
                    output = output + 1;



                }
                return output;
            }
            int CountWords(string input2)
            {
                int output = 0;
                input = input.Trim();
                foreach (char b in input2)
                {

                    if (b == ' ')
                    {
                        output++;
                    }

                }
                return output + 1;
            }
        }
    }
} 
