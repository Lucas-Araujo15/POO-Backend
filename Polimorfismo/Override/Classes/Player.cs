namespace Override.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr(){
            return "O player está correndo =D";
        } 

        public virtual string Pular(){
            return "O player está pulando =D";
        }
    }
}