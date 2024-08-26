namespace MeuRestaurante.Menu.DadosMesa;

public class Entradas : Menu
{
  private static List<Entradas> listaDeEntradas = new List<Entradas>
        {
            new Entradas("Temaki", 9.0),
            new Entradas("Gyosas De Frango 6un.", 12.0),
            new Entradas("Camaraio Fio Batata 8un.", 12.0),
            new Entradas("Camarão Panko", 12.0)
        };

  public Entradas(string nomeProduto, double valorDoProduto)
      : base(nomeProduto, valorDoProduto)
  {
  }

  public static List<Entradas> ObterListaDeEntradas()
  {
    return listaDeEntradas; //Retorno a lista de entradas quando chamar o metodo.
  }

}
