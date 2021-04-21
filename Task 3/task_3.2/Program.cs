using System;
using System.Collections;
using System.Collections.Generic;

namespace task_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>(3);
            List<int> list = new List<int>() { 10, 14 };

            //Console.WriteLine(array.Length());
            //Console.WriteLine(array.Capacity());
            //Console.WriteLine();

            array.Add(5);
            array.Add(3);
            array.Add(15);
            //array.AddRange(list);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            array.Insert(21, 1);

            Console.WriteLine();
            Console.WriteLine(array.Length());
            Console.WriteLine(array.Capacity());


            //array.Remove(3);

            Console.WriteLine();
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < array.Length(); i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }

    class DynamicArray<T> : IEnumerable, IEnumerable<T>//, IEnumerator
    {
        T[] array;
        private int size = 0;

        public object Current => throw new NotImplementedException();

        public DynamicArray() // 1
        {
            array = new T[8];
        }

        public DynamicArray(int Length) // 2
        {
            array = new T[Length];
        }

        public DynamicArray(ICollection<T> Collection) //3
        {
            array = new T[Collection.Count];
            Collection.CopyTo(array, 0);

        }

        private void Increase()
        {
            T[] NewArray = new T[2 * Capacity()];
            for (int i = 0; i < size; i++)
            {
                NewArray[i] = array[i];
            }

            array = NewArray;

            //throw new ArgumentOutOfRangeException();
        }

        private void Increase(int neskolko)
        {
            T[] NewArray = new T[neskolko * Capacity()];
            for (int i = 0; i < size; i++)
            {
                NewArray[i] = array[i];
            }

            array = NewArray;

            //throw new ArgumentOutOfRangeException();
        }

        public void Add(T element) //4
        {
            if (size >= Capacity())
            {
                Increase();
                //Console.WriteLine("Array has been increased");
            }
            array[size] = element;
            size++;
        }

        public void AddRange(ICollection<T> Collection) //5
        {
            if (Collection.Count > (Capacity() - Length()))
            {
                Increase(Collection.Count / Capacity() + 2); //отношение длины добавляеммой коллекции к обьему массива 
                                                             // +2, тк интовое деление и необходимость корректного расширения
                                                             //Console.WriteLine("Array has been increased for collection");
            }

            //Collection.CopyTo(array, size); 
            foreach (var el in Collection)
            {
                array[size] = el;
                size++;
            }
        }

        public bool Remove(T element) //6
        {
            int pos = -1;
            for (int i = 0; i < size; i++)
            {
                if (element.Equals(array[i]))
                {
                    pos = i;
                    break;
                }
            }

            if (pos == -1)
                return false;

            for (int i = pos; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            size--;
            array[size] = default;
            return true;
        }

        public bool Insert(T element, int pos) //7
        {
            if ((pos + 1) > Capacity())
                throw new ArgumentOutOfRangeException();

            if ((pos + 1) == Capacity() || Length() == Capacity())
            {
                Increase();
            }

            for (int i = size; i >= pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = element;
            size++;

            return true;
        }

        public int Length() //8
        {
            return size;
        }

        public int Capacity() //9
        {
            return array.Length;
        }

        public IEnumerator GetEnumerator() //10
        {
            for (int i = 0; i < Length(); i++)
            {
                yield return array[i];
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        public T this[int index] //11
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }


    }
}



