using System;

namespace LeetCodeReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number: ");

                Int16 input;
                Int16.TryParse(Console.ReadLine(), out input);
                Console.WriteLine("You entered: " + input.ToString());

                int reversedNum = Reverse(input);
                Console.WriteLine("Number Reversed: " + reversedNum.ToString());
                Console.ReadLine();
            }
        }

        public static int Reverse(int x)
        {
            // check for negative number
            bool negNum = false;
            if (x < 0)
            {
                x = 0 - x;
                negNum = true;
            }

            int ReverseNum = 0;
            try
            {
                while (x > 0)
                {
                    ReverseNum = checked(ReverseNum * 10) + (x % 10);
                    x = x / 10;
                }

                if (negNum)
                {
                    ReverseNum = 0 - ReverseNum;
                }
            }
            catch (OverflowException)
            {
                return 0;
            }

            return ReverseNum;
        }
    }
}
