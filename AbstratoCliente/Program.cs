using AbstratoCliente; // reiplementação total do metodo da superclasse

//Cliente c = new Cliente();//não instanciará

ClienteFisico cf = new ClienteFisico(1,"Thiago","Rua Dois",1111);

ClienteJuridico cj = new ClienteJuridico(100,"Empresa","Rua Quatro",10000);

cj.Mostrar();
cf.Mostrar();
