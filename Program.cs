using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "+55 11 99955-1111", modelo: "n95 8G", imei: "010928/00/389023/3", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine("\n...\n");

Console.WriteLine("Smartphone IPhone:");

Smartphone iPhone = new Iphone(numero: "+55 11 91100-0000", modelo: "IPhone 12", imei: "00000123456789", memoria: 64);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Candy Crush");
