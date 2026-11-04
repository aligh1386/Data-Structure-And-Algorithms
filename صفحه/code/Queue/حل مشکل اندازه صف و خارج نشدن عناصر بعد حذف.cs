using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
// در این نسخه مشکل اندازه صف حل شد 
namespace Queue
{
    internal class FixedQueue
    {
        object[] item;
        int size;
        int front, rear;
        int count;
        // تابع سازنده
        FixedQueue(int s)
        {
            size = s;
            item = new object[size];
            front = 0;
            rear = -1;
            count = 0;
        }
        // مقدار پیش فرض در صورت وارد نکردن
        FixedQueue() : this(10) { }
        // وارد کردن عناصر
        public void EnQueue(int num)
        {
            if (IsFull())
            {

                Console.Write("Full!!!!!");
                return;
            }
            rear = (rear + 1) % size;
            item[rear] = num;
            count++;
        }
        // خارج کردن عناصر
        public object DeQueue()
        {
            if (IsEmpty())
            {
                Console.Write("Empty!!!!!!");
                return null;
            }

            object result = item[front];
            item[front] = null;
            front = (front + 1) % size;
            count--;
            return result;
        }
        // برسی پر بودن
        public bool IsFull()
        {
            return (count==size);
        }
        // برسی خالی بودن
        public bool IsEmpty()
        {
            return (count==0);
        }
    }
}
