using RotNKata;
using System;

namespace RotNConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RotN rn = new RotN();

            Console.WriteLine(rn.Encrypt(1, "A"));
            Console.ReadLine();
        }
    }
}
