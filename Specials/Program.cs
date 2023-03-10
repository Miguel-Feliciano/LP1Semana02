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
            Console.WriteLine($"double -max: {double.MaxValue} | min: {double.MinValue}\n");

            Console.WriteLine($"float -positive infinity: {float.PositiveInfinity} | negative infinity: {float.NegativeInfinity}");
            Console.WriteLine($"double -positive infinity: {double.PositiveInfinity} | negative infinity: {double.NegativeInfinity}");
            Console.WriteLine($"float -NaN: {float.NaN}");
            Console.WriteLine($"double -NaN: {double.NaN}\n");

            int i = int.MaxValue;
            Console.WriteLine((int)(i + 1));
            uint ui = uint.MaxValue;
            Console.WriteLine((uint)(ui + 1));
            byte b = byte.MaxValue;
            Console.WriteLine((byte)(b + 1));
            sbyte sb = sbyte.MaxValue;
            Console.WriteLine((sbyte)(sb + 1));
            short s = short.MaxValue;
            Console.WriteLine((short)(s + 1));
            ushort us = ushort.MaxValue;
            Console.WriteLine((ushort)(us + 1));
            long l = long.MaxValue;
            Console.WriteLine((long)(l + 1));
            ulong ul = ulong.MaxValue;
            Console.WriteLine((ulong)(ul + 1));

            float f = float.MaxValue;
            Console.WriteLine((float)(f + 1));
            double d = double.MaxValue;
            Console.WriteLine((double)(d + 1));
            Console.WriteLine(" ");

            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);

            double d1, d2;
            d1 = d2 = 10000.0;
            Console.WriteLine(f1 == f2 + 0.0001);

        }
    }
}
