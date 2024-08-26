namespace MeuRestaurante.Menu.DadosMesa;
public class FreeStyle : Menu
{
  private static List<FreeStyle> FreeStyles = new List<FreeStyle>
        {
          new FreeStyle("16 Peças De Sushi", 19.00),
          new FreeStyle("24 Peças De Sushi", 27.50),
          new FreeStyle("38 Peças De Sushi e Sashimi", 52.0),
          new FreeStyle("Vegan Maki", 16.0)
        };

  public FreeStyle(string nomeProduto, double valorDoProduto)
      : base(nomeProduto, valorDoProduto)
  {
  }

  public static List<FreeStyle> ObterFreeStyles()
  {
    return FreeStyles; //Retorno a lista de entradas quando chamar o metodo.
  }

}
