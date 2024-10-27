namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public string getModelo(){
            return Modelo;
        }

        public void setModelo(string modelo){
            Modelo = modelo;
        }

        public string getIMEI(){
            return IMEI;
        }

        public void setIMEI(string Imei){
            IMEI = Imei;
        }

        public int getMemoria(){
            return Memoria;
        }

        public void setMemoria(int memoria){
            Memoria = memoria;
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // x TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;    // Changed parameter name to lowercase 'imei'
            Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
