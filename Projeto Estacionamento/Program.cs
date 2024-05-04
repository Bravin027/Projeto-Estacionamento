using System;
using Desafio;



Console.WriteLine("Seja bem-vindo ao sistema de estacionamento! \n"+
                            "Digite o preço inicial");
int precoInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Agora o preço por hora:");
int precoPorHora = int.Parse(Console.ReadLine());

//Instanciar a classe "estacionamento" com os valores obtidos
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while(exibirMenu) {
    Console.Clear();//Pra limpar quando uma opção for escolida
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine()) {
        case "1":
        es.AdicionarVeiculo();
        break;
        case "2":
        es.RemoverVeiculo();
        break;
        case "3":
        es.ListarVeiculo();
        break;
        case "4":
        exibirMenu = false;
        break;
        default :
        Console.WriteLine("Opção inválida!");
        break;
    }
    Console.WriteLine("Pressione uma tecla pra continuar");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou");