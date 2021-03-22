using System;
using Gtk;

namespace UIR_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calc = new calculator();

            calc.getSetR = 6.0;

            Console.WriteLine(calc.getSetR);
        }
    }
}
