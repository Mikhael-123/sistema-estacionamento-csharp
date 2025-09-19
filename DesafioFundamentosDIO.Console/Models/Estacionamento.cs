namespace DesafioFundamentosDIOConsole.Models;

public class Estacionamento
{
  private decimal valorInicial = 0;
  private decimal valorPorHora = 0;
  Utils utils = new Utils(0, 0);
  public List<string> veiculos = new List<string>();

  public Estacionamento(decimal valorInicial, decimal valorPorHora)
  {
    this.valorInicial = valorInicial;
    this.valorPorHora = valorPorHora;
    this.utils = new Utils(valorInicial, valorPorHora);
  }

  public void CadastrarVeiculo()
  {
    Console.WriteLine("");
    Console.WriteLine("Escreva a placa do veículo que você deseja estacionar:");
    string placa = Console.ReadLine();
    this.veiculos.Add(placa);
    Console.WriteLine("");
    Console.WriteLine("Veículo estacionado com sucesso, pressione qualquer tecla para continuar");
    Console.Read();
    this.utils.ComeçarPrograma(this.veiculos);
  }
  public void RemoverVeiculo()
  {
    Console.WriteLine("");
    Console.WriteLine("Escreva a placa do veículo que você deseja tirar do estacionamento:");
    string placa = Console.ReadLine();
    while (!this.veiculos.Contains(placa))
    {
      Console.WriteLine("Nenhum veículo com essa placa está no estacionamento. Digite uma placa válida");
      placa = Console.ReadLine();
    }
    Console.WriteLine("Por quantas horas o veículo ficou estacionado?");
    int horas = Convert.ToInt32(Console.ReadLine());
    decimal preço = valorInicial + (valorPorHora * horas);
    Console.WriteLine($"O preço pelo tempo estacionado é R$ {preço}");
    this.veiculos.Remove(placa);
    Console.WriteLine("Veículo retirado do estacionamento. pressione qualquer tecla para continuar");
    Console.Read();
    this.utils.ComeçarPrograma(this.veiculos);
  }
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
    this.utils.ComeçarPrograma(this.veiculos);
  }
}
