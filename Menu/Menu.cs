

namespace MeuRestaurante.Menu.DadosMesa;

public class Menu : IProduto
{
  public string? NomeProduto { get; private set; }
  public double ValorDoProduto { get; private set; }

  public Menu(string nomeProduto, double valorDoProduto)
  {
    NomeProduto = nomeProduto;
    ValorDoProduto = valorDoProduto;
  }
  public Menu() { }


}

public static class PercorrerMenu
{
  public static void Percorrer<T>(List<T> itens) where T : IProduto
  {
    foreach (var item in itens)
    {
      Console.WriteLine($"{item.NomeProduto} -- {item.ValorDoProduto:C2}");
    }
  }
}

public interface IProduto //interface criada para que eu possar percorrer o item de qualquer lista.
{
  string? NomeProduto { get; }
  double ValorDoProduto { get; }
}