using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    internal class BasicQueue
    {
        object[] item;
        int size;
        int front, rear;
        // تابع سازنده
        BasicQueue(int s)
        {
            size = s;
            item = new object[size];
            front = -1;
            rear = -1;
        }
        // مقدار پیش فرض در صورت وارد نکردن
        BasicQueue() : this(10) { }
        // وارد کردن عناصر
        public void EnQueue(int num)
        {
            if (IsFull()){

                Console.Write("Full!!!!!");
                return;
            }
            item[++rear] = num;
        }
        // خارج کردن عناصر
        public object DeQueue()
        {
            if (IsEmpty())
            {
                Console.Write("Empty!!!!!!");
                return null;
            }
            return (item[++front]);
        }
        // برسی پر بودن
        public bool IsFull()
        {
            return (rear == size - 1);
        }
        // برسی خالی بودن
        public bool IsEmpty()
        {
            return (rear == front);
        }

        // نشان دادن طول صف
        public int back()
        {
            return rear - front;
        }
    }
}
