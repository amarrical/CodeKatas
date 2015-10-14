using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceProblem
{
    class Cup
    {
        private List<Die> dice;

        public Cup()
        {
            dice = new List<Die>();
        }

        public Cup(int n, int sides)
        {
            dice = new List<Die>();
            for (int i = 0; i < n; i++)
            {
                Die die = new Die(sides);
                dice.Add(die);
            }
        }

        public int roll()
        {
            int total = 0;
            foreach(Die die in dice) {
                total += die.roll();
            }
            return total;
        }

        public void addRegularDie(int sides)
        {
            Die die = new Die(sides);
            dice.Add(die);
        }

        public void addLoadedDie(int sides, int loadedValue)
        {
            Die die = new Die(sides, loadedValue);
            dice.Add(die);
        }

        public void emptyCup()
        {
            dice.Clear();
        }
    }
}
