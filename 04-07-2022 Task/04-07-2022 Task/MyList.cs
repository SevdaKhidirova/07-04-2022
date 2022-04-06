using System;
using System.Collections.Generic;
using System.Text;

namespace _07_04_2022_Task
{
    class MyList<T>
    {
        private T[] _arr = new T[0];
        private int _count;
        private int capacity = 0;
        private int length = 0;


        public void AddItem(T number)
        {
            if (ResizeAble())
                if (capacity == 0)
                {
                    capacity += 1;
                }
                else
                {
                    capacity *= 2;
                }
            Array.Resize(ref _arr, capacity);

            _arr[length] = number;
            length++;

        }
        public void AddItems(params T[] numbers)
        {
            foreach (var item in numbers)
            {
                AddItem(item);
            }
        }
        private bool ResizeAble()
        {
            if (length == capacity)
                return true;
            return false;
        }
        public void Capacity()
        {
            Console.WriteLine(capacity);
        }
        public void Count()
        {
            _count = length;
            Console.WriteLine(_count);
        }

        public void Clear()
        {
            _arr = new T[0];
            length = 0;
            _count = 0;
            capacity = 0;
        }

        public bool Exsist(T number)
        {
            foreach (T item in _arr)
            {
                if (number.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
        public void PrintArrayElements()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
        public void Reverse()
        {
           for(int i = length - 1; i >= 0; i--)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void Indexof(T number)
        {
            for(int i = 0; i < length; i++)
            {
                if (number.Equals(_arr[i]))
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("not foud");
        }
        public void LastIndexOf(T number)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (number.Equals(_arr[i]))
                {
                    Console.WriteLine(_arr[i]);
                    return;
                }
            }
            Console.WriteLine("not found");
        }

    }
}
