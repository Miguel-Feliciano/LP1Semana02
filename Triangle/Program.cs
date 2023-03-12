using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("no good");
                return;
            }

            int numberOfLines = int.Parse(args[0]);
            char character = char.Parse(args[1]);

            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
    }
}
