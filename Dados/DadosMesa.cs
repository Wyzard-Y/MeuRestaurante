namespace MeuRestaurante.Menu.DadosMesa;

public class DadosMesa
{
  private Dictionary<int, List<Menu>> pedidosPorMesa = new Dictionary<int, List<Menu>>();
  private Dictionary<int, double> totalPorMesa = new Dictionary<int, double>();
  private Dictionary<int, DateTime> dataMesa = new Dictionary<int, DateTime>();


  public void AdicionarPedido(int Mesa, Menu item)
  {
    if (!pedidosPorMesa.ContainsKey(Mesa)) // se nao tiver nenhuma mesa com aquele valor, ele cria um espaço para ela.
    {
      pedidosPorMesa[Mesa] = new List<Menu>();
      totalPorMesa[Mesa] = 0;
      dataMesa[Mesa] = DateTime.Now;
    }
    pedidosPorMesa[Mesa].Add(item);
    totalPorMesa[Mesa] += item.ValorDoProduto;
  }
  public double TotalGastoPelaMesa(int Mesa)
  {
    return totalPorMesa.ContainsKey(Mesa) ? totalPorMesa[Mesa] : 0; //RETORNA O TOTAL QUE A MESA GASTOU.
  }

  public List<Menu> ObterPedidosDaMesa(int Mesa)
  {
    return pedidosPorMesa.ContainsKey(Mesa) ? pedidosPorMesa[Mesa] : new List<Menu>(); //Se houver, Retorna o pedido da mesa
  }
  public DateTime? ObterHoraChegada(int Mesa)
  {
    return dataMesa.ContainsKey(Mesa) ? dataMesa[Mesa] : (DateTime?)null; //Retorna o horario do pedido da mesa.
  }

}