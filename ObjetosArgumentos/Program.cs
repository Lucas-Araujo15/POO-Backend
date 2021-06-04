using System;
using ObjetosArgumentos.Classes;
using System.Threading;

namespace ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int i = 1;
            bool repetir = true;
            bool repetir1 = false;
            bool repetir2 = false;
            bool repetir3 = false;

            Carrinho car = new Carrinho();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"

                         SENAI Games
                ==============================
                |          Carrinho          |
                ==============================
                | (1) Adicionar jogos        |
                ============================== 
                | (2) Listar Jogos           |
                ==============================
                | (3) Alterar jogos          |
                ==============================
                | (4) Salvar para depois     |
                ==============================
                | (5) Comprar novamente      |
                ==============================
                | (6) Comprar                |
                ==============================
                | (0) Sair                   |
                ==============================
                ");
                Console.ResetColor();

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        do
                        {
                            Console.Clear();

                            Console.Write("Qual o nome do produto? ");
                            string name = Console.ReadLine();

                            Console.Write($"Qual o preço de {name}? ");
                            float price = float.Parse(Console.ReadLine());

                            car.AdicionarProduto(new Produto(i, name, price), 0);

                            i++;

                            Console.Write("Deseja adicionar mais algum produto?(s/n) ");
                            string resposta = Console.ReadLine().ToLower();

                            if (resposta == "s")
                            {
                                repetir1 = true;
                            }
                            else
                            {
                                repetir1 = false;
                            }


                        } while (repetir1);
                        break;
                    case "2":
                        car.Mostrar(0);
                        Thread.Sleep(3000);

                        break;
                    case "3":

                        if (car.carrinho.Count > 0)
                        {
                            do
                            {
                                Console.Clear();
                                car.Mostrar(0);
                                Console.Write("Digite o código do produto que deseja alterar: ");
                                int code = int.Parse(Console.ReadLine());

                                Console.Clear();
                                Console.Write("Digite um novo nome: ");
                                string name2 = Console.ReadLine();

                                Console.Write("Digite um novo preço: ");
                                float price2 = float.Parse(Console.ReadLine());

                                car.AlterarProduto(code, new Produto(code, name2, price2));

                                Console.WriteLine("Produto alterado com sucesso!");

                                Console.Write("Deseja alterar mais algum produto?(s/n) ");
                                string resposta = Console.ReadLine().ToLower();

                                if (resposta == "s")
                                {
                                    repetir2 = true;
                                }

                            } while (repetir2);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("O carrinho está vazio!");
                            Thread.Sleep(3000);
                        }
                        break;

                    case "4":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($@"
                    ======================================
                    | (1) Listar salvos para mais tarde  |
                    ======================================
                    | (2) Salvar para mais tarde         |
                    ======================================
                    | (0) Voltar                         |
                    ======================================");
                        Console.ResetColor();
                        string tarde = Console.ReadLine();

                        switch (tarde)
                        {
                            case "1":
                                Console.Clear();
                                car.Mostrar(1);
                                Thread.Sleep(5000);

                                if (car.maisTarde.Count > 0)
                                {
                                    Console.WriteLine("Deseja adicionar algum produto para o carrinho? (s/n) ");

                                    if (Console.ReadLine().ToLower() == "s")
                                    {
                                        Console.Write("Digite o código do produto que deseja adicionar: ");
                                        int cod = int.Parse(Console.ReadLine());
                                        car.AdicionarProduto(car.maisTarde.Find(item => item.codigo == cod), 0);
                                        car.maisTarde.RemoveAll(item => item.codigo == cod);
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Nenhum item foi adicionado a esta lista.");
                                    Thread.Sleep(3000);
                                }
                                break;

                            case "2":
                                do
                                {
                                    Console.Clear();

                                    Console.Write("Qual o nome do produto? ");
                                    string name = Console.ReadLine();

                                    Console.Write($"Qual o preço de {name}? ");
                                    float price = float.Parse(Console.ReadLine());

                                    car.AdicionarProduto(new Produto(i, name, price), 1);

                                    i++;

                                    Console.Write("Deseja adicionar mais algum produto?(s/n) ");
                                    string resposta = Console.ReadLine().ToLower();

                                    if (resposta == "s")
                                    {
                                        repetir3 = true;
                                    }
                                    else
                                    {
                                        repetir3 = false;
                                    }
                                } while (repetir3);

                                break;
                            case "0":
                                repetir = true;
                                break;
                        }
                        break;
                    case "5":
                        if (car.comprado.Count > 0)
                        {
                            car.Mostrar(2);
                            Console.Write("Digite o código do produto que deseja comprar novamente: ");
                            car.AdicionarProduto(car.comprado.Find(item => item.codigo == int.Parse(Console.ReadLine())), 0);
                            Console.Clear();
                            Console.WriteLine("Produto adicionado ao carrinho!");
                            Thread.Sleep(3000);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum item foi  comprado recentemente.");
                            Thread.Sleep(3000);
                        }


                        break;
                    case "6":
                        Console.Clear();
                        car.Mostrar(0);
                        car.MostrarTotal();
                        if (car.carrinho.Count > 0)
                        {
                            Console.Write("Deseja comprar definitivamente? (s/n) ");

                            if (Console.ReadLine().ToLower() == "s")
                            {
                                foreach (Produto item in car.carrinho)
                                {
                                    car.comprado.Insert(c, item);
                                    c++;
                                }
                                car.carrinho.RemoveAll(item => item.Nome != null);
                            }
                            else
                            {
                                repetir = true;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Não há nada no carrinho");
                            Thread.Sleep(2000);
                            repetir = true;
                        }
                        break;
                    case "0":
                        repetir = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha somente alguma das opções apresentadas");
                        Thread.Sleep(3000);
                        break;
                }

            } while (repetir);
        }
    }
}
