using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceProblem
{
    class Program
    {
        public static void askForValues(Cup cup)
        {
            Console.WriteLine("1: Regular Dice");
            Console.WriteLine("2: Loaded Dice");

            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many sides?");

            int sides = Convert.ToInt32(Console.ReadLine());
            int loadedValue = -1;
            if (option == 2)
            {
                Console.WriteLine("What is the loaded value?");
                loadedValue = Convert.ToInt32(Console.ReadLine());
            }

            cup.addLoadedDie(sides, loadedValue);

        }

        static void Main(string[] args)
        {

            Cup cup = new Cup();
            while (true)
            {
                Console.WriteLine("1: Roll Dice");
                Console.WriteLine("2: Add Dice");
                Console.WriteLine("3: Empty Cup");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine(cup.roll());
                        break;
                    case 2:
                        askForValues(cup);
                        break;
                    case 3:
                        cup.emptyCup();
                        Console.WriteLine("Emptied Cup");
                        break;
                    default:
                        Console.WriteLine("You Fail");
                        break;
                }
            }
        }
    }
}
