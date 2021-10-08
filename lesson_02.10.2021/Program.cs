using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace lesson_02._10._2021
{
    class Program
    {
        static void Sum(int[] arr, ref long p, out double a)
        {
            int Sum = 0;
            a = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Sum = ++arr[i];
                p = p * arr[i];
                a = a + arr[i];

            }

            a = a / arr.Length;
            Console.WriteLine($"Сумма элементов: { Sum}");
            Console.WriteLine($"Произведение элементов: { p}");

        }

        class Reshenie
        {
            double a;
            double b;
            double c;
            double D;
            double x1;
            double x2;
            public Reshenie(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public void raschet()
            {
                D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0 || D == 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                    Console.ReadKey();

                }


                else
                {
                    Console.WriteLine("Действительных корней нет");
                    Console.ReadKey();
                }

            }
        }
            static int[] Bubble(int[] massiv)
            {
                for (int i = 0; i < massiv.Length; i++)
                {
                    for (int j = i + 1; j < massiv.Length; j++)
                    {
                        if (massiv[i] > massiv[j])
                        {
                            int k = massiv[i];
                            massiv[i] = massiv[j];
                            massiv[j] = k;
                        }

                    }
                }
                return massiv;
            }

        [STAThread]
        static void Main(string[] args)
        { 
            Console.WriteLine("Задание 1");
            //ax^2+bx+с
            //D=b^2-4ac
            try
            {
                Console.WriteLine("Введите коэффициент а");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите коэффициент b");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите коэффициент c");
                double c = Convert.ToDouble(Console.ReadLine());
                new Reshenie(a, b, c).raschet();
            }
            catch (Exception)
            { Console.WriteLine("Введите число!"); }

            Console.WriteLine("Задание 2");

            double[] num = new double[20];
            int i;
            Random rand = new Random();
            for (i = 0; i < 20; i++)
            {
                int m = rand.Next(-100, 100);
                if (!num.Contains(m))
                {
                    num[i] = m;
                }
                else
                {
                    i--;
                }
            }
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("Введите первое число");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе  число");
            int a2 = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < 20; i++)
            {
                if (a1 == num[i])
                {
                    num[i] = a2;
                }
                if (a2 == num[i])
                {
                    num[i] = a1;
                }
                Console.WriteLine(num[i]);
            }


            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите количество элементов в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] massiv = new int[n];
            for (i = 0; i < n; i++)
            {
                int m = rand.Next(-100, 100);
                if (!massiv.Contains(m))
                {
                    massiv[i] = m;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine("Перед сортировкой");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(massiv[i]);
            }
            Console.WriteLine("После сортировки");
            Bubble(massiv);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(massiv[i]);
            }


            Console.WriteLine("Задание 4");



            Console.WriteLine("Введите количество элементов в массиве");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (i = 0; i < n; i++)
            {
                int m = rand.Next(-100, 100);
                if (!arr.Contains(m))
                {
                    arr[i] = m;
                }
                else
                {
                    i--;
                }
                Console.WriteLine(arr[i]);
            }
            long p = 1;
            double arifm;
            Sum(arr, ref p, out arifm);
            Console.WriteLine("Среднее арифметическое " + arifm);
            Console.ReadKey();
            


            Console.WriteLine("Задание 5");

            Console.WriteLine("введите число от 0 да 9 : ");
            string str = Console.ReadLine().ToLower();
            bool flag = true;
            bool run = true;
            while (flag)
            {
                if (!run)
                {
                    Console.WriteLine("Введите число от 0 до 9. Если хотите завершить, напишите exit или закрыть!");
                    str = Console.ReadLine().ToLower();
                    Console.Clear();
                }
                else
                {
                    run = false;
                }
                try
                {
                    Console.Clear();
                    if ((str == "exit") || (str == "закрыть"))
                    {
                        flag = false;
                        break;
                    }
                    int number = int.Parse(str);
                    if (number < 0 || number > 9)
                    {
                        throw new Exception("Вы ввели неплавильное число!");
                    }


                    var openFileDialog = new OpenFileDialog
                    {
                        Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG "
                    };

                    while (true)
                    {
                        Console.ReadLine();
                        if (openFileDialog.ShowDialog() != DialogResult.OK)
                            continue;
                        Console.Clear();

                        var bitmap = new Bitmap(openFileDialog.FileName);

                        bitmap = ResizeBitmap(bitmap);
                        bitmap.ToGray();


                        var converter = new BitmapAsciConverter(bitmap);
                        var rows = converter.Convert();

                        foreach (var row in rows)
                            Console.WriteLine(row);

                        Console.SetCursorPosition(0, 0);

                    }

                }
                
                catch (Exception)
                {
                    Console.Clear();

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("ERROR");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
            
            }
        
        

        public static Bitmap ResizeBitmap(Bitmap bitmap)
        {
            var maxWidth = 200;
            var newHeight = 200;
            if (bitmap.Width > maxWidth || bitmap.Height > newHeight)
                bitmap = new Bitmap(bitmap, new Size(maxWidth, (int)newHeight));
            return bitmap;
        }


    }

}
    

    

    



