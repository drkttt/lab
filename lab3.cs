using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
            static void p1()
        { 
            Console.WriteLine("Введите n");
            int n = Convert.ToInt64(Console.ReadLine());
            int s = 0;
            for (int i = 1; i < n; i++)
            {
                s += i;
            }
            Console.ReadKey();
        }
            
         static void p2()
        {
            for (int i = 35; i <= 87; i++)
            {
                double k = i % 7;

                if (k == 1 || k == 2 || k == 5)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
        
        static void p3()
        {
            Console.WriteLine("Введите количество посетителей");          
            int [] mas = new int[int.Parse(Console.ReadLine())];
            int i = 0;
            int o = 0;
            int y = 100;
            int s = 0;
            while (i !=mas.Length)
            {
                Console.WriteLine("Введите возраст {0} посетителя", i + 1);
                mas[i] = int.Parse(Console.ReadLine());
                if (mas[i]<y)
                {
                    y = mas[i];
                }
                if (mas[i]>o)
                {
                    o = mas[i];
                }
                s = s + mas[i];
                i++;
            }
            Console.WriteLine("Самый молодой посетитель - {0}", y);
            Console.WriteLine("Самый старший посетитель - {0}", o);
            Console.WriteLine("Средний возраст - {0}", s / mas.Length);

            Console.ReadKey();
        }           

        static void p4()
        {
            int k = 0;
            while (k <= 15)
            {
                Console.WriteLine("Введите количество ящиков");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y <= 15)
                {
                    k += y;
                }
                else
                {
                    Console.WriteLine("Ящиков недостаточно");
                }
                if (k >= 15)
                {
                    Console.WriteLine("Ящиков недостаточно"); break;
                }
            }
            Console.ReadKey();
        }

        static void p5()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("3 ");
                Console.WriteLine("");
            }// 1


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (i >= j)
                        Console.Write("* ");
                Console.WriteLine("");
            } // 2

            int k = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0} ", k);
                    k++;
                }

                Console.WriteLine("");
            } // 3

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    if (i == 4 - j || i == j)
                        Console.Write("1 ");
                    else Console.Write("0 ");
                Console.WriteLine();
            } //4

        }
            Console.ReadKey();
        }
    }
}
