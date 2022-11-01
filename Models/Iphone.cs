namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"App store: Instalando o aplicativo {nomeApp} com sucesso");
        }
    }
}