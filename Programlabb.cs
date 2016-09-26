using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void p1()
        {
            int[] mass = new int[10] { 2, 5, -3, 2, -3, 5, 3, 6, -8, 4 };
            Console.WriteLine("Введите Q");
            int q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите P");
            int p = Convert.ToInt32(Console.ReadLine());
            int k = 0;           
                if (mass[]<q && mass[]>p)
                {
                    k++ ;
                }
            
        }
        static void p2()
               {
            int[] mass = new int[8] { -3, 2, -3, 5, 3, 6, -8, 4 };
            int n = 0;
            int z = 0;
            for (int i = 0; i < 8; i++)
            {
                if (mass[i] < 0)
                {
                    z = mass[i];
                    n = i;
                }
            }
            Console.WriteLine("Значение последнего отрицательного элемента - {0}", z);
            Console.WriteLine("Номер последнего отрицательного элемента - {0}", n);
            Console.ReadKey();
              }


        static void p3()
        {
            int[] mass = new int[8] { 3, 2, -3, 5, 3, 6, -8, 4 };
            int s = 0;
            int k = 0;
            while (mass[k] > 0)
            {
                s = s + mass[k] * mass[k];
                k++;
            }

            Console.WriteLine(s);
            Console.ReadKey();
        }

        static void p4()
        {

        }
        }
    
}
