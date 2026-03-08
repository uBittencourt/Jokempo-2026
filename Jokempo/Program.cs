// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary<string, (int vitorias, int empates, int derrotas)> jogadores = new Dictionary<string, (int, int, int)>();

Console.WriteLine("😀 Olá! Vamos jogar Jokempo?");
Console.WriteLine("[1] - Sim \n[0] - Não");
Console.Write("Resposta: ");

var continuar = ValidarEntrada("opcao");
while (continuar != '0')
{
    var nomeJogador = ValidarNomeJogador();
    if (!jogadores.ContainsKey(nomeJogador))
        jogadores[nomeJogador] = (0, 0, 0);

    Console.WriteLine($"\nEntão vamos começar os jogos {nomeJogador}...");

    do
    {
        var jogada = ObterJogada();
        var opcaoPC = new Random().Next(3);
        bool vitoria = RealizarRodada(jogada, opcaoPC);
        AtualizarEstatistica(jogada, opcaoPC, vitoria, nomeJogador);

        continuar = JogarNovamente();
        Console.WriteLine();
    } while (continuar == '1');

    Console.WriteLine("\nComo deseja continuar?");
    Console.WriteLine("[1] - Jogar com outro jogador \n[2] - Ver estatísticas \n[0] - Sair");
    Console.Write("Resposta: ");
    continuar = ValidarEntrada("menu");
    Console.WriteLine();

    if (continuar == '2')
    {
        MostrarEstatisticas();
        continuar = JogarNovamente();
    }
}
Console.WriteLine("\n👋 Tchau! Até a próxima");

char ValidarEntrada(String modo = "opcao")
{
    char entrada = Console.ReadKey().KeyChar;
    if (modo == "opcao")
        while (entrada != '0' && entrada != '1')
        {
            Console.WriteLine("\nOpção inválida. Por favor, escolha entre 0 ou 1!");
            Console.Write("Resposta: ");
            entrada = Console.ReadKey().KeyChar;
        }
    else if (modo == "jogada")
        while (entrada != '0' && entrada != '1' && entrada != '2')
        {
            Console.WriteLine("\nJogada inválida. Por favor, escolha entre 0, 1 ou 2!");
            Console.Write("Resposta: ");
            entrada = Console.ReadKey().KeyChar;
        }
    else if (modo == "menu")
        while (entrada != '0' && entrada != '1' && entrada != '2')
        {
            Console.WriteLine("\nOpção inválida. Por favor, escolha entre 0, 1 ou 2!");
            Console.Write("Resposta: ");
            entrada = Console.ReadKey().KeyChar;
        }
    return entrada;
}

String ValidarNomeJogador()
{
    Console.Write("\nDigite seu nome: ");
    String nome = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Nome inválido. Por favor, digite um nome válido!");
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
    }
    return nome;
}

char ObterJogada()
{
    Console.WriteLine("\nQual será sua jogada?");
    Console.WriteLine("[0] - Pedra ✊ \n[1] - Papel ✋ \n[2] - Tesoura ✌");
    Console.Write("Resposta: ");
    return ValidarEntrada("jogada");
}

bool RealizarRodada(char jogada, int opcaoPC)
{
    bool vitoria = false;
    switch (jogada)
    {
        case '0':
            Console.WriteLine("\nVocê escoheu Pedra ✊!");
            vitoria = (opcaoPC == 2);
            break;
        case '1':
            Console.WriteLine("\nVocê escoheu Papel ✋");
            vitoria = (opcaoPC == 0);
            break;
        case '2':
            Console.WriteLine("\nVocê escoheu Tesoura ✌");
            vitoria = (opcaoPC == 1);
            break;
    }

    switch (opcaoPC)
    {
        case 0:
            Console.WriteLine("\nEu escolhi Pedra ✊!");
            break;
        case 1:
            Console.WriteLine("\nEu escolhi Papel ✋");
            break;
        case 2:
            Console.WriteLine("\nEu escolhi Tesoura ✌");
            break;
    }

    if (int.Parse(jogada.ToString()) == opcaoPC)
        Console.WriteLine("\n😀 Legal! Nós empatamos!");
    else if (vitoria)
        Console.WriteLine("\n😀 Parabéns! Você venceu.");
    else
        Console.WriteLine("\n😀 Haha, eu venci! Não foi dessa vez. Você pode ter mais sorte na próxima.");
    return vitoria;
}

void AtualizarEstatistica(char jogada, int opcaoPC, bool vitoria, string nomeJogador)
{
    if (int.Parse(jogada.ToString()) == opcaoPC)
        jogadores[nomeJogador] = (jogadores[nomeJogador].vitorias, jogadores[nomeJogador].empates + 1, jogadores[nomeJogador].derrotas);
    else if (vitoria)
        jogadores[nomeJogador] = (jogadores[nomeJogador].vitorias + 1, jogadores[nomeJogador].empates, jogadores[nomeJogador].derrotas);
    else
        jogadores[nomeJogador] = (jogadores[nomeJogador].vitorias, jogadores[nomeJogador].empates, jogadores[nomeJogador].derrotas + 1);
}

void MostrarEstatisticas()
{
    Console.WriteLine("\n📊 Estatísticas dos jogadores:");
    foreach (var jogador in jogadores)
    {
        Console.WriteLine($"{jogador.Key}: {jogador.Value.vitorias} vitórias, {jogador.Value.empates} empates, {jogador.Value.derrotas} derrotas");
    }
}

char JogarNovamente()
{
    Console.WriteLine("\nQuer jogar de novo?");
    Console.WriteLine("[1] - Sim \n[0] - Não");
    Console.Write("Resposta: ");
    return ValidarEntrada("opcao");
}