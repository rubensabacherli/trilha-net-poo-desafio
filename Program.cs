using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "11223344", modelo: "Nokia Tijolão", imei: "seiláoqvaiaqui", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Zapzap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Apple");
Smartphone iphone = new Iphone(numero: "1928472", modelo: "Iphone 14", imei: "asdafqwfqwf", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");