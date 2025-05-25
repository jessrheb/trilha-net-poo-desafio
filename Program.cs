using DesafioPOO.Models;

Smartphone nokia = new Nokia(
    numero: "(89) 99796-7778",
    modelo: "Nokia XR21",
    iMEI: "352739201748685",
    memoria: 64
);

nokia.Ligar();
nokia.InstalarAplicativo("Bluesky");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(
    numero: "(24) 96912-4982",
    modelo: "iPhone 15 Pro Max",
    iMEI: "356303482246046",
    memoria: 128
);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
