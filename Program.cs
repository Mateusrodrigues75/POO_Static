using System;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReal(52));
            Console.WriteLine(Conversor.RealParaDolar(52));
            Console.WriteLine(Conversor.EuroParaReal(52));
            Console.WriteLine(Conversor.RealParaEuro(52));
        }
    }
}
