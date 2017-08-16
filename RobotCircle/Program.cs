using System;

namespace RobotCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            if(JudgeCircle("LL"))
            {
                Console.WriteLine("Sucess! Circular path!");
            }
            else
            {
                Console.WriteLine("Error...not a circular path! Try again!");
            }
            Console.ReadLine();
        }

        public static bool JudgeCircle(string moves)
        {
            int up = 0;
            int right = 1;
            int down = 2;

            // Initialize starting point
            int x = 0;
            int y = 0;
            int dir = up;

            for (int i = 0; i < moves.Length; i++)
            {
                char move = moves[i];

                if (move.ToString() == "R")
                {
                    dir = (dir + 1) % 4;
                }
                else if (move.ToString() == "L")
                {
                    dir = (4 + dir - 1) % 4;
                }
                else if (move.ToString() == "U")
                {
                    dir = (dir + 1) % 2;
                }
                else if (move.ToString() == "D")
                {
                    dir = (2 + dir - 1) % 2;
                }
                else
                {
                    if (dir == up)
                    {
                        y++;
                    }
                    else if (dir == right)
                    {
                        x++;
                    }
                    else if (dir == down)
                    {
                        y--;
                    }
                    else
                    {
                        x--;
                    }
                }
            }

            // Return true if robot returns to start
            if (x == 0 && y == 0)
            {
                return true;
            }
            return false;
        }
    }
}
