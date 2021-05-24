using System;

namespace Sistema_de_Pagamento.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string Bandeira;
        public string Numero;
        public string cvv;
        public string Titular;

        public string SalvarCartao(){
            Console.Write("Digite a bandeira do seu cartão: ");
            Bandeira = Console.ReadLine();

            Console.Write("Digite o número do seu cartão: ");
            Numero = Console.ReadLine();

            Console.Write("Digite o titular do seu cartão: ");
            cvv = Console.ReadLine();

            Console.Write("Digite o código de segurança do seu cartão: ");
            Titular = Console.ReadLine();

            return $"O cartão {Numero} foi cadastrado com sucesso!";

        }
    }
}