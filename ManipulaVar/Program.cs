using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(args[0]);
            int y = x;

            int z = 2, v;
            v = z + x++;
        
            Console.WriteLine(x);

            int m = 3, n;
            n = m + --y;
            Console.WriteLine(y);     
        }
    }
}
