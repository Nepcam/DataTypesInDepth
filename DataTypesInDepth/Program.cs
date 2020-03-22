using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            x = int.MinValue;

            Console.WriteLine(x);

            uint y = uint.MinValue;

            Console.WriteLine(y);

            Console.WriteLine(typeof(int).IsPrimitive);
            Console.WriteLine(typeof(float).IsPrimitive);
            Console.WriteLine(typeof(double).IsPrimitive);
            Console.WriteLine(typeof(decimal).IsPrimitive);
            Console.WriteLine(typeof(char).IsPrimitive);
            Console.WriteLine(typeof(string).IsPrimitive);
        }
    }
}
