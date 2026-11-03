using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    internal class CheckCommonHomeSlot
    {
        void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            a[1] = 100;

            Func(a);

            Console.Write(a[1]); // 101 - Num 3
        }

        void Func(int[] b)
        {
            Console.Write(b[1]); // 100 - Num 1
            for(int i = 0; i < b.Length; i++)
            {
                b[i]++;
            }
            Console.Write(b[1]); // 101 - Num 2
        }
    }
}


