using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
 Nokia nokia = new Nokia( numero: "123456",  modelo: "ABCDEF",  IMEI: "35987654321",  memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("\nIphone: ");
 Iphone iphone = new Iphone(numero: "654321",  modelo: "FEDCBA",  IMEI: "35123456789",  memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");