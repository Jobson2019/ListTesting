using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    public class CustomList<T> : IEnumerable<T>
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
        public T this[int index]
        {
            get
            {
                T temp;
                if (index >= 0 && index < count)
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
                if (index >= 0 && index < capacity)
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
        public void DecrementCount()
        {
            count -= 1;
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



        //remove
        public T[] Remove(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                {
                    DecrementCount();
                    for (int x = i; x < Count; x++)
                    {
                        items[x] = items[x + 1];
                    }
                    return items;
                }
                else
                {
                    continue;
                }
            }
            return items;
        }
        // need to override ToString Method
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += items[i].ToString();
            }
            return result;

        }

        // overload + operator
        public static CustomList<T> operator + (CustomList<T> listOne, CustomList<T> listTwo)
        {
            foreach (T item in listTwo)
            {
                listOne.Add(item);
            }
            return listOne;
        }

        // overload - operator
        public static CustomList<T> operator - (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();
            CustomList<T> temp = new CustomList<T>();
            temp = listTwo;

            foreach (T item in listOne)
            {
                if (temp.Contains(item))
                {
                    temp.Remove(item);
                }
                else
                {
                    result.Add(item);
                }

            }
            return result;

        }

       // iterator

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public CustomList<T> Zip(CustomList<T> listTwo)
        {
            CustomList<T> result = new CustomList<T>();

            if (count > listTwo.count)
            {
                for (int i = 0; i < listTwo.count; i++)
                {
                    result.Add(items[i]);
                    result.Add(items[i]);
                }
                for (int i = (count - listTwo.count); i < count; i++)
                {
                    result.Add(items[i]);
                }
            }
            if (count < listTwo.count)
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(items[i]);
                    result.Add(listTwo[i]);
                }
                for (int i = (listTwo.count - count); i < listTwo.count; i++)
                {
                    result.Add(items[i]);
                }

            }
            if (count == listTwo.count)
            {
                for (int i = 0; i < count; i++)
                {
                    result.Add(items[i]);
                    result.Add(listTwo[i]);
                }
                
            }
            return result;
        }

        //need to overload + and - operator and know what that means. Also, need to add .txt file which describes the details and funcitonality of my operator overload.
        //1 + 1 = 2 "go" + "packers!" = "Go Packers"
        //public int (int one, int two)
        //     {
        //    int sum = one + two;
        //    return sum;
        //    }
        // CustomList<int> odd = new CustomList<int>() {1,3,5}
        // CustomList<int> even = new CustomList<int>() {2,4,6};
        // CustomList<int> result = odd + even;


        //zip two custom list class instances together in the form of a zipper



    }
}
