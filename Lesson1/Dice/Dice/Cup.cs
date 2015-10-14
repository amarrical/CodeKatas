using System;
using System.Collections.Generic;
using System.Linq;

namespace Dice
{
    internal class Cup
    {
        private List<IDie> dice;

        public Cup()
        {
            this.dice = new List<IDie>();
        }

        public string Roll()
        {
            var total = this.dice.Sum(d => d.Roll());
            return string.Format("You rolled {0} dice which totaled: {1}", dice.Count, total);
        }

        public void Empty()
        {
            this.dice.Clear();
        }

        public void Add(IDie die)
        {
            this.dice.Add(die);
        }
    }
}