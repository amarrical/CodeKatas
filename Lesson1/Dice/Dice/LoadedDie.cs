using System;

namespace Dice
{
    internal class LoadedDie : IDie
    {
        private readonly int _sides;
        private readonly int _load;

        public LoadedDie(int sides, int load)
        {
            _sides = sides;
            _load = load;
        }

        public int Roll()
        {
            var rnd = RandomFeeder.Feeder;
            int roll;
            if (rnd.Next(1, 3) >= 2)
            {
                roll = this._load;
            }
            else
            {
                do
                {
                    roll = rnd.Next(1, _sides + 1);
                } while (roll == this._load);
            }

            return roll;
        }
    }
}