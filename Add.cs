using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArthmeticOperation
{
    internal class Add
    {
        public int Sum(int a, int b)
        {
            if (a == 0) 
            {
                return b;
            }
            else if (b == 0) 
                {
                    return a;
                }
            else {
                int c = a + b;

                return c;
            }
        }
    }
}
