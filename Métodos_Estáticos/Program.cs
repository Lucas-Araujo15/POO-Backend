using System;
using Métodos_Estáticos.Classes;

namespace Métodos_Estáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Conversor.DolarParaReais(52) );
            Console.WriteLine(Conversor.RealParaDolar(52) );
        }
    }
}
