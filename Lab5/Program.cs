using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void  searchmax(int c1, int c2)
        {
            if (c1 > c2)
            {
                Console.WriteLine($"({c1})");
            }
            else if (c1<c2)
            {
                Console.WriteLine($"({c2})");
            }
            else
            {
                Console.WriteLine("Они равны");
            }
        }
        
        
       
        public static void SwaP(ref int a1, ref int a2)
        {
            a1 = a1 + a2;
            a2 = a1 - a2;
            a1 = a1 - a2;
        }
        static bool fact(ref int num)
        {
            int c = num;
            num = 1;
            for (int i = 1; i <= c; i++)
                try
                {
                    checked
                    {
                        num *= i;
                    }

                }
                catch { return false; }
            return true;
        }
        static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        static int NOD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }
            return y;
        }

        static int NOD(int x, int y, int c)
        {
            c = NOD(NOD(x, y), c);
            return c;
        }
        static int Fibonachi(int n)
        {
            if (n==0 || n==1)
            {
                return n;
            }
            else 
            { 
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
          
            Console.WriteLine("Лабораторная работа 5.1 ");
            Console.WriteLine("Введите первое число");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int c2 = Convert.ToInt32(Console.ReadLine());
            searchmax(c1, c2);

            Console.WriteLine("Лабораторная работа 5.2 ");
            try
            {
                Console.WriteLine("Введите первое число");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int a2 = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("a -> {0}; b -> {1}", a1, a2);

                SwaP(ref a1, ref a2);
                Console.WriteLine("a -> {0}; b -> {1}", a1, a2);
            }
            catch (FormatException)
            { Console.WriteLine("Введите число!"); }
            Console.WriteLine("Лабораторная работа 5.3 ");
            Console.WriteLine("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool flag = fact(ref n);
            Console.WriteLine(Convert.ToString(flag) + " " + Convert.ToString(n));

            Console.WriteLine("Лабораторная работа 5.4 ");
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {Factorial(n)}");

            Console.WriteLine("Домашнее задание 5.1a ");
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД чисел {x} и {y} равен {NOD (x, y)}");

            Console.WriteLine("Домашнее задание 5.2b ");
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"НОД чисел {x} и {y} и {c} равен {NOD(x, y, c )}");

            Console.WriteLine("Домашнее задание 5.2 ");
            Console.WriteLine("Введите  число");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Fibonachi(n)}");
            Console.ReadKey();
        }

        
       
        }
        
      
        }
    

