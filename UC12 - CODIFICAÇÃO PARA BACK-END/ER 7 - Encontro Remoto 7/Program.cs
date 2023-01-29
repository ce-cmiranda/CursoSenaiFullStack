using ER_7___Encontro_Remoto_7.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

// Cabeçalho do menu
Console.WriteLine(@$"
=============================================================
|           Bem vindo ao sistema de cadastro de             |         
|               pessoas físicas e jurídicas                 |
=============================================================
");

Utils.Loading("Iniciando o sistema", 500, 5, ConsoleColor.Yellow, ConsoleColor.White);
// Utils.Loading("Iniciando o sistema", 500);


// Desenho do menu

string? opcao;

do
{
    Console.WriteLine(@$"
=============================================================
|           Escolha uma das opções abaixo                   |         
|-----------------------------------------------------------|
|           1 - Pessoa Física                               |
|           2 - Pessoa Jurídica                             |
|                                                           |
|           0 - Sair                                        |
=============================================================
");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.Clear();
            Utils.MenuPf(listaPf);
            Utils.ParadaConsole("Aperte qualquer tecla e <Enter> para continuar");
            break;
        case "2":
            Console.Clear();
            Utils.MenuPj(listaPj);
            Utils.ParadaConsole("Aperte qualquer tecla e <Enter> para continuar");
            break;
        case "0":
            Console.Clear();
            // sair
            Utils.Loading("Obrigado por utilizar o sistema!", 300, 3, ConsoleColor.Yellow, ConsoleColor.White);
            break;
        default:
            Console.Clear();
            // opção inválida
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção inválida. Tenta novamente!");
            Console.ResetColor();
            break;

    }
}
while (opcao != "0");





