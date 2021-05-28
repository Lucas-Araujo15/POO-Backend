using System;
namespace Elevador.Classes
{
    public class ElevadorServico : Elevador
    {
        public int capacidadeCaixas = 5;
        public int caixasAtual = 0;
        public override void Entrar(int NumCaixa)
        {
            
            if (NumCaixa <= capacidadeCaixas - caixasAtual)
            {
                caixasAtual = caixasAtual + NumCaixa;
                Console.WriteLine($"Agora temos {caixasAtual} caixas ");
            }
            else
            {
                Console.WriteLine("Não é seguro adicionar essa quantidade de caixas.");
            }
        }

        public override string Sair(int NumCaixa)
        {
            
            if (NumCaixa <= caixasAtual)
            {
                caixasAtual = caixasAtual - NumCaixa;
                return $"Agora há {caixasAtual} no elevador.";
            }
            else
            {
                return "Não há essa quantidade de caixas no elevador";
            }
        }
    }
}