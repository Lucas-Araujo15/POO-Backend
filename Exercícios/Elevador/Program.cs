using System;
using Elevador.Classes;
using System.Threading;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            ElevadorSocial s = new ElevadorSocial();
            ElevadorServico se = new ElevadorServico();

            int y;
            int x;
            int d;
            int b;
            int a;
            int c;
            int f;
            int w;

            bool confirmacao = true;
            bool confirmacao1 = true;

            Console.Write("Qual a capacidade do elevador social? ");
            int z = int.Parse(Console.ReadLine());
            Console.Write("Qual a capacidade do elevador de serviço? ");
            int ç = int.Parse(Console.ReadLine());
            s.Inicializa(z);
            se.Inicializa(ç);

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"
            Qual elevador deseja pegar?

              (1) Elevador social                       (2) Elevador de servico
            _________________________                  _________________________ 
            |           |           |                  |           |           |  
            |           |           |                  |           |           |
            |           |           |       |===|      |           |           |
            |           |           |       | ^ |      |           |           |  
            |           |           |       | v |      |           |           | 
            |           |           |       |===|      |           |           |
            |           |           |                  |           |           |
            |           |           |                  |           |           |
            |           |           |                  |           |           |
            |           |           |                  |           |           |
            |___________|___________|                  |___________|___________|     

            (0) Sair
            ");
                Console.ResetColor();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":



                        do
                        {
                            SobeDesce();
                            string opcao2 = Console.ReadLine();
                            switch (opcao2)
                            {
                                case "1":
                                    do
                                    {
                                        Console.Clear();
                                        Console.Write("Quantos passageiros vão entrar? ");
                                        a = int.Parse(Console.ReadLine());
                                    } while (a > s.capacidade - s.NumPessoas);

                                    s.Entrar(a);


                                    do
                                    {
                                        PainelAndares();
                                        b = int.Parse(Console.ReadLine());
                                    } while (b > s.Andares || b < 0);

                                    s.Subir(b);

                                    Console.Clear();
                                    Console.Write("Quantos passageiros vão sair? ");
                                    int e = int.Parse(Console.ReadLine());
                                    Console.WriteLine(s.Sair(e));
                                    Thread.Sleep(2000);

                                    confirmacao = false;
                                    break;

                                case "2":
                                    do
                                    {
                                        Console.Clear();
                                        Console.Write("Quantos passageiros vão entrar? ");
                                        c = int.Parse(Console.ReadLine());
                                    } while (c > s.capacidade - s.NumPessoas);

                                    s.Entrar(c);


                                    do
                                    {
                                        PainelAndares();
                                        d = int.Parse(Console.ReadLine());
                                    } while (d > s.Andares || d < 0);

                                    s.Descer(d);

                                    Console.Clear();
                                    Console.Write("Quantos passageiros vão sair? ");
                                    int k = int.Parse(Console.ReadLine());
                                    Console.WriteLine(s.Sair(k));
                                    Thread.Sleep(2000);

                                    confirmacao = false;
                                    break;

                                default:
                                    Console.WriteLine("Escolha alguma das opções.");
                                    confirmacao = true;
                                    break;
                            }
                        } while (confirmacao);

                        break;
                    case "2":

                        do
                        {
                            SobeDesce();
                            string opcao2 = Console.ReadLine();
                            switch (opcao2)
                            {
                                case "1":
                                    do
                                    {
                                        Console.Clear();
                                        Console.Write("Quantas caixas vão entrar? ");
                                        w = int.Parse(Console.ReadLine());
                                    } while (w > se.capacidadeCaixas - se.caixasAtual);

                                    se.Entrar(w);

                                    do
                                    {
                                        PainelAndares();
                                        x = int.Parse(Console.ReadLine());
                                    } while (x > se.Andares || x < 0);

                                    se.Subir(x);

                                    Console.Clear();
                                    Console.Write("Quantos caixas vão sair? ");
                                    int p = int.Parse(Console.ReadLine());
                                    Console.WriteLine(se.Sair(p));
                                    Thread.Sleep(2000);

                                    confirmacao = false;
                                    break;

                                case "2":

                                    do
                                    {
                                        Console.Clear();
                                        Console.Write("Quantos caixas vão entrar? ");
                                        f = int.Parse(Console.ReadLine());
                                    } while (f > se.capacidadeCaixas - se.caixasAtual);

                                    se.Entrar(f);


                                    do
                                    {
                                        PainelAndares();
                                        y = int.Parse(Console.ReadLine());
                                    } while (y > se.Andares || y < 0);

                                    se.Descer(y);

                                    Console.Clear();
                                    Console.Write("Quantas caixas vão sair? ");
                                    int j = int.Parse(Console.ReadLine());
                                    Console.WriteLine(se.Sair(j));
                                    Thread.Sleep(2000);

                                    confirmacao = false;
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("Escolha alguma das opções.");
                                    confirmacao = true;
                                    break;
                            }
                        } while (confirmacao);
                        break;
                    case "0":
                        confirmacao1 = false;
                        break;
                    default:
                        confirmacao1 = true;
                        break;

                }
            } while (confirmacao1);



        }

        static void PainelAndares()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Write($@"
                                        
                                         Qual o andar? 
                                        _______________
                                        |  |10|  |9|  |
                                        |             |
                                        |  |8|   |7|  |
                                        |             |
                                        |  |6|   |5|  |
                                        |             |
                                        |  |4|   |3|  |
                                        |             |
                                        |  |2|   |1|  |
                                        |             |
                                        |  |0|        |
                                        |=============|");
            Console.ResetColor();
        }
        static void SobeDesce()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"
                    ==========================
                    |        Subir(1)        |
                    |========================|
                    |        Descer(2)       |
                    ==========================");
            Console.ResetColor();
        }
    }
}
