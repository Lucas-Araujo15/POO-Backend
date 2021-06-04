namespace Métodos_Estáticos.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.24f;
        public static float RealParaDolar(float valorRS)
        {
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReais(float valorUS)
        {
            return CotacaoDolar * valorUS;
        }
    }
}