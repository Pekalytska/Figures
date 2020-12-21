using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            //****
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
              **
              **
            */
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
              ****
              ****
            */
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
                *
                **
                ***
                ****
            */
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
                ****
                ***
                **
                *
           */
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
                   *
                  **
                 ***
                ****
            */
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <=i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
                ****
                 ***
                  **
                   *
            */

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 4; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            /*
                   *
                  ***
                 *****
                *******
            */
            int r = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= r; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                r = r + 2;
            }

            Console.WriteLine();
            Console.WriteLine();


            /*
                   *
                  ***
                 *****
                *******
                 *****
                  ***
                   *
            */
            int g = 0;
            int t = 8;
            for (int i = 0; i < 7; i++)
            {
                if (g <= 6)
                {
                    for (int j = 4; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k <= g; k++)
                    {
                        Console.Write("*");
                    }
                    g = g + 2;
                }
                else
                {
                    for (int o = 3; o <= i; o++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 3; k < t; k++)
                    {
                        Console.Write("*");
                    }
                    t = t - 2;
                }
                Console.WriteLine();
            }
        }
    }
}
