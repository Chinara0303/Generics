using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class StringList
    {
        private string[] _strings;
        public StringList()
        {
            _strings= new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref _strings, _strings.Length + 1);
            _strings[_strings.Length-1] = str;
        }

        public void GetAll()
        {
            foreach (var item in _strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
