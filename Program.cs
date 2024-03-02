using DesafioPOO.Models;

Nokia nokia  = new Nokia("21965611116", "Nokia", "asd", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Iphone iphone  = new Iphone("21965611116", "Nokia", "zxc", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");