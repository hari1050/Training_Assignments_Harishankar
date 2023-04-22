using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harishankar_Assignments
{
    using System;

    class Assignment1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integral Types:");
            Console.WriteLine($"sbyte: [{sbyte.MinValue}, {sbyte.MaxValue}]");
            Console.WriteLine($"byte: [{byte.MinValue}, {byte.MaxValue}]");
            Console.WriteLine($"short: [{short.MinValue}, {short.MaxValue}]");
            Console.WriteLine($"ushort: [{ushort.MinValue}, {ushort.MaxValue}]");
            Console.WriteLine($"int: [{int.MinValue}, {int.MaxValue}]");
            Console.WriteLine($"uint: [{uint.MinValue}, {uint.MaxValue}]");
            Console.WriteLine($"long: [{long.MinValue}, {long.MaxValue}]");
            Console.WriteLine($"ulong: [{ulong.MinValue}, {ulong.MaxValue}]");

            Console.WriteLine("\nFloating-Point Types:");
            Console.WriteLine($"float: [{float.MinValue}, {float.MaxValue}]");
            Console.WriteLine($"double: [{double.MinValue}, {double.MaxValue}]");
            Console.WriteLine($"decimal: [{decimal.MinValue}, {decimal.MaxValue}]");
        }
    }

}
