using System;
using System.Threading;
namespace Cafeteria.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;
        public int acucarPadrao = 10;

        public bool semAcucar = false;
        bool repetir = false;

        public void FazerCafe(int quantidade)
        {

            do
            {
                if (acucarDisponivel - quantidade >= 0 || semAcucar == true)
                {
                    acucarDisponivel = acucarDisponivel - quantidade >= 0 ? acucarDisponivel = acucarDisponivel - quantidade : acucarDisponivel = 0;
                    Painel(quantidade);
                    repetir = false;
                }
                else
                {
                    Painel();
                }
            } while (repetir);


        }

        public void FazerCafe()
        {
            do
            {
                if (acucarDisponivel - acucarPadrao >= 0 || semAcucar == true)
                {
                    acucarDisponivel = acucarDisponivel - acucarPadrao >= 0 ? acucarDisponivel = acucarDisponivel - acucarPadrao : acucarDisponivel = acucarDisponivel + 0;

                    if (semAcucar == true)
                    {
                        int k = acucarPadrao;
                        acucarPadrao = 0;
                        Painel(acucarPadrao);
                        acucarPadrao = k;


                    }
                    else
                    {
                        Painel(acucarPadrao);
                    }
                    repetir = false;
                }
                else
                {
                    Painel();
                }
            } while (repetir);

        }


        public void Painel(int quant)
        {

            Console.Clear();
            Console.WriteLine("Preparando...");
            Thread.Sleep(3000);

            Console.WriteLine($@"

           =============================
           |     Café finalizado!      |
           |===========================|
           |     (             )       |
           |     \=============/==     |
           |      \           /  |     |
           |       \_________/===|     |
           =============================
           | --> Açúcar adicionado ao café (gramas): {quant}
           | --> Açúcar restante (gramas): {acucarDisponivel}
            ");




        }

        public void Painel()
        {
            Console.Clear();
            Console.WriteLine($@"
                ==============================
                |   Açúcar insuficiente =(   |
                 ______________________________
                |  (1) Reabastecer           |
                ==============================
                |  (2) Café sem açúcar       |
                ==============================
                |  (0) Cancelar              |
                ==============================");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    acucarDisponivel = acucarDisponivel + (100 - acucarDisponivel);
                    Console.Clear();
                    Console.WriteLine("Reabastecendo...");
                    Thread.Sleep(2000);
                    repetir = true;
                    break;

                case "2":
                    repetir = true;
                    semAcucar = true;
                    break;

                case "0":

                    break;

                default:

                    break;
            }
        }
    }
}