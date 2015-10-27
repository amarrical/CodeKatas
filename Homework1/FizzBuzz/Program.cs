using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(-3, -1);
            p.run();
            Console.ReadLine();
        }
    }
}
