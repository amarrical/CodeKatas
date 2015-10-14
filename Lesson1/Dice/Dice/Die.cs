using System;

namespace Dice
{
    internal class Die : IDie
    {
        private readonly int _sides;

        public Die(int sides)
        {
            _sides = sides;
        }

        public int Roll()
        {
            var rnd = new Random();
            return rnd.Next(1, this._sides + 1);
        }
    }
}