using System;

namespace DieCup.Business
{
    internal class Die
    {
        private int? loaded;
        private double loadedChance;
        private int max;
        private int min;
        private static Random rnd = new Random();

        public Die(int min = 1, int max = 6, int? loaded = null, double loadedChance = 0.5)
        {
            if (loadedChance > 1)
                throw new ArgumentOutOfRangeException(
                    "The parameter 'loadedChance' must be between 0 and 1");

            this.min = min;
            this.max = max;
            this.loaded = loaded;
            this.loadedChance = loadedChance;
        }

        public int Roll()
        {
            return (loaded.HasValue && rnd.NextDouble() < loadedChance) ? 
                loaded.Value : 
                rnd.Next(min, max + 1);
        }
    }
}