namespace ObjetosArgumentos.Classes
{
    public class Produto
    {
        public int codigo { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, string nome, float preco)
        {
            this.codigo = codigo;
            this.Nome = nome;
            this.preco = preco;
        }

    }
}