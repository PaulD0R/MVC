using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class MyException : Exception
    {
        public MyException(string error) : base(error)
        {
        }
    }
}

