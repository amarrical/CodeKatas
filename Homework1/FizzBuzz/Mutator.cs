using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Mutator
    {
        private int divisor;
        private String text;

        public Mutator(int d, String t)
        {
            if (d < 1)
            {
                throw new Exception("The Divisor can not be lesser than 1");
            }
            divisor = d;
            text = t;
        }

        public int getDivisor()
        {
            return divisor;
        }

        public String getText()
        {
            return text;
        }
    }
}
