using System;
using System.Collections.Generic;

namespace Atributos_e_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem Thor = new Personagem();

            Thor.idade = 5000;
            Thor.armadura = "Armadura de URU";
            Thor.nome = "Thor";
            Thor.poder = 20;
            Thor.especial = 7;
            Thor.PontoVida = 1000;

            Personagem Superman = new Personagem();

            Superman.nome = "Superman";
            Superman.idade = 5233;
            Superman.armadura = "Armadura cósmica";
            Superman.poder = 19;
            Superman.especial = 6;
            Superman.PontoVida = 1000;

            Personagem HomemAranha = new Personagem();

            HomemAranha.nome = "Homem-Aranha";
            HomemAranha.idade = 18;
            HomemAranha.armadura = "Aranha de ferro";
            HomemAranha.poder = 10;
            Superman.especial = 2;
            HomemAranha.PontoVida = 1000;

            Personagem Batman = new Personagem();

            Batman.nome = "Batman";
            Batman.idade = 30;
            Batman.armadura = "HellBat";
            Batman.poder = 12;
            Batman.especial = 3;
            Batman.PontoVida = 1000;

            Personagem Cap = new Personagem();

            Cap.nome = "Capitão América";
            Cap.idade = 100;
            Cap.armadura = "Traje de soldado";
            Cap.poder = 11;
            Cap.especial = 4;
            Cap.PontoVida = 1000;

            Personagem Aquaman = new Personagem();

            Aquaman.nome = "Aquaman";
            Aquaman.idade = 3344;
            Aquaman.armadura = "Armadura de Atlântida";
            Aquaman.poder = 16;
            Aquaman.especial = 5;
            Aquaman.PontoVida = 1000;
        
            List<string> listaNome = new List<string>();
            listaNome.Add(Thor.nome);
            listaNome.Add(Superman.nome);
            listaNome.Add(Batman.nome);
            listaNome.Add(HomemAranha.nome);
            listaNome.Add(Aquaman.nome);
            listaNome.Add(Cap.nome);

            List<int> listaForca = new List<int>();
            listaForca.Add(Thor.poder);
            listaForca.Add(Superman.poder);
            listaForca.Add(Batman.poder);
            listaForca.Add(HomemAranha.poder);
            listaForca.Add(Aquaman.poder);
            listaForca.Add(Cap.poder);

            List<int> listaAtcEspecial = new List<int>();
            listaAtcEspecial.Add(Thor.especial);
            listaAtcEspecial.Add(Superman.especial);
            listaAtcEspecial.Add(Batman.especial);
            listaAtcEspecial.Add(HomemAranha.especial);
            listaAtcEspecial.Add(Aquaman.especial);
            listaAtcEspecial.Add(Cap.especial);

            List<int> listaVida = new List<int>();
            listaVida.Add(Thor.PontoVida);
            listaVida.Add(Superman.PontoVida);
            listaVida.Add(Batman.PontoVida);
            listaVida.Add(HomemAranha.PontoVida);
            listaVida.Add(Aquaman.PontoVida);
            listaVida.Add(Cap.PontoVida);


            do
            {
                Console.WriteLine($@"
            ===========================================
            |         Que comecem as batalhas!        |
            ===========================================
            | 1 - Escolher personagem                 |
            -------------------------------------------
            | 2 - Histórico de confrontos             |
            -------------------------------------------
            | 0 - Sair do SENAI Combat                |
            -------------------------------------------");
                int Escolha = int.Parse(Console.ReadLine());
                switch (Escolha)
                {
                    case 1:
                        Console.WriteLine($@"
            ===========================================
            | 0 - Thor                                |
            ===========================================
            | 1 - Superman                            |
            ===========================================
            | 2 - Batman                              |
            ===========================================
            | 3 - Homem Aranha                        |
            ===========================================
            | 4 - Aquaman                             |
            ===========================================
            | 5 - Capitão América                     |
            ===========================================");
                        int Persona1 = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($@"
            ===========================================
            | 0 - Thor                                |
            ===========================================
            | 1 - Superman                            |
            ===========================================
            | 2 - Batman                              |
            ===========================================
            | 3 - Homem Aranha                        |
            ===========================================
            | 4 - Aquaman                             |
            ===========================================
            | 5 - Capitão América                     |
            ===========================================");
                        int Persona2 = int.Parse(Console.ReadLine());

                        int i = 0;

                        while (listaVida[Persona1] > 0 && listaVida[Persona2] > 0)
                        {
                            Console.Clear();
                            Console.WriteLine($@"
            ===========================================
            |                  {listaNome[Persona1]}                   |
            ===========================================
            | 1 - Atacar o oponente                   |
            -------------------------------------------
            | 2 - Se defender do oponente             |
            -------------------------------------------
            |                Vida: {listaVida[Persona1]}                |
            -------------------------------------------");
                            int opcao1 = int.Parse(Console.ReadLine());

                            Console.Clear();
                            Console.WriteLine($@"
            ===========================================
            |                 {listaNome[Persona2]}                |
            ===========================================
            | 1 - Atacar o oponente                   |
            -------------------------------------------
            | 2 - Se defender do oponente             |
            -------------------------------------------
            |                Vida: {listaVida[Persona2]}                |
            -------------------------------------------");
                            int opcao2 = int.Parse(Console.ReadLine());

                            if (opcao1 == 1 && opcao2 == 1)
                            {
                                listaVida[Persona1] = listaVida[Persona1] - Thor.Atacar(listaForca[Persona2]);
                                listaVida[Persona2] = listaVida[Persona2] - Thor.Atacar(listaForca[Persona1]);
                            }
                            else if (opcao1 == 2 && opcao2 == 2)
                            {

                            }
                            else if (opcao1 == 1 && opcao2 == 2)
                            {
                                listaVida[Persona2] = listaVida[Persona2] - (Thor.Atacar(listaForca[Persona1]) - Thor.Defender());
                            }
                            else
                            {
                                listaVida[Persona1] = listaVida[Persona1] - (Thor.Atacar(listaForca[Persona2]) - Thor.Defender());
                            }

                            i++;
                        }

                        Console.WriteLine($@"Superman: {Superman.PontoVida}");
                        Console.WriteLine($@"Thor: {Thor.PontoVida}");
                }
                break;
                default:
                
                        break;


            } while (true);
        }
    }
}
