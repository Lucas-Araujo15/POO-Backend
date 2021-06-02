using System;
using System.Collections.Generic;
using Listas.Classes;

namespace Listas
{
    class Program
    {
        private const float V = 1500.00f;

        static void Main(string[] args)
        {
            // CRUD - Create, Read, Update, Delete

            // Create
            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Apple Watch", 2352.32f));
            produtos.Add(new Produto(2, "Xiaomi", 2242.32f));
            produtos.Add(new Produto(3, "Samsung S9", 2352.32f));
            produtos.Add(new Produto(4, "Zenfone ASUS", 2122.32f));
            produtos.Add(new Produto(5, "Motorola G8", 3242.32f));

            Produto celular = new Produto();

            celular.Codigo = 3;
            celular.Nome = "Samsung A8";
            celular.preco = 4322.32f;

            produtos.Add(celular);

            // Read
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"\n{item.Nome} - {item.preco} - {item.Codigo}");
            }

            // Delete

            produtos.RemoveAt(3);

            produtos.RemoveAll(item => item.Nome == "Motorola G8");

            // Update
            Produto atualizacao = produtos.Find(item => item.Codigo == 2);
            atualizacao.preco = 1500.50f;

            produtos.RemoveAll(item => item.Codigo == 2);

            produtos.Insert(1, atualizacao);

            Console.WriteLine("\n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"\n{item.Nome} - {item.preco} - {item.Codigo}");
            }
        }
    }
}
