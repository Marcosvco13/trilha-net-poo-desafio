using DesafioPOO.Models;

Console.WriteLine("Celular Nokia: ");

Smartphone nokia = new Nokia(Numero: "1234567890", Modelo: "Nokia C01 Plus", IMEI: "01277823", Memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine("Celular Iphone: ");

Smartphone iphone = new Iphone(Numero: "0987654321", Modelo: "15 Pro Max", IMEI: "02378629", Memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");