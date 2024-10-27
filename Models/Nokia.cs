namespace DesafioPOO.Models
{
    // x TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
    
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // x TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeAPP){
            Console.WriteLine($"instalando o {nomeAPP}. no {getModelo()}");
        }
    }
}
