using System;
namespace Exercícios.Classes
{
    public class JogadorDefesa : Jogador
    {
        public void AposentarDef()
        {
            if (idade < 40)
            {
                int resposta = 40 - idade;
                Console.WriteLine($"Faltam {resposta} anos para você se aposentar.");
            }
            else
            {
                Console.WriteLine("A idade máxima recomendada para um jogador de sua posição já foi alcançada.");
            }

            Console.WriteLine($@"
            ========================
            | Pressione 0 para sair|
            ========================");
        }
    }
}