using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoview = new ProdutoView();
        public void ListarProdutos()
        {
            //List<Produto> produtos = produto.Ler();

            //produtoview.Listar(produtos);

            produtoview.Listar(produto.Ler());
        }

        public void Cadastrar(){
            produto.Inserir(produtoview.CadastrarProduto());
        }
    }
}