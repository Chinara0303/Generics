using Generics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class DataList<T>
    {
        private T[] _arr;
        public DataList()
        {
            _arr = new T[0];
        }

        public void Add(T t)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = t;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
