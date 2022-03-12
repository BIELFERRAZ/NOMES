 string nome , sobrenome, sobrenomeEmMaiusculo;

 Console.Write("Digita seu primeiro nome: ");
 nome = Console.ReadLine()!;

 Console.Write("Digite seu segundo nome: ");
 sobrenome = Console.ReadLine()!;

 sobrenomeEmMaiusculo = sobrenome.ToUpper();

 Console.WriteLine($"Nome completo: {nome}  {sobrenome}" );

 Console.WriteLine($"nome do catálogo: {sobrenomeEmMaiusculo}, {nome}");
