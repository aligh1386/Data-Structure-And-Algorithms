using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class writeMaxStack
    {
        private int[] item;
        private int Top;
        private int Size;

        // تابع سازنده
        public writeMaxStack(int s)
        {
            Size = s;
            item = new int[Size];
            Top = -1;
        }

        // متد پوش
        public void push(int num)
        {
            if (IsFull())
            {
                Console.WriteLine("Full!!!!");
                return;
            }
            Top++;
            item[Top] = num;
        }
        // متد برسی پر بودن
        public bool IsFull()
        {
            if (Size - 1 == Top)
            {
                return true;
            }
            else return false;
        }
        // متد حذف 
        public object pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Empty");
                return null;
            }
            return item[Top--];
        }

        public bool IsEmpty()
        {
            return (Top == -1);
        }

        // چاپ بزرگ ترین عنصر
        public void max(int x)
        {
            if (IsEmpty()) return;
            int max = item[0];
            for(int i = 0; i <= Top; i++)
            {
                if (item[i] >= max)
                {
                    max = item[i];
                }
            }
            Console.Write(max);
        }
    }
}
