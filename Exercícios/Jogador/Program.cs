using System;
using System.Threading;
using Exercícios.Classes;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque a = new JogadorAtaque();
            JogadorDefesa d = new JogadorDefesa();
            JogadorMeioCampo m = new JogadorMeioCampo();

            bool repetir = true;
            bool repetir1 = false;
            string sair;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
            ==================================
            |       Bem vindo ao FutNet!     |
            |________________________________|
            | (1) Cadastrar jogador          |
            ==================================
            | (2) Imprimir informações       |
            ==================================
            | (0) Sair                       |
            ==================================");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Qual o seu nome? ");
                        string name = Console.ReadLine();
                        a.nome = name;
                        m.nome = name;
                        d.nome = name;

                        Console.Write("Qual a sua nacionalidade? ");
                        string nac = Console.ReadLine();
                        a.nacionalidade = nac;
                        m.nacionalidade = nac;
                        d.nacionalidade = nac;

                        Console.Write("Qual sua data de nascimento? (DD/MM/AA) ");
                        string data = Console.ReadLine();
                        int ano = int.Parse(data.Substring(data.Length - 4, 4));

                        a.CalcularIdade(ano);
                        m.CalcularIdade(ano);
                        d.CalcularIdade(ano);

                        a.dataNascimento = data;
                        m.dataNascimento = data;
                        d.dataNascimento = data;

                        Console.Write("Qual a sua altura? ");
                        string altura = Console.ReadLine();
                        a.altura = altura;
                        m.altura = altura;
                        d.altura = altura;

                        Console.Write("Qual o seu peso? ");
                        string peso = Console.ReadLine();
                        a.peso = peso;
                        m.peso = peso;
                        d.peso = peso;
                        break;

                    case "2":


                        if (a.nome == null)
                        {
                            Console.Clear();
                            Console.WriteLine("Nenhum jogador foi cadastrado.");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine($@"
         ====================================
         |        Qual a sua posição?       |
         |__________________________________|
         | (1) Jogador de ataque            |
         ===================================|
         | (2) Jogador de defesa            |
         ===================================|
         | (3) Jogador de meio campo        |
         ====================================");

                                string opcao2 = Console.ReadLine();

                                switch (opcao2)
                                {
                                    case "1":
                                        do
                                        {
                                            Console.Clear();
                                            a.Imprimir();
                                            a.AposentarAtc();
                                            sair = Console.ReadLine();
                                        } while (sair != "0");

                                        break;

                                    case "2":
                                        do
                                        {
                                            Console.Clear();
                                            d.Imprimir();
                                            d.AposentarDef();
                                            sair = Console.ReadLine();
                                        } while (sair != "0");

                                        break;

                                    case "3":
                                        do
                                        {
                                            Console.Clear();
                                            m.Imprimir();
                                            m.AposentarMei();
                                            sair = Console.ReadLine();
                                        } while (sair != "0");

                                        break;
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Escolha somente alguma das opções apresentadas.");
                                        Thread.Sleep(2000);
                                        repetir1 = true;
                                        break;
                                }
                            } while (repetir1);
                        }
                        break;
                    case "0":
                        repetir = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha somente alguma das opções apresentadas.");
                        Thread.Sleep(2000);
                        repetir = true;
                        break;
                }

            } while (repetir);
        }
    }
}
