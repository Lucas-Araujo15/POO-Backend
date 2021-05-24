using System;

namespace Sistema_de_Pagamento.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now;
        protected float Valor = 3000f;

        public string Cancelar(){
            return $"Pagamento cancelado.";
        }
    }
}