using System;
using System.Threading;

namespace Elevador.Classes
{
    public abstract class Elevador
    {
        public int AndarAtual = 0;
        public int Andares { get; set; }
        public int capacidade { get; set; }
        public int NumPessoas { get; set; }

        public void Inicializa(int b)
        {
            capacidade = b;
            Andares = 11;
        }

        public virtual void Entrar(int entrando)
        {

            if (NumPessoas + entrando <= capacidade)
            {
                NumPessoas = NumPessoas + entrando;
            }
            else
            {
                Console.WriteLine("Capacidade máxima já alcançada");
            }
        }

        public virtual string Sair(int saindo)
        {

            if (NumPessoas >= saindo)
            {
                NumPessoas = NumPessoas - saindo;
                return $"Agora há {NumPessoas} passageiro no elevador.";
            }
            else
            {
                return "As pessoas já saíram";
            }
        }

        public void Subir(int subida)
        {


            string[] cssTerminal = new string[Andares];

            if (subida > AndarAtual && subida <= (Andares - 1))
            {
                for (var j = 0; j <= 10; j++)
                {
                    cssTerminal[j] = "           ";
                }
                for (int i = AndarAtual; i <= subida; i++)
                {
                    Console.Clear();
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.Red;
                    cssTerminal[i] = "|======";


                    Console.WriteLine($@"   
                            |      
                            |
                            |
                            |
                            /\
                          /    \
                        /        \
                      /            \
                    /               \
                    |                |
                    |     {cssTerminal[10]}|
                    |     {cssTerminal[9]}|
                    |     {cssTerminal[8]}|
                    |     {cssTerminal[7]}|
                    |     {cssTerminal[6]}|
                    |     {cssTerminal[5]}|
                    |     {cssTerminal[4]}|
                    |     {cssTerminal[3]}|
                    |     {cssTerminal[2]}|
                    |     {cssTerminal[1]}|
                    |     {cssTerminal[0]}|
                    |                |");
                    Thread.Sleep(2000);
                    cssTerminal[i] = "           ";
                    Console.ResetColor();

                }

                AndarAtual = subida;
            }
            else if (subida < AndarAtual)
            {
                AndarAtual = subida;
                Descer(Math.Abs(subida));

            }
        }

        public void Descer(int descida)
        {

            string[] cssTerminal = new string[Andares];
            if (descida < AndarAtual && descida >= 0)
            {
                for (var j = 0; j <= 10; j++)
                {
                    cssTerminal[j] = "           ";
                }

                for (int i = AndarAtual; i >= descida; i--)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    cssTerminal[i] = "|======";

                    Console.WriteLine($@"   
                            |      
                            |
                            |
                            |
                            /\
                          /    \
                        /        \
                      /            \
                    /               \
                    |                |
                    |     {cssTerminal[10]}|
                    |     {cssTerminal[9]}|
                    |     {cssTerminal[8]}|
                    |     {cssTerminal[7]}|
                    |     {cssTerminal[6]}|
                    |     {cssTerminal[5]}|
                    |     {cssTerminal[4]}|
                    |     {cssTerminal[3]}|
                    |     {cssTerminal[2]}|
                    |     {cssTerminal[1]}|
                    |     {cssTerminal[0]}|
                    |                |");
                    Thread.Sleep(2000);
                    cssTerminal[i] = "           ";
                    Console.ResetColor();
                }
                AndarAtual = descida;
            }
            else if (descida > AndarAtual)
            {
                AndarAtual = descida;
                Subir(descida);

            }


        }
    }
}