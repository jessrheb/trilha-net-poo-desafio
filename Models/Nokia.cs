namespace DesafioPOO.Models
{
    public class Nokia(string numero, string modelo, string iMEI, int memoria)
        : Smartphone(numero, modelo, iMEI, memoria)
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(
                $"Instalando aplicativo {nomeApp}... {nomeApp} instalado no seu {Modelo} com sucesso."
            );
        }
    }
}
