namespace DesafioFundamentosDIOConsole.Models;

public class Utils
{
  private decimal valorInicial = 0;
  private decimal valorPorHora = 0;

  public Utils(decimal valorInicial, decimal valorPorHora)
  {
    this.valorInicial = valorInicial;
    this.valorPorHora = valorPorHora;
  }

  public void ComeçarPrograma()
  {
    Estacionamento estacionamento = new Estacionamento(this.valorInicial, this.valorPorHora);

    Console.Clear();
    Console.WriteLine("");
    Console.WriteLine("Bem-Vindo ao Estacionamento!");
    Console.WriteLine("Digite um número:");
    Console.WriteLine("1. Cadastrar veículo");
    Console.WriteLine("2. Remover veículo");
    Console.WriteLine("3. Listar veículos");
    Console.WriteLine("4. Encerrar");
    string escolhaDoUsuario = Console.ReadLine();

    switch (escolhaDoUsuario)
    {
      case "1":
        estacionamento.CadastrarVeiculo();
        break;
      case "2":
        estacionamento.RemoverVeiculo();
        break;
      case "3":
        estacionamento.ListarVeiculos();
        break;
      case "4":
        Environment.Exit(0);
        break;
      default:
        ComeçarPrograma();
        break;
    }
  }
}
