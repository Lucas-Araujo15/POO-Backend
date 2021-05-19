namespace AulaPOOCelular
{
    public class Celular
    {
        public string cor = "preto";
        public string modelo = "Moto G6";
        public string tamanho = "5,6 pol.";
        public string[] nomes = new string[1000];
        public string [] mensagens = new string [1000];
        public string [] chamadas = new string [1000];

        public System.DateTime [] datas1 = new System.DateTime [1000];
        public System.DateTime [] datas2 = new System.DateTime [1000];

        public bool OnOff;

        public string Ligar()
        {

            string eeee = $@"
            _______________________________________
            | ___________________________________ |
            | |                                 | |
            | |          HELLO WORLD! =D        | |
            | |                                 | |
            | | =============================== | |
            | | |     Enviar mensagem (3)     | | |
            | | |=============================| | |
            | | |      Fazer ligação (4)      | | |
            | | |=============================| | |
            | | |  Informações do celular(5)  | | |
            | | =============================== | |
            | | |  Histórico de mensagens(6)  | | |
            | | =============================== | |
            | | |  Histórico de chamadas(7)   | | |
            | | =============================== | |
            | |                                 | |
            | |                                 | |
            | |_________________________________| |                                 
            |   Voltar       Home      desligar   |
            |    (1)         (2)          (0)     |                                     
            |_____________________________________|
            
            ";

            return eeee;

        }

        public string Enviar(string cont, string mens, int s, System.DateTime horas)
        {
            nomes[s] = cont;
            mensagens[s] = mens;
            datas1[s] = horas;
            

            string kkk = $@"
            _______________________________________
            | ___________________________________ |
            | |       ONLINE HÁ 5 MINUTOS       | |
            | |     =======================     | |
                            {cont}              
            | |     =======================     | |
            | |                                 | |
            | |                                 | |
            | |      ENVIADO!                   | |
            | |                                 | |
            | |                                 | |
            | |                        {mens}         
            | |                                 
            | |                                 
            | |                                 
            | |                                 
            | |---------------------------------| |
            | | Digite uma mensagem...          | |
            | |_________________________________| |                                 
            |   Voltar       Home      desligar   |
            |    (1)         (2)          (0)     |                                     
            |_____________________________________|
            ";

            return kkk;

        }

        public string Ligando(string num, int g, System.DateTime tempo)
        {
            datas2[g] = tempo;
            chamadas[g] = num;
            
            string jjj = $@"
            _______________________________________
            | ___________________________________ |
            | |                                 | |
            | |     =======================     | |
                            {num}              
            | |     =======================     | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |            LIGANDO...           | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |_________________________________| |                                 
            |   Voltar       Home      desligar   |
            |    (1)         (2)          (0)     |                                     
            |_____________________________________|
            ";

            return jjj;
        }
        public string Informacoes()
        {
            string mmm = $@"
            _______________________________________
            | ___________________________________ |
            | |                                 | |
            | |     =======================     | |
            | |     |      Cor: {cor}     |     | |
            | |     =======================     | |
            | |     |    Modelo: {modelo}  |     | |
            | |     =======================     | |
            | |     |   Tamanho: {tamanho} |     | |
            | |     =======================     | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |                                 | |
            | |_________________________________| |                                 
            |   Voltar       Home      desligar   |
            |    (1)         (2)          (0)     |                                     
            |_____________________________________|
            ";

            return mmm;
        }

        public string ListarMensagens(int h){
                return $@"
                =====================================
                | Contato: {nomes[h]}              
                =====================================
                | Mensagem: {mensagens[h]}  
                =====================================
                | Hora: {datas1[h]}                  
                =====================================";
            
        }

        public string ListarChamadas(int p){
            return $@"
                =====================================
                | Contato: {chamadas[p]}              
                =====================================
                | Hora: {datas2[p]} 
                =====================================";
        }

    }
}