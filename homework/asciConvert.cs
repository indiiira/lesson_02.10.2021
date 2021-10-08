using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lesson_02._10._2021
{
    public class BitmapAsciConverter
    {
        private readonly char[] asci = { '.','#' };
        private readonly Bitmap _bitmap;


        
        public BitmapAsciConverter(Bitmap bitmap)
        {
            _bitmap = bitmap;

        }
        public char[][] Convert()
        {
            var result = new char[_bitmap.Height][];
            for (int y = 0; y < _bitmap.Height; y++)
            {
                result[y] = new char[_bitmap.Width];
                for (int x = 0; x < _bitmap.Width; x++)
                {
                    int mapIndex = (int)Map(_bitmap.GetPixel(x, y).R, 0, 255, 0, asci.Length-1);
                    result[y][x] = asci[mapIndex];
                }
            }
            return result;


        }
        private double Map(double valueToMap, double start1, double stop1, double start2, double stop2)
        {
        return ((valueToMap-start1)/(stop1-start1))*(stop2-start2)+start2;
          }

    }

}

