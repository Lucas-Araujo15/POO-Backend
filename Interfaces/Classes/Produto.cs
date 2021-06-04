using System;

namespace Interfaces.Classes
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get;set;}
        public float Preco {get;set;}

        public Produto(string _Nome, float _Preco){
            this.Nome = _Nome;
            this.Preco = _Preco;
            Random cod = new Random();
            this.Codigo = cod.Next(0, 9999);

        }
    }
}