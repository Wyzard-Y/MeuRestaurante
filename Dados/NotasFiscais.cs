using MeuRestaurante.Menu.DadosMesa;

public class NotaFiscal
{
  private void Nota(int Mesa, DadosMesa registro)
  {
    var pedidosDaMesa = registro.ObterPedidosDaMesa(Mesa);
    Console.WriteLine($"---- MESA {Mesa} ----    {registro.ObterHoraChegada(Mesa)}");

    foreach (var pedido in pedidosDaMesa)
    {
      Console.WriteLine($"{pedido.NomeProduto} -- {pedido.ValorDoProduto:C2}");
    }

    Console.WriteLine($"\nTotal: {registro.TotalGastoPelaMesa(Mesa):C2}");
    Console.WriteLine("-----------------------\n");
  }


  public void GerarNotaFiscal(int Mesa, DadosMesa registro)
  {
    Nota(Mesa, registro);
  }
}
