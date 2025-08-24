using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia: ");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "IMEI123456", memoria: 32);
nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("-------------------------");

Console.WriteLine("Celular Iphone: ");
Iphone iphone = new Iphone(numero: "234567890", modelo: "Iphone 15", imei: "IMEI234567", memoria: 128);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
iphone.Ligar();