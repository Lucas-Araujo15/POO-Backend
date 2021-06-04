using System;
using Interfaces.Classes;
using System.Threading;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            Carrinho car = new Carrinho();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
                        
                ==============================
                |          Carrinho          |
                ==============================
                | (1) Adicionar produto      |
                ============================== 
                | (2) Listar produto         |
                ==============================
                | (3) Alterar produto        |
                ==============================
                | (4) Deletar produto        |
                ==============================
                | (0) Sair                   |
                ==============================
                ");
                Console.ResetColor();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Qual o nome do produto? ");
                        string name = Console.ReadLine();

                        Console.Write($"Qual o preço de {name}? ");
                        float price = float.Parse(Console.ReadLine());

                        car.Cadastrar(new Produto(name, price));
                        break;

                    case "2":
                        if (car.carrinho.Count > 0)
                        {
                            Console.Clear();
                            car.Listar();
                            car.MostrarTotal();
                            Thread.Sleep(5000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O carrinho está vazio!");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }

                        break;

                    case "3":

                        if (car.carrinho.Count > 0)
                        {
                            Console.Clear();
                            car.Listar();

                            Console.Write("Digite o código do produto que deseja alterar: ");
                            int num = int.Parse(Console.ReadLine());

                            Console.Write("Digite um novo nome para o produto: ");
                            string name1 = Console.ReadLine();

                            Console.Write($"Digite um novo preço para {name1}: ");
                            float price1 = float.Parse(Console.ReadLine());

                            car.Alterar(num, new Produto(name1, price1));
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O carrinho está vazio!");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }

                        break;

                    case "4":
                        if (car.carrinho.Count > 0)
                        {
                            Console.Clear();
                            car.Listar();
                            Console.Write("Digite o código do produto que deseja deletar: ");
                            int num1 = int.Parse(Console.ReadLine());
                            car.Deletar(num1);
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("O carrinho está vazio!");
                            Thread.Sleep(3000);
                            Console.ResetColor();
                        }

                        break;

                    case "0":
                        repetir = false;
                        break;
                    default:
                        break;
                }

            } while (repetir);
        }
    }
}
