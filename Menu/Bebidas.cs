namespace MeuRestaurante.Menu.DadosMesa;

public class Bebidas : Menu
{
  private static List<Bebidas> listaDeBebidas = new List<Bebidas>
        {
            new Bebidas("Coca-Cola", 2.50),
            new Bebidas("Ice Tea", 3.0),
            new Bebidas("Cerveja SuperBock", 4.0),
            new Bebidas("Cerveja Japonesa", 4.0)
        };

  public Bebidas(string nomeProduto, double valorDoProduto)
      : base(nomeProduto, valorDoProduto)
  {
  }

  public static List<Bebidas> ObterlistaDeBebidas()
  {
    return listaDeBebidas; //Retorno a lista de entradas quando chamar o metodo.
  }

}