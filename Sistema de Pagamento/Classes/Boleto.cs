using System;
namespace Sistema_de_Pagamento.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;

        Random r = new Random();

        public void Registrar(){
            CodigoDeBarras = r.Next(3000000).ToString();
            Console.WriteLine($"Boleto com o código de barras {CodigoDeBarras} registrado!");
            Console.WriteLine($"O valor total é igual a {this.Valor * 0.88}, com todos os descontos aplicados");
        }
    }
}