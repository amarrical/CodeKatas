using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceProblem
{
    class Die
    {
        private int sides;
        private int loadedValue;
        private Random random;

        public Die(int s)
        {
            random = new Random((int)DateTime.Now.Millisecond);
            sides = s;
            loadedValue = -1;
        }

        public Die(int s, int value) : this(s)
        {
            loadedValue = value;
        }

        public int roll() {
            if (loadedValue > 0)
            {
                if (random.Next(1) % 2 == 0)
                {
                    return loadedValue;
                }
            }
            return random.Next(sides) + 1;
        }
    }
}
