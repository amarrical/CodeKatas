using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DieCup.Business
{
    public class CupOfDice
    {
        private List<Die> dice;

        public CupOfDice(
            int count = 1, 
            int min = 1, 
            int max = 6, 
            int? loadedVal = null, 
            double loadedChance = 0.5)
        {
            this.dice = new List<Die>();

            for (int i = 0; i < count; i++) {
                dice.Add(new Die(min, max, loadedVal, loadedChance));
            }
        }

        public IList<int> RollDice()
        {
            var results = new List<int>();
            dice.ForEach(die => results.Add(die.Roll()));
            return results;
        }
    }
}
