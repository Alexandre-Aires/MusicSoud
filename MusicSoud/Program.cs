// See https://aka.ms/new-console-template for more information



string mensagemDeBoasVindas = " Boas Vindas ao Soud";
//List<string> listaDasBandas = new List<string>{"cout","digeos","gigere","viceres"};

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("beatles", new List<int>() );
void ExibirLogo()
{
     Console.WriteLine(@"
    ███╗   ███╗██╗   ██╗ ██████╗██╗ █████╗   ██████╗ █████╗ ██╗   ██╗██████╗ 
    ████╗ ████║██║   ██║██╔════╝██║██╔══██╗ ██╔════╝██╔══██╗██║   ██║██╔══██╗
    ██╔████╔██║██║   ██║╚█████╗ ██║██║  ╚═╝ ╚█████╗ ██║  ██║██║   ██║██║  ██║
    ██║╚██╔╝██║██║   ██║ ╚═══██╗██║██║  ██╗  ╚═══██╗██║  ██║██║   ██║██║  ██║
    ██║ ╚═╝ ██║╚██████╔╝██████╔╝██║╚█████╔╝ ██████╔╝╚█████╔╝╚██████╔╝██████╔╝
    ╚═╝     ╚═╝ ╚═════╝ ╚═════╝ ╚═╝ ╚════╝  ╚═════╝  ╚════╝  ╚═════╝ ╚═════╝ ");
}
                                                                                                            
void ExibirMenu()
{
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("\nDigite <1> para cadastrar uma banda");
    Console.WriteLine("Digitite <2> para ver as bandas");
    Console.WriteLine("Digite <3> para avaliar uma banda");
    Console.WriteLine("Digite <4> para exibir a médida de uma banda");
    Console.WriteLine("Digite <-1> para sair ");

    Console.Write("\nDigite sua opção:");
    string opcaoEscolhida = Console.ReadLine() !;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2: mostrarBandasR();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            exibirMedia();
            break;
        case -1:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }

}

void RegistrarBandas()
{
    Console.Clear();
    ExibirLogo();
    exibirTituloDaOpcao("Registros das banda");
    Console.WriteLine("digite o nome da banda que deseja registrar:");
    string nomeDaBanda = Console.ReadLine() !;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\na banda: {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear() ;
    ExibirMenu();

}
ExibirLogo();
void mostrarBandasR()
{
    Console.Clear();
    exibirTituloDaOpcao("Bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar\n");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
void AvaliarUmaBanda()
{
    Console.Clear();
    exibirTituloDaOpcao("avaliar banda");
    Console.WriteLine("Digite o nome da banda a ser avaliada");
    string nomeDaBanda = Console.ReadLine() !;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"qual nota a {nomeDaBanda} merece ?");
        int nota = int.Parse( Console.ReadLine() !);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine("nota registrada");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();

    } else

    {
        Console.WriteLine($" A banda {nomeDaBanda} não foi registrada");
        Console.WriteLine("\nDigite uma tecla para voltar\n");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}
void exibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}

ExibirMenu();

void exibirMedia()
{
    Console.Clear();
    exibirTituloDaOpcao("avaliar banda");
    Console.WriteLine("Digite o nome da banda que você deseja ver a média");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para retornar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
    else
    {

        Console.WriteLine($" A banda {nomeDaBanda} não foi registrada");
        Console.WriteLine("\nDigite uma tecla para voltar\n");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }
}