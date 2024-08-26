
using MeuRestaurante.Menu.DadosMesa;
DadosMesa Registro = new DadosMesa();
NotaFiscal notaFiscal = new NotaFiscal();
Comanda comanda = new Comanda();
while (true)
{
  Console.WriteLine("---SUSHI---");
  Console.WriteLine("1 - Criar Novo Pedido");
  Console.WriteLine("2 - Pagamentos");
  Console.WriteLine("3 - Sair");

  int Escolha = int.Parse(Console.ReadLine());
  if (Escolha == 3) { break; }

  Console.Write("Informe o numero da mesa:");
  int numeroDaMesa = int.Parse(Console.ReadLine());

  if (Escolha == 1)
  {
    List<Menu> pedidosExistentes = Registro.ObterPedidosDaMesa(numeroDaMesa); //aqui ele verifica se ja existe alguma mesa com aquele numero, se nao tiver ele cria um novo pedido.

    if (pedidosExistentes.Count > 0)
    {
      Console.WriteLine("\n----Entradas----");
    }
    var entradas = Entradas.ObterListaDeEntradas();
    PercorrerMenu.Percorrer(entradas);
    int escolhaEntrada = int.Parse(Console.ReadLine());
    if (escolhaEntrada > 0 && escolhaEntrada <= entradas.Count)
    {
      Menu itemEscolhido = entradas[escolhaEntrada - 1];
      Registro.AdicionarPedido(numeroDaMesa, itemEscolhido);
      Console.WriteLine($"Pedido {itemEscolhido.NomeProduto} Adicionado!\n"); //Adicionara o pedido a mesa.
    }
    else
    {
      Console.WriteLine("\nItem Invalido");
      continue;
    }

    var freestyles = FreeStyle.ObterFreeStyles();
    PercorrerMenu.Percorrer(freestyles);
    int escolhaFreestyle = int.Parse(Console.ReadLine());
    if (escolhaFreestyle > 0 && escolhaFreestyle <= freestyles.Count)
    {
      Menu itemEscolhido = freestyles[escolhaFreestyle - 1];
      Registro.AdicionarPedido(numeroDaMesa, itemEscolhido);
      Console.WriteLine($"\nPedido {itemEscolhido.NomeProduto} Adicionado!");
    }
    else
    {
      Console.WriteLine("\nItem Invalido");
      continue;
    }

    var bebidas = Bebidas.ObterlistaDeBebidas();
    PercorrerMenu.Percorrer(bebidas);
    int escolhaBebida = int.Parse(Console.ReadLine());
    if (escolhaBebida > 0 && escolhaBebida <= bebidas.Count)
    {
      Menu itemEscolhido = bebidas[escolhaBebida - 1];
      Registro.AdicionarPedido(numeroDaMesa, itemEscolhido);
      Console.WriteLine($"\nPedido {itemEscolhido.NomeProduto} Adicionado!");
    }
    else
    {
      Console.WriteLine("\nItem Invalido");
      continue;
    }

    Console.WriteLine("\nFinalizar Pedido? (S/N)");
    char FinalizandoOuAcrescentando = Convert.ToChar(Console.ReadLine().ToUpper());

    if (FinalizandoOuAcrescentando == 'S')
    {
      comanda.GerarComanda(numeroDaMesa, Registro);
    }

  }

  if (Escolha == 2)
  {
    Console.WriteLine("---PAGAMENTO---");
    Registro.ObterPedidosDaMesa(numeroDaMesa);
    notaFiscal.GerarNotaFiscal(numeroDaMesa, Registro);
    Console.WriteLine("Efetuar Pagamento!");
    System.Console.WriteLine("\nPagamento em cartão ou cedulas? (1 - cartao,2 - cedulas)");
    int EscolhaPagamento = int.Parse(Console.ReadLine());
    if (EscolhaPagamento == 1)
    {
      System.Console.WriteLine("Pagamento Concluido!\n");
    }
    else if (EscolhaPagamento == 2)
    {
      System.Console.WriteLine("Pagamento Concluido!\n");
    }
  }
}


