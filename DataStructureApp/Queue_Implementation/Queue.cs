using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation
{
    public class Queue<T>
    {
        private T[] items;
        private int front;
        private int rear;
        private int count;
        private const int DefaultCapacity = 8;

        public Queue()
        {
            items = new T[DefaultCapacity];
            front = 0;
            rear = -1;
            count = 0;
        }

        public int Count => count;

        public void Enqueue(T item)
        {
            if (count == items.Length)
                ResizeArray();

            rear = (rear + 1) % items.Length;
            items[rear] = item;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T item = items[front];
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return items[front];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            front = 0;
            rear = -1;
            count = 0;
        }

        private void ResizeArray()
        {
            int newCapacity = items.Length * 2;
            T[] newItems = new T[newCapacity];

            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[front];
                front = (front + 1) % items.Length;
            }

            items = newItems;
            front = 0;
            rear = count - 1;
        }




    }
}
