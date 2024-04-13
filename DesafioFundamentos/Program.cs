using DesafioFundamentos.Models;


Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite o preço inicial");
string precoInicial = Console.ReadLine();
Console.WriteLine("Digite o preço por hora");
string precoPorHora = Console.ReadLine();

Estacionamento estacionamento = new Estacionamento(Convert.ToDecimal(precoInicial), Convert.ToDecimal(precoPorHora));

    string opcao = string.Empty;

    bool repeticao = true;

    while (repeticao)

    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção: \n 1 - Cadastrar veículo \n 2 - Remover veículo \n 3 - Listar veículos \n 4 - Encerrar");

        opcao = Console.ReadLine();

        switch(opcao)
        {
            case "1":
            estacionamento.AdicionarVeiculo();
            break;
            case "2":
            estacionamento.RemoverVeiculo();
            break;
            case "3":
            estacionamento.ListarVeiculos();
            break;
            case "4":
            repeticao = false;
            break;
            default:
            Console.WriteLine("Opção inválida");
            break;
        }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

    }

    


