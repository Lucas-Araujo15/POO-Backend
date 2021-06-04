using System.Collections.Generic;
using System;
namespace ObjetosArgumentos.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        public List<Produto> carrinho = new List<Produto>();
        public List<Produto> maisTarde = new List<Produto>();
        public List<Produto> comprado = new List<Produto>();

        public void AdicionarProduto(Produto produto, int salvar)
        {
            if (salvar == 0)
            {
                carrinho.Add(produto);
            }
            else
            {
                maisTarde.Add(produto);
            }
        }

        public void RemoverProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void Mostrar(int list)
        {
            Console.Clear();
            if (list == 0)
            {
                if (carrinho.Count > 0)
                {
                    Listagem(carrinho);
                }
                else
                {
                    Console.WriteLine("O carrinho está vazio");
                }
            }
            else if (list == 1)
            {
                if (maisTarde != null)
                {
                    Listagem(maisTarde);
                }
                else
                {
                    Console.WriteLine("Não há nenhum produto salvo para mais tarde.");
                }
            }
            else
            {
                if (comprado.Count > 0)
                {
                    Listagem(comprado);
                }
                else
                {
                    Console.WriteLine("Nenhum produto foi comprado nos últimos meses.");
                }
            }

        }
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (carrinho.Count > 0)
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
            ValorTotal = 0;
        }

        public void AlterarProduto(int _codigo, Produto novoproduto)
        {
            carrinho.Find(item => item.codigo == _codigo).Nome = novoproduto.Nome;
            carrinho.Find(item => item.codigo == _codigo).preco = novoproduto.preco;
        }
        public void Listagem(List<Produto> test)
        {
            foreach (Produto item in test)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($@"
                        =================================
                        |Preço: {item.preco:C2}
                        =================================
                        |Descrição: {item.Nome}
                        =================================
                        |Código: {item.codigo}
                        =================================");
                Console.ResetColor();
            }
        }
    }
}