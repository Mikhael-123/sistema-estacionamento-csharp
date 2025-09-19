using DesafioFundamentosDIOConsole.Models;

Console.WriteLine("Bem-Vindo ao Estacionamento!");
Console.WriteLine("Digite o valor inicial cobrado por estacionar:");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor cobrado por hora de estacionamento:");
decimal valorPorHora = Convert.ToDecimal(Console.ReadLine());

List<string> listaVazia = new List<string>();
Utils utils = new Utils(valorInicial, valorPorHora);
utils.ComeçarPrograma(listaVazia);