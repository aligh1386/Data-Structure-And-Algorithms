using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class Array2D
    {
        void Main(string[] args)
        {
            int[,] a = new int[10,10];
            
        }
        void func(int[,] m)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if (j < i)
                    {
                        Console.WriteLine(m[i,j]);
                    }
                }
            }
        }
    }
}


// این تابع میاد تمام اعداد بالای قطر تابع رو چاپ میکند