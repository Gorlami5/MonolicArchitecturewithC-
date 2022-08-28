using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SameProductException : Exception
    {
        public SameProductException(string message) : base(message)
        {

        }
    }
}
