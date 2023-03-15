using OrientacaoObjeto;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1,"Mouse sem fio:",59.90M);
Console.WriteLine(p1.getDescriacao() + " " + p1.getValor());

Cliente pessoa1 = new Cliente(1, "Elias", "(16) 99417-0879");
Console.WriteLine(pessoa1.getNome() + ": " + pessoa1.getTelefone());