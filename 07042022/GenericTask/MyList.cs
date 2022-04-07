using System;
using System.Collections.Generic;
using System.Text;

namespace GenericTask
{
    internal class MyList<T>
    {
        T[] arr = new T[100];
        public T this[int index]
        {
            get => arr[index];
            set { arr[index] = value; }
        }
    }
}
