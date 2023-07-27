using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class Stack<T>
    {
        public List<T> items { get; set; }
       

        public Stack() 
        {
            items = new List<T>();
        }
        
        //public int Count()   // this is the updated code version >> public int Count => items.Count;
        //{
        //    return items.Count;
        //}

        public int Count => items.Count;

        public void Push(T item) 
        {
            items.Add(item);
        }

        public T Pop() 
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            int lastIndex = Count - 1;
            T item = items[lastIndex];
            items.RemoveAt(lastIndex);
            return item;
        }

        public T Peek() 
        {
            if(Count == 0) 
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return items[Count - 1];
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void Clear()
        {
            items.Clear();
        }
       
    }
}
