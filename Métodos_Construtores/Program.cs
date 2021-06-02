using System;
using Métodos_Construtores.Classes;

namespace Métodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de métodos contrutores");

            Produto p = new Produto();
        
            Console.WriteLine("Produto 1 (Construtor sem argumentos)");
            Console.WriteLine($"Codigo: {p.Codigo}\nNome: {p.Nome}\nDescrição: {p.Descricao}\nEstoque: {p.Estoque}");

            Produto p2 = new Produto(456);
            
            Console.WriteLine("Produto 2 (Construtor com 1 argumento)");
            Console.WriteLine($"Codigo: {p2.Codigo}\nNome: {p2.Nome}\nDescrição: {p2.Descricao}\nEstoque: {p2.Estoque}");

            Produto p3 = new Produto(789, "Maçã", "Maçãs belas e orgânicas", 3);

            Console.WriteLine("Produto 3 (Construtor com 4 argumentos)");
            Console.WriteLine($"Codigo: {p3.Codigo}\nNome: {p3.Nome}\nDescrição: {p3.Descricao}\nEstoque: {p3.Estoque}");
        }
    }
}
