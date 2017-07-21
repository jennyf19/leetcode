using System;

namespace IntegerPalindrome
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

                bool reversedNum = isPalindrome(input);

                if(reversedNum == false)
                {
                    Console.WriteLine("Not a palindrome: " + "\n" + input);
                }
                else 
                {
                    Console.WriteLine(input + "\nIs a palindrome!!");
                }
                Console.ReadLine();
            }
        }

        public static bool isPalindrome(int x)
        {
            // check for negative number
            if (x < 0)
            {
                return false;
            }

            int ReverseNum = 0;
            int temp = 0;

            temp = x;

            try
            {
                while (x > 0)
                {
                    ReverseNum = checked(ReverseNum * 10) + (x % 10);
                    x = x / 10;
                }
            }
            catch (OverflowException)
            {
                return false;
            }

            if(temp == ReverseNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
