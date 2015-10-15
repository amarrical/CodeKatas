using System;

namespace DieCup.Business
{
    internal class Die
    {
        private int? loadedValue;
        private double loadedChance;
        private int max;
        private int min;
        private static Random rnd = new Random();

        public Die(int min = 1, int max = 6, int? loadedValue = null, double loadedChance = 0.5)
        {
            if (loadedChance > 1)
                throw new ArgumentOutOfRangeException(
                    "The parameter 'loadedChance' must be between 0 and 1.");

            if (loadedValue <= min || loadedValue >= max)
                throw new ArgumentOutOfRangeException(
                    "The parameter 'loadedValue' must be between min and max.");

            if (min > max)
                throw new ArgumentOutOfRangeException(
                    "The value for min must be less than max.");

            this.min = min;
            this.max = max;
            this.loadedValue = loadedValue;
            this.loadedChance = loadedChance;
        }

        public int Roll()
        {
            return (loadedValue.HasValue && rnd.NextDouble() < loadedChance) ? 
                loadedValue.Value : 
                rnd.Next(min, max + 1);
        }
    }
}