namespace DesafioFundamentosDIOConsole.Models;

public class Estacionamento
{
  private decimal valorInicial = 0;
  private decimal valorPorHora = 0;
  Utils utils = new Utils(0, 0);
  private List<string> veiculos = new List<string>();

  public Estacionamento(decimal valorInicial, decimal valorPorHora)
  {
    this.valorInicial = valorInicial;
    this.valorPorHora = valorPorHora;
    this.utils = new Utils(valorInicial, valorPorHora);
  }

  public void CadastrarVeiculo()
  {
    Console.WriteLine("");
    Console.WriteLine("Escreva a placa do veículo:");
    string placa = Convert.ToString(Console.ReadLine());
    this.veiculos.Add(placa);
    Console.WriteLine("");
    Console.WriteLine("Veículo estacionado com sucesso, pressione qualquer tecla para continuar");
    Console.Read();
    this.utils.ComeçarPrograma();
  }
  public void RemoverVeiculo() { }
  public void ListarVeiculos()
  {
    Console.WriteLine("");
    Console.WriteLine("Veículos estacionados:");
    foreach (string placa in this.veiculos)
    {
      Console.WriteLine(placa);
    }
    Console.WriteLine("");
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.Read();
    this.utils.ComeçarPrograma();
  }
}
