using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double r;
            double v;
            double s;
            double p = 3.1415926;

            Console.WriteLine("Enter height: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            v = p * Math.Pow(r ,2) * a;
            Console.WriteLine($"The volume of the cylinder is: {v}");

            s = (2 * p * r *(r + a));
            Console.WriteLine($"The surface area of the cylinder is: {s}");

        }
    }
}
