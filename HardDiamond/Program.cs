using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int r;

            Console.WriteLine("Please enter an odd number: ");
            i = Convert.ToInt32( Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("I only want odd numbers!");
            }
            else
            {
                r = (i + 1) / 2;
                for (i = 0; i <= r; i++)
                {
                    for (j = 1; j <= r - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("\n");
                }

                for (i = r - 1; i >= 1; i--)
                {
                    for (j = 1; j <= r - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(".");
                    }

                    Console.Write("\n");
                }
            }
        }
    }
}
