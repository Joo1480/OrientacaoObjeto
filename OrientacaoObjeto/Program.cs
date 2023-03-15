using OrientacaoObjeto;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1,"Mouse sem fio:",59.90M);
Console.WriteLine(p1.getDescriacao() + " " + p1.getValor());

//Cliente pessoa1 = new Cliente(1, "Elias", "(16) 99417-0879");
//Console.WriteLine(pessoa1.getNome() + ": " + pessoa1.getTelefone());

Endereco e1 = new Endereco("Rua Joaquim Alves da silva Leitão", "04", "15902-192", "Talavasso", "Taquaritinga", "SP");

Cliente c1 = new Cliente(1, "João Elias", "99417-0879",e1);
Cliente c2 = new Cliente(2, "Samuel", "99417-0880", e1);
Cliente c3 = new Cliente(3, "Thais", "99417-0881", e1);
Cliente c4 = new Cliente(4, "Ramon", "99417-0882", e1);

Console.WriteLine(c1.getEndereco().getRua());
//c1.getEndereco().setRua("Prudente de Moraiss");
Console.WriteLine(c1.getEndereco().getEnderecoCompleto());

Carro car = new Carro();
car.Marca = "VolksWagner";
car.NumeroPortas = 4;
car.NumeroRodas = 4;
car.Cor = "Verde";
car.QuantidadeAcento = 5;
car.PagaImposto = true;


Aviao aviao = new Aviao();
aviao.PortasInternas = 50;
aviao.NumeroPortas = 30;
aviao.Cor = "Branco";
aviao.NumeroRodas = 3;
aviao.QuantidadeAcento = 500;
aviao.PagaImposto =  false;

Bicicleta bike = new Bicicleta();
bike.PagaImposto = false;

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());