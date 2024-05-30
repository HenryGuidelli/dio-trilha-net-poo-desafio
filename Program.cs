using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo 1", imei: "111111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo 2", imei: "222222222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");