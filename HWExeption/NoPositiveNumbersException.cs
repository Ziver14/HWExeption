using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExeption
{
    public class NoPositiveNumbersException : Exception
    {
        public NoPositiveNumbersException() : base("Список не содержит положительных чисел.") { }
    }
}
