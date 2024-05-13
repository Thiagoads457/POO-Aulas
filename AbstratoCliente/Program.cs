using AbstratoCliente; // reiplementação total do metodo da superclasse

//Cliente c = new Cliente();//não instanciará

ClienteFisico cf = new ClienteFisico(1,"Thiago","Rua Dois",35,1111);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(100,"Empresa","Rua Quatro",41,10000);
cj.Mostrar();

Teste t = new Teste();
t.VerificaIdade(cj);

