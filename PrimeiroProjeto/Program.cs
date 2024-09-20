// Screen Sound
string msg = "Boas vindas ao Screen Sound";

void WelcomeMsg()
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("\nDigite 2 para mostrar todas as bandas");
    Console.WriteLine("\nDigite 3 para avaliar uma banda");
    Console.WriteLine("\nDigite 4 para exibir a média de uma banda");
    Console.WriteLine("\nDigite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string choosenOption = Console.ReadLine()!;
    int choosenNumber = int.Parse(choosenOption);
    
    switch(choosenNumber) {
        case 1: Console.WriteLine("Você escolheu a opção " + choosenNumber); 
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        case -1: Console.WriteLine("Você escolheu a opção " + choosenNumber);
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }

WelcomeMsg();
ShowMenuOptions();