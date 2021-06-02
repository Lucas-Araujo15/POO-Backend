namespace Listas.Classes
{
    public class Produto
    {
        public int Codigo;
        public string Nome;
        public float preco;

        public Produto()
        {

        }

        public Produto(int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.preco = _preco;
        }
    }
}