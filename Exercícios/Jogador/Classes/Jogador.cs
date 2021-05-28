using System;

namespace Exercícios.Classes

{
    public abstract class Jogador
    {
        public string nacionalidade;
        public string nome;
        public string dataNascimento;
        public string altura;
        public int idade;
        public string peso;

        public void Imprimir()
        {
            Console.WriteLine($@"
            ======================================
            |Nome              |{nome}
            ======================================
            |Nacionalidade     |{nacionalidade}
            ======================================
            |Data de nascimento|{dataNascimento}
            ======================================
            |Peso              |{peso}
            ======================================");
        }

        public void CalcularIdade(int nasc)
        {
            int anoAtual = DateTime.Now.Year;
            idade = anoAtual - nasc;
        }
    }
}