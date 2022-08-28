using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SameNameExcepiton:Exception
    {
        public SameNameExcepiton(string message):base (message) 
        {

        }
    }
}
