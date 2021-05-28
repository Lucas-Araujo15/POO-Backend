using System;
namespace Exercícios.Classes
{
    public class JogadorAtaque : Jogador
    {
        public void AposentarAtc()
        {
            if (idade < 35)
            {
                int resposta = 35 - idade;
                Console.WriteLine($"Faltam {resposta} anos para você se aposentar.");
            }
            else
            {
                Console.WriteLine("A idade recomendada para um jogador de sua posição já foi alcançada.");
            }

            Console.WriteLine($@"
            ========================
            | Pressione 0 para sair|
            ========================");
        }
    }
}