using System.Collections.Generic;
using System;
namespace ObjetosArgumentos.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Mostrar()
        {

            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{item.preco:C2}\n{item.Nome}\n{item.codigo}\n");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine("O carrinho está vazio");
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    ValorTotal += item.preco;
                }

                Console.WriteLine($"Total: {ValorTotal:C2}");
            }
            else
            {
                Console.WriteLine("O carrinho está vazio");
            }
            Console.ResetColor();
        }

        public void AlterarProduto(int _codigo, Produto novoproduto)
        {
            carrinho.Find(item => item.codigo == _codigo).Nome = novoproduto.Nome;
            carrinho.Find(item => item.codigo == _codigo).preco = novoproduto.preco;
        }
    }
}