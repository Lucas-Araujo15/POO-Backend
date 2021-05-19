using System;
using System.Threading;


namespace AulaPOOCelular
{
    class Program
    {

        static int i = 0;
        static int j = 0;
        static void Main(string[] args)
        {


            bool repetir1 = false;
            bool repetir2 = false;
            bool telaInfo = false;

            Celular on = new Celular();
            do
            {
                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($@"
            _______________________________________
            | ___________________________________ |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |            Ligar(0)             | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |_________________________________| |                                 
            |                                     |
            |                                     |                                     
            |_____________________________________|
            
            ");
                    Console.ResetColor();
                    string inicio = Console.ReadLine();
                    if (inicio == "0")
                    {
                        on.OnOff = true;
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(on.Ligar());
                            Console.ResetColor();
                            string opcao = Console.ReadLine();

                            switch (opcao)
                            {
                                case "1":
                                    repetir2 = true;
                                    break;
                                case "2":
                                    repetir2 = true;
                                    on.OnOff = false;
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write("Digite o nome do contato: ");
                                    string contato = Console.ReadLine();
                                    Console.Write("Digite uma mensagem: ");
                                    string mensagem = Console.ReadLine();
                                    Console.ResetColor();
                                    Console.Clear();
                                    DateTime hora = DateTime.Now;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine(on.Enviar(contato, mensagem, i, hora));
                                    Console.ResetColor();
                                    Thread.Sleep(3000);
                                    repetir2 = true;
                                    i++;

                                    break;
                                case "4":
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                    Console.Write("Digite o número: ");
                                    string lig = Console.ReadLine();
                                    DateTime Tempo = DateTime.Now;
                                    Console.Clear();
                                    Console.WriteLine(on.Ligando(lig, j, Tempo));
                                    Thread.Sleep(3000);
                                    Console.Clear();
                                    Console.WriteLine($@"
            _______________________________________
            | ___________________________________ |
            | |                                 | |
            | |     =======================     | |
                            {lig}              
            | |     =======================     | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |       CHAMADA NÃO ATENDIDA      | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |_________________________________| |                                 
            |   Voltar       Home      desligar   |
            |    (1)         (2)          (0)     |                                     
            |_____________________________________|
            ");
                                    Console.ResetColor();
                                    Thread.Sleep(3000);
                                    repetir2 = true;
                                    j++;
                                    break;
                                case "5":
                                    do
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(on.Informacoes());
                                        Console.ResetColor();
                                        string saida = Console.ReadLine();

                                        switch (saida)
                                        {
                                            case "1":
                                                repetir2 = true;
                                                break;
                                            case "2":
                                                repetir2 = true;
                                                break;
                                            case "0":
                                                repetir2 = false;
                                                repetir1 = true;
                                                on.OnOff = false;
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Escolha alguma das opções.");
                                                Thread.Sleep(2000);
                                                telaInfo = true;
                                                break;

                                        }
                                    } while (telaInfo);
                                    break;
                                case "0":
                                    repetir2 = false;
                                    repetir1 = true;
                                    on.OnOff = false;
                                    break;
                                case "6":
                                    if (i == 0)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nenhuma mensagem foi enviada");
                                        Console.ResetColor();
                                        Thread.Sleep(2000);
                                        repetir2 = true;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        for (int w = 0; w <= i - 1; w++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(on.ListarMensagens(w));
                                            Console.ResetColor();
                                            Console.WriteLine("\n");
                                        }

                                        do
                                        {
                                            Console.Write("Pressione 0 para sair: ");
                                            repetir2 = true;
                                        } while (Console.ReadLine() != "0");
                                    }

                                    break;
                                case "7":
                                    if (j == 0)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Nenhuma chamada foi efetuada");
                                        Console.ResetColor();
                                        Thread.Sleep(2000);
                                        repetir2 = true;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        for (int y = 0; y <= j - 1; y++)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(on.ListarChamadas(y));
                                            Console.ResetColor();
                                            Console.WriteLine("\n");
                                        }
                                        do
                                        {
                                            Console.Write("Pressione 0 para sair: ");
                                            repetir2 = true;
                                        } while (Console.ReadLine() != "0");
                                    }

                                    break;
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Escolha alguma das opções.");
                                    Thread.Sleep(2000);
                                    repetir2 = true;
                                    break;
                            }

                        } while (repetir2);

                    }
                    else if (inicio == "00")
                    {
                        repetir1 = false;
                        on.OnOff = false;
                    }
                } while (on.OnOff == true);


            } while (repetir1);

        }
    }
}
