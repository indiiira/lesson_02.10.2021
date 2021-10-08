using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число от 0 до 9");
            int n = Convert.ToInt32(Console.ReadLine());
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG "
            };
            Console.WriteLine("Нажмите Enter чтобы начать");
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
    }
}
