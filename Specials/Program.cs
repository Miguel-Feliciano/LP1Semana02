using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int - max: {int.MaxValue} | min: {int.MinValue}");
            Console.WriteLine($"uint -max: {uint.MaxValue} | min: {uint.MinValue}");
            Console.WriteLine($"byte -max: {byte.MaxValue} | min: {byte.MinValue}");
            Console.WriteLine($"sbyte -max: {sbyte.MaxValue} | min: {sbyte.MinValue}");
            Console.WriteLine($"short -max: {short.MaxValue} | min: {short.MinValue}");
            Console.WriteLine($"ushort -max: {ushort.MaxValue} | min: {ushort.MinValue}");
            Console.WriteLine($"long -max: {long.MaxValue} | min: {long.MinValue}");
            Console.WriteLine($"ulong -max: {ulong.MaxValue} | min: {ulong.MinValue}");
            Console.WriteLine($"float -max: {float.MaxValue} | min: {float.MinValue}");
            Console.WriteLine($"double -max: {double.MaxValue} | min: {double.MinValue}");
        }
    }
}
