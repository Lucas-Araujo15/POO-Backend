using Override.Classes;
using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero z = new Zero();
            MegaMan m = new MegaMan();

           Console.WriteLine(z.Correr());
           Console.WriteLine(z.Pular());
        
           Console.WriteLine(m.Correr());
           Console.WriteLine(m.Pular());
        }
    }
}
