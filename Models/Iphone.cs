namespace DesafioPOO.Models
{
    // x TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // x TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"instalando o {nomeApp}. no {getModelo()}");
        }
    }
}