using System;
using System.Collections.Generic;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> ListaProduto)
        {
            foreach (Produto item in ListaProduto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C2}");
            }
        }
        public Produto CadastrarProduto()
        {
            Produto prod = new Produto();

            Console.Write($"Digite um código: ");
            prod.Codigo = int.Parse(Console.ReadLine());

            Console.Write($"Digite um nome: ");
            prod.Nome = Console.ReadLine();
            
            Console.Write($"Digite um preço: ");
            prod.Preco = float.Parse(Console.ReadLine());
            
            return prod;
        }
    }
}
