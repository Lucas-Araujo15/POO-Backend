namespace Atributos_e_métodos
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;

        public int PontoVida;

        public int poder;
        public int especial;

        public int Atacar(int força){
            int ataque = 10 * força;
            return ataque;
        }

        public int Defender(){
            int defesa = 100;
            return defesa;
        }
    }
}