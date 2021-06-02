namespace Métodos_Construtores.Classes
{
    public class Produto
    {
        public Produto(){

        }

        public Produto(int codigo){
            Codigo = codigo;
        }

        public Produto(int codigo, string nome, string descricao, int estoque){
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Estoque = estoque;
        }
        public int Codigo { get; set; } 
        public string Nome { get; set; } 
        public string Descricao { get; set; } 
        public int Estoque { get; set; }
         
    }
}