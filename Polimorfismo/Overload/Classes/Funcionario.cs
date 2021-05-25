using System;
namespace Overload.Classes
{
    public class Funcionario
    {
        public string[] lista = new string[5];

        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine(lista[indice]);
        }

        public void Mostrar(string buscar)
        {
            bool busca1 = true;
            int i = 0;
            do
            {
                if (i == lista.Length)
                {
                    busca1 = true;
                    Console.WriteLine("Este nome não existe em nosso sistema");
                }
                else if (buscar == lista[i])
                {
                    Console.WriteLine($"O nome {lista[i]} consta em nosso sistema");
                    busca1 = true;
                }else{
                    busca1 = false;
                }
                i++;
            } while (busca1 == false);
        }
    }
}