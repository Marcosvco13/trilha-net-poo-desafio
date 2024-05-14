namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero, Modelo, IMEI, Memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp}está sendo instalado no Nokia...");
        }
    }
}