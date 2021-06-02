using System;
using ObjetosArgumentos.Classes;

namespace ObjetosArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            do
            {
                Console.WriteLine($@"
                ==============================
                |  Bem vindo ao SENAI Games  |
                ==============================
                | (1) Adicionar jogos        |
                ============================== 
                | (2) Listar Jogos           |
                ==============================
                | (3) Alterar jogos          |
                ==============================");
            } while (repetir);


            Produto product1 = new Produto(1, "Read Dead Redemption 2", 220f);
            Produto product2 = new Produto(2, "GTA V", 59f);
            Produto product3 = new Produto(3, "Detroit Become Human", 50f);
            Produto product4 = new Produto(4, "Celeste", 22.99f);

            Carrinho car = new Carrinho();

            car.AdicionarProduto(product1);
            car.AdicionarProduto(product2);
            car.AdicionarProduto(product3);
            car.AdicionarProduto(product4);

            car.Mostrar();

            car.MostrarTotal();
        }
    }
}
