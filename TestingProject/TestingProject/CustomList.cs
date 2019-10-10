using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class CustomList<T>
    {
        private int count;
        private int capacity;

        public CustomList()
        {
            items = new T[4];
            capacity = 4;
            count = 0;
        }
        
        
        
        //private array
        private T[] items;

        //capacity property
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
                    throw new System.ArgumentException("Out of Bounds");
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
        //add method
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                GrowArray();
            }
            items[count] = itemToAdd;
            IncrementCount();
        }

        
            

           
            //public void Add(T itemToAdd)
            //{
             
            
                 
                
            //        items[count] = itemToAdd;
            //        IncrementCount();
                
            
            //}
       

        public void GrowArray()
        {
            int newSize = capacity * 2;
            T[] larger = new T[newSize];
            for (int i = 0; i < items.Length; i++)
            {
                larger[i] = items[i];
            }
            items = larger;
            Capacity = capacity * 2;
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
            set
            {
                capacity = value;
            }
        }

         public void Clear()
            { 
            }
        public void IncrementCount()
        {
            count += 1;
        }
        
        //need remove method
        //public bool Remove(T itemToRemove)
        //{
        //    for (int i = 0; i < items.Length; i++) 
        //    {
        //        if (items[i].Equals (itemToRemove))
        //        {
        //            return true;
        //        }
        //        if else (items[i] != (itemToRemove))
        //        {
        //            return false;
        //        }
                            

                

        //    }
        //}




        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(itemToRemove))
                {
                    for (int y = i; y < (items.Length - i); y++)
                    {
                        items[y] = items[y + 1];
                    }
                    count -= 1;
                    break;
                }
               
                




            }
        }
        // need to override ToString Method
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < items.Length; i++)
            {
               result += items[i].ToString();
            }
            return result;
              
        }

        //need to overload + and - operator and know what that means. Also, need to add .txt file which describes the details and funcitonality of my operator overload.


        //zip two custom list class instances together in the form of a zipper



    }
}
