using Cafeteria.Classes;
using System.Threading;
using System;

namespace Cafeteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            MaquinaCafe coffee = new MaquinaCafe();
            bool repetir2 = true;
            bool repetir3 = false;
            do
            {
                coffee.semAcucar = false;
                Console.Clear();
                Console.WriteLine($@"
                
                ============================================
                |    Bem vindo(a) a Cafeteira Tabajaras    |
                |                Plus ++                   |
                ============================================
                | (1) Café personalizado                   |
                --------------------------------------------
                | (2) Café padrão                          |
                --------------------------------------------
                | (3) Preferências                         |
                --------------------------------------------
                | (0) Sair                                 |
                --------------------------------------------
                
                -------------------------------
                |Açúcar disponível (gramas): {coffee.acucarDisponivel}
                -------------------------------
                
                ");
                string resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Console.Clear();
                        int qnt;
                        do
                        {
                            Console.Write("Qual a quantidade de açúcar que deseja adicionar? (gramas) ");
                            qnt = int.Parse(Console.ReadLine());
                        } while (qnt > coffee.acucarDisponivel);


                        coffee.FazerCafe(qnt);
                        Thread.Sleep(4000);
                        break;

                    case "2":
                        coffee.FazerCafe();
                        Thread.Sleep(4000);
                        break;

                    case "3":

                        do
                        {
                            Console.Clear();
                            Console.WriteLine($@"
                   ================================
                   |         Preferências         |
                   ================================
                   | (1) Reabastecer açúcar       |
                   --------------------------------
                   | (2) Mudar açúcar padrão      |
                   --------------------------------
                   | (0) Voltar                   |
                   --------------------------------  ");
                            string pref = Console.ReadLine();
                            switch (pref)
                            {
                                case "1":

                                    if (coffee.acucarDisponivel == 100)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("A máquina já está completa");
                                        Thread.Sleep(2000);
                                    }
                                    else
                                    {
                                        coffee.acucarDisponivel = coffee.acucarDisponivel + (100 - coffee.acucarDisponivel);
                                        Console.Clear();
                                        Console.WriteLine("Reabastecendo...");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        Console.WriteLine("Reabastecido!");
                                        Thread.Sleep(2000);
                                    }

                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine($@"
                                ===========================================
                                | Quantidade de acúcar padrão (gramas): {coffee.acucarPadrao}   |
                                ===========================================");

                                    do
                                    {
                                        Console.Write($@"
                                Digite a quantidade preferida ---> ");
                                        a = int.Parse(Console.ReadLine());
                                        coffee.acucarPadrao = a;
                                    } while (a > 100);
                                    break;

                                case "0":
                                    repetir2 = true;
                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Escolha alguma das opções apresentadas.");

                                    Thread.Sleep(2000);
                                    repetir3 = true;

                                    break;
                            }


                        } while (repetir3);
                        break;
                    case "0":
                        repetir2 = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escolha alguma das opções apresentadas.");

                        Thread.Sleep(2000);
                        repetir2 = true;
                        break;
                }

            } while (repetir2);
        }
    }
}
