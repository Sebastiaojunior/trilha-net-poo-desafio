using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234567", modelo: "Nokia 5.4", imei: "987654321", memoria: "128");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1234567", modelo: "Nokia 5.4", imei: "987654321", memoria: "128");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");