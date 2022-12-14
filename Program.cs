using DesafioPOO.Models;

Iphone Iphone = new Iphone("1234", "modelo1", "1234", 64);
Nokia Nokia = new Nokia("4321", "modelo1", "4321", 32);

Nokia.Ligar();
Iphone.ReceberLigacao();

Nokia.InstalarAplicativo("WhatsApp");
Iphone.InstalarAplicativo("Telegram");