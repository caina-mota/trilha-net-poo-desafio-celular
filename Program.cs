using DesafioPOO.Models;


Nokia nokia = new("9999999", "x1", "123456789", 8);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("Outlook");
nokia.InstalarAplicativo("Banco A");
nokia.ListarAplicativosInstalados();


System.Console.WriteLine("###########################################");
System.Console.WriteLine("###########################################");
System.Console.WriteLine("###########################################");

Iphone iphone = new("9999991", "12", "112345678", 12);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("IMessage");
iphone.InstalarAplicativo("ICloud");
iphone.ListarAplicativosInstalados();
