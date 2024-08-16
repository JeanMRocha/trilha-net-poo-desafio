using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone Nokia = new Nokia ("123456789", "IMEI12345", "ModeloNokiaX", "64GB");

Console.WriteLine ("Teste para o aplicativo Nokia Tijolão!");
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Sinal Gps");

Smartphone Iphone = new Iphone ("987654321", "IMEI54321", "Iphone Bugado", "32GB");
Console.WriteLine ("Teste para o aplicativo Iphone Bugado sem bateria!");
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Bateria Extra");

