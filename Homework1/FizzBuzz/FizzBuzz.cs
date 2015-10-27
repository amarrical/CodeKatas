using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class Printer
    {
        private int minimum;
        private int maximum;
        private List<Mutator> mutators;

        public Printer(int min, int max)
        {
            if (max < min)
            {
                throw new Exception("The maximum cannot be lesser to the minimum");
            }
            maximum = max;
            minimum = min;
            mutators = new List<Mutator>();
        }

        public void run()
        {
            int i;
            for (i = minimum; i <= maximum; ++i)
            {
                String text = String.Empty;
                foreach (Mutator m in mutators)
                {
                    if (i % m.getDivisor() == 0)
                    {
                        text += m.getText();
                    }
                }
                if (text == String.Empty)
                {
                    text = i.ToString();
                }
                Console.Write(text + " ");
            }
        }

        public void addMutator(Mutator m)
        {
            mutators.Add(m);
        }

        public void addMutator(int number, String text)
        {
            addMutator(new Mutator(number, text));
        }
    }
}
