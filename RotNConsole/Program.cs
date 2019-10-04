using RotNKata;
using System;

namespace RotNConsole
{
    class Program
    {
        

        static void Main(string[] args)
        {
             RotN rn = new RotN();

            Console.WriteLine(rn.Encrypt("CG", 5));
            Console.ReadKey();
        }
    }
}
