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

            Console.WriteLine("Enter height: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            v = Math.PI * Math.Pow(r ,2) * a;
            Console.WriteLine($"The volume of the cylinder is: {v}");

        }
    }
}
