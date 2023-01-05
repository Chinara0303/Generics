using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class IntList
    {
        private int[] _ints;
        public IntList()
        {
            _ints = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _ints, _ints.Length + 1);
            _ints[_ints.Length - 1] = num;
        }

        public void GetAll()
        {
            foreach (var item in _ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
