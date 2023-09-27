using System;
using System.Threading;

namespace Yatzee
{
    internal class Dice
    {
        
        private int value;

        public int Value
        {
            get {
                return value; 
            }
        }

        public void Roll()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            value = random.Next(1, 7);
        }
    }
}