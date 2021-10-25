using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Drawing;
using System.Threading;

namespace lesson_02._10._2021
{
    class Program
    {
        

        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }

        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 1 ");
            Console.Write("N = ");
            var len = Convert.ToInt32(Console.ReadLine());
            var a = new int[len];
            for (var i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(a)));

            
            
             Console.WriteLine("Домашнее задание 2 ");
            Random rand = new Random();
            Queue<int> q = new Queue<int>();    //Это очередь, хранящая номера вершин
            string exit = "";
            int u;
            u = rand.Next(3, 5);
            bool[] used = new bool[u + 1];  //массив отмечающий посещённые вершины
            int[][] g = new int[u + 1][];   //массив содержащий записи смежных вершин

            for (int i = 0; i < u + 1; i++)
            {
                g[i] = new int[u + 1];
                Console.Write("\n({0}) вершина -->[", i + 1);
                for (int j = 0; j < u + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write(" {0}", item);
                }
                Console.Write("]\n");
            }
            used[u] = true;     //массив, хранящий состояние вершины(посещали мы её или нет)

            q.Enqueue(u);
            Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", u + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}



          
        


