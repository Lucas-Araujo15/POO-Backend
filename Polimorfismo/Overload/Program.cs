using System;
using Overload.Classes;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++){            
                Console.Write("Digite um funcionário: ");
                f.lista [i] = Console.ReadLine().ToUpper();
            }

            Console.WriteLine($@"
            O que deseja fazer? 
            
            (1) Listar nomes
            (2) Buscar um nome por índice
            (3) Buscar um nome
            ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    f.Mostrar();
                    break;

                case "2":
                    Console.Write("Digite um número: ");
                    int numero = int.Parse(Console.ReadLine()) - 1;
                    f.Mostrar(numero);
                    break;

                case "3":
                    Console.Write("Escreva um nome: ");
                    string nome = Console.ReadLine().ToUpper();
                    f.Mostrar(nome);
                    break;
            }
            


        }
    }
}
