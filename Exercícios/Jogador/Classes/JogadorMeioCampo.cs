using System;
namespace Exercícios.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        public void AposentarMei()
        {
            if (idade < 38)
            {
                int resposta = 38 - idade;
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