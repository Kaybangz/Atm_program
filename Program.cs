using System;

namespace Atm_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Atm_func atm = new Atm_func();

            atm.RunAtmProgram();
        }
    }
}