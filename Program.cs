using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n = new Nokia("169999999", "790", "hgds54gg78rs46fd4g8ew","4GB");
Iphone i = new Iphone("169888888", "12 plus", "sdf45das55fds75a","6GB");

n.InstalarAplicativo("whatsapp");
n.Ligar();
n.ReceberLigacao();
i.InstalarAplicativo("whatsapp");
i.Ligar();
i.ReceberLigacao();