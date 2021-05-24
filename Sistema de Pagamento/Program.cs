using System;
using Sistema_de_Pagamento.Classes;

namespace Sistema_de_Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            Console.WriteLine($@"
            Escolha uma forma de pagamento:
            
            B - Boleto
            C - Crédito
            D - Débito
            X - Cancelar pagamento");

            string opcao = Console.ReadLine().ToLower();

            do
            {
                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registrar();
                        break;

                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        break;

                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.pagar();
                        break;

                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        break;

                    default:
                        Console.WriteLine("Opcão inválida.");
                        opcaoValida = true;
                        break;
                }
            } while (opcaoValida);


        }
    }
}
