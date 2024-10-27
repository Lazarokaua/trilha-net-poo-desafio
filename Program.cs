using DesafioPOO.Models;

// x TODO: Realizar os testes com as classes Nokia e Iphone

Nokia meuNokia = new Nokia("2253-1177", "C30", "123456789-00", 32);

meuNokia.Ligar();
meuNokia.InstalarAplicativo("YouTube");
meuNokia.ReceberLigacao();
Console.WriteLine($"memoria: {meuNokia.getMemoria().ToString()}");

Iphone iphone= new Iphone("4002-8922", "XS", "12345678-00", 258);

iphone.Ligar();
iphone.InstalarAplicativo("Excel");
iphone.ReceberLigacao();
Console.WriteLine($"memoria: {iphone.getMemoria().ToString()}");

