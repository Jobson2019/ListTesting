using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class CustomList<T>
    {
            

        public T this [int index]
        {
            get
            {
                T temp;
                if (index >= 0 && index <= count -1)
                {
                    temp = items[index];
                }
                else
                {
                    throw new System.ArgumentException("Index out of range");
                }
                return (temp);
            }
            set
            {
                if (index >= 0 && index <= capacity -1)
                {
                    items[index] = value;
                }
            }
        }

        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                GrowArray();
            }
            items[count] = itemToAdd;
            IncrementCount();
        }

        private T[] items;
            

            public CustomList ()
            {
                items = new T[4];
            }
            public void Add(T itemToAdd)
            {
             
            
                 
                
                    items[count] = itemToAdd;
                    IncrementCount();
                
            
            }
        private int count;
        private int capacity;

        public void GrowArray()
        {

        }
        
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
           get
            {
                return capacity;
            }
        }

            public void Clear()
            { 
            }
        public void IncrementCount()
        {
            count += 1;
        }



        
    }
}
