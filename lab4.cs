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
            int[] a = new int[10] { 1, 2, 11, 4, 5, 6, 7, 8, 9, 10 };
            int p = 0;
            int s = 0;
            int max = a[0];
            for (int i = 0; i < 10; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    p = i;
                }
            }
            for (int j=0; j<p; j++)
            { 
                {
                    s = s + a[j];
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
        
        static void p5()
        {
            double[] mas = new double[] { 1, 11, 4, 5, 6, 7, 8, 9, 10 };
            double max = mas[0];
            double sum = 0;
            int a = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    a = i;
                }
                sum = sum + mas[i];

            }
            double sr = sum / mas.Length;
            for (int i = a; i < mas.Length; i++)
            {
                mas[i] = sr;
                Console.Write(mas[i] + "");
             }
            Console.ReadKey();
        }
        
        static void p6()
        { 
                int[,] M1 = new int[3, 3] { { 1, 2, 3}, { 4, 5, 6 }, { 7, 8, 9 } };
                int[] M2 = new int[3];
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        M2[j] = M2[j] + M1[i, j];
                Console.WriteLine("{0} {1} {2}", M2[0], M2[1], M2[2]);
                Console.ReadKey();
        }
        
        
        }
    
}
