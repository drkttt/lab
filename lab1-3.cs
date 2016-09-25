using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            var d = (1 - Math.Tan(x));
            var a = (Math.Cos(x) / Math.Sin(x));
            var b = (Math.Cos(x - y));
            var n = d * a + b;
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
