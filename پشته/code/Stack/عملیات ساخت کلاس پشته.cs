using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Stack
{
    public class StackClass
    {

        private object[] item;
        private int Top;
        private int Size;

        // تابع سازنده
        public StackClass(int s)
        {
            Size = s;
            item = new object[Size];
            Top = -1;
        }

        // متد پوش
        public void push(object num)
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
    // شبیه سازی حذف و درج استک

    static void Main(string[] args)
        {
            StackClass s1 = new StackClass(200);
            s1.push(100);
            s1.pop();

        }
    } 
}


