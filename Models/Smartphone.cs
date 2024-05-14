namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string  Modelo { get; set; }
        public int Memoria { get; set; }
        public string IMEI  {get; set;}
        public string Numero { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
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