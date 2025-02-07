using estacionamento.Models;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;


Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

decimal precoInicial;
while (true)
{
    Console.Write("Digite o preço inicial: ");
    if (decimal.TryParse(Console.ReadLine(), out precoInicial) && precoInicial >= 0)
        break;
    Console.WriteLine("Valor inválido. Digite um número válido.");
}

decimal precoPorHora;
while (true)
{
    Console.Write("Agora digite o preço por hora: ");
    if (decimal.TryParse(Console.ReadLine(), out precoPorHora) && precoPorHora >= 0)
        break;
    Console.WriteLine("Valor inválido. Digite um número válido.");
}

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Opções ===");
    Console.WriteLine("1 - Adicionar Veículo");
    Console.WriteLine("2 - Listar Veículos");
    Console.WriteLine("3 - Remover Veículo");
    Console.WriteLine("4 - Sair do Programa");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.ListarVeiculos();
            break;

        case "3":
            es.ExcluirVeiculo();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("Encerrando o programa...");
            break;

        default:
            Console.WriteLine("Opção inválida! Digite uma opção válida.");
            break;
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}
