using System.Collections.Generic;
using System;
using Interfaces.interfaces;

namespace Interfaces.Classes
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        public List<Produto> carrinho = new List<Produto>();
        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(x => x.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = produto.Preco;
            ValorTotal = 0;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(int numCod)
        {
            carrinho.Remove(carrinho.Find(x => x.Codigo == numCod));
            ValorTotal = 0;
        }

        public void Listar()
        {
            Console.Clear();
            foreach (Produto item in carrinho)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($@"
                =====================================
                |Descrição: {item.Nome}
                =====================================
                |Preço: {item.Preco:C2}
                =====================================
                |Código: {item.Codigo}
                =====================================
                ");
                Console.ResetColor();
            }
        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    ValorTotal += item.Preco;
                }

                Console.WriteLine($"Total: {ValorTotal:C2}");
            }
            else
            {
                Console.WriteLine("O carrinho está vazio");
            }
            Console.ResetColor();
            ValorTotal = 0;
        }
    }
}
