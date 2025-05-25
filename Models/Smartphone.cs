namespace DesafioPOO.Models
{
    public abstract class Smartphone(string numero, string modelo, string iMEI, int memoria)
    {
        public string Numero { get; set; } = numero;
        public string Modelo { get; set; } = modelo;
        protected string IMEI { get; set; } = iMEI;
        protected int Memoria { get; set; } = memoria;

        public void Ligar()
        {
            Console.WriteLine($"Fazendo ligação do número {Numero}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no número {Numero}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
