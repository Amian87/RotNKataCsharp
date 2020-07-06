using System;
using RotNKata;

namespace RotNConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RotN rotN = new RotN();
            Console.WriteLine(rotN.Encrypt("CG", 5));
            Console.ReadKey();
        }
    }
}
