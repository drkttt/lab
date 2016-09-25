using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dat1 = DateTime.Now;
            Console.WriteLine("{0} дней прошло с начала года", dat1.DayOfYear);
            int a = dat1.DayOfYear;
            int b = 365 - a;
            Console.WriteLine("{0} дней осталось до конца года", b);
            DateTime ye = new DateTime(dat1.Year, dat1.Month, dat1.Day - 1);
            Console.WriteLine("Вчера было {0}", ye.ToString("dd MM yyyy"));
            DateTime to = new DateTime(dat1.Year, dat1.Month, dat1.Day + 1);
            Console.WriteLine("Завтра будет {0}", to.ToString("dd MM yyyy"));
            Console.ReadKey();
        }
    }
}
