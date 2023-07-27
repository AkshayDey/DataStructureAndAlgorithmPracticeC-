using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class Stack_Practice<T>
    {
        public List<T> Items { get; set; }
        public Stack_Practice() 
        {
            Items = new List<T>();
        }
        public int Count => Items.Count;

        public void Push(T item)
        {
            Items.Add(item);
        }
        public T Pop() 
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T Item = Items[Count - 1];
            int IndexItem = Count - 1;
            Items.RemoveAt(IndexItem);
            
            return Item;

        }
        public T Peek()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return Items[Count - 1];
        }
        public bool IsEmpty => Items.Count == 0;
        public void Clear()
        {
            Items.Clear();
        }
    }
}
