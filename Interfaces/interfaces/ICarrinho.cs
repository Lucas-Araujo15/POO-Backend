using Interfaces.Classes;

namespace Interfaces.interfaces
{
    public interface ICarrinho
    {
         void Listar();
         void Cadastrar(Produto produto);
         void Alterar(int _codigo, Produto produto);
         void Deletar(int numCod);
         void MostrarTotal();
    }
}