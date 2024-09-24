// Screen Sound
string msg = "Boas vindas ao Screen Sound";
List<string> bandList = new List<string> { "BABYMETAL", "FUGAZI" };

void showLogo()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(msg);
}

void ShowMenuOptions()
{
    showLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("\nDigite 2 para mostrar todas as bandas");
    Console.WriteLine("\nDigite 3 para avaliar uma banda");
    Console.WriteLine("\nDigite 4 para exibir a média de uma banda");
    Console.WriteLine("\nDigite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string choosenOption = Console.ReadLine()!;
    int choosenNumber = int.Parse(choosenOption);

    switch (choosenNumber)
    {
        case 1:
            BandRegister();
            break;
        case 2:
            showRegisteredBands();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void BandRegister()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string bandName = Console.ReadLine()!;
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso\n");
    bandList.Add(bandName);
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void showRegisteredBands()
{
    Console.Clear();
    Console.WriteLine("Exibindo bandas registradas\n");

    foreach (string band in bandList)
    {
        Console.WriteLine($"Banda: {band}");
    }
    Console.WriteLine("\nDigite algo para voltar ao menu principal\n");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

ShowMenuOptions();