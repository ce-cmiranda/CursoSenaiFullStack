// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ER_6___Encontro_Remoto_6.Classes;



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
            // pessoa física
            // Instanciamento de Pessoa Física
            PessoaFisica novaPessoa = new PessoaFisica();
            Endereco enderecoPessoa = new Endereco();
            // Criação de Endereço
            enderecoPessoa.Logradouro = "Rua 1";
            enderecoPessoa.Numero = 100;
            enderecoPessoa.Comercial = false;


            novaPessoa.Nome = "Carlos";
            novaPessoa.Endereco = enderecoPessoa;
            novaPessoa.Rendimento = 10000000;
            novaPessoa.Cpf = "000.000.000-37";
            novaPessoa.DataNascimento = "26/01/2015";

            Console.WriteLine("**** Pessoa 1 ****");
            Console.WriteLine(@$"
Nome: {novaPessoa.Nome}
Endereço: {novaPessoa.Endereco.Logradouro}, Número: {novaPessoa.Endereco.Numero} 
Rendimento Bruto: {novaPessoa.Rendimento}
Rendimento Líquido: {novaPessoa.PagarImposto()}
CPF: {novaPessoa.Cpf}
Data de Nascimento: {novaPessoa.DataNascimento}
Maior de Idade: {novaPessoa.ValidarDataNascimento()}
");
            // Console.WriteLine("Aperte qualquer tecla e <Enter> para continuar");
            // menuBreak = Console.ReadLine();
            Utils.ParadaConsole("Aperte qualquer tecla e <Enter> para continuar");
            break;
        case "2":
            Console.Clear();
            // pessoa jurídica
            PessoaJuridica novaPessoa2 = new PessoaJuridica();
            Endereco enderecoPessoa2 = new Endereco();

            enderecoPessoa2.Logradouro = "Rua 2";
            enderecoPessoa2.Numero = 200;
            enderecoPessoa2.Comercial = true;
            novaPessoa2.Cnpj = "00.000.000/0000-05";
            // novaPessoa2.Cnpj ="00000000000005";
            novaPessoa2.RazaoSocial = "Empresa 1 LTDA";



            novaPessoa2.Nome = "Empresa 1";
            novaPessoa2.Endereco = enderecoPessoa2;
            novaPessoa2.Rendimento = 20000000;



            Console.WriteLine("**** Pessoa 2 ****");
            Console.WriteLine(@$"
Nome: {novaPessoa2.Nome}
Endereço: {novaPessoa2.Endereco.Logradouro}, Número: {novaPessoa2.Endereco.Numero}
Rendimento: {novaPessoa2.Rendimento}
Rendimento Líquido: {novaPessoa2.PagarImposto()}
CNPJ: {novaPessoa2.Cnpj}
Formato de CNPJ Válido: {novaPessoa2.ValidarCnpj()}
Razão Social: {novaPessoa2.RazaoSocial}
");

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

    // Console.Clear();
}
while (opcao != "0");





