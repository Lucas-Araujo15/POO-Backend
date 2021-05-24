using System;
namespace Sistema_de_Pagamento.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;

        public void pagar()
        {
            float preco = this.Valor;

            if (preco > Saldo)
            {
                Console.WriteLine("Você não possui saldo suficiente.");
            }
            else
            {
                Console.WriteLine($"O valor de {preco:C2} foi pago.");
            }
        }
    }
}