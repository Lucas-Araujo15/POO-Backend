using System;
namespace Sistema_de_Pagamento.Classes
{
    public class Credito : Cartao
    {
        int vezes;
        private float Limite = 5000f;

        public void Pagar()
        {
            float valor = this.Valor;

            if (valor > Limite)
            {
                Console.WriteLine("Erro! O limite não é suficiente.");
            }
            else
            {
                double dividido;
                double parcelado;

                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o {valor:C2}? (de 1 a 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes > 0 && vezes <= 6)
                    {
                        dividido = this.Valor / vezes;
                        parcelado = dividido * 1.05;

                        Console.WriteLine($"Você pagará {vezes} de {parcelado:C2}.");
                    }
                    else if (vezes > 7 && vezes <= 12)
                    {
                        dividido = this.Valor / vezes;
                        parcelado = dividido * 1.05;

                        Console.WriteLine($"Você pagará {vezes} de {parcelado:C2}.");
                    }
                    else
                    {
                        Console.WriteLine("Não são possíveis parcelas maiores que 12.");
                    }
                } while (vezes > 12 || vezes < 1);

            }
        }

    }
}