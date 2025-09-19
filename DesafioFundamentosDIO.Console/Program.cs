using DesafioFundamentosDIOConsole.Models;

Console.Clear();
Console.WriteLine("Bem-Vindo ao Estacionamento!");
Console.WriteLine("Digite o valor inicial cobrado por estacionar:");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor cobrado por hora de estacionamento:");
decimal valorPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionamento = new Estacionamento(valorInicial, valorPorHora);
bool rodando = true;

while (rodando)
{ 
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
        rodando = false;
        break;
      default:
        break;
    }
}
;