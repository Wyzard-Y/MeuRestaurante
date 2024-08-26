using MeuRestaurante.Menu.DadosMesa;
public class Comanda
{
  public void GerarComanda(int Mesa, DadosMesa registro)
  {
    var pedidosDaMesa = registro.ObterPedidosDaMesa(Mesa);
    Console.WriteLine($"---- MESA {Mesa} ---- {registro.ObterHoraChegada(Mesa)}");

    foreach (var pedido in pedidosDaMesa)
    {
      Console.WriteLine($"{pedido.NomeProduto}");
    }
  }
}