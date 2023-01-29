using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_7___Encontro_Remoto_7.Classes;

namespace ER_7___Encontro_Remoto_7.Classes
{
    public static class Utils
    {
        public static void ParadaConsole(string texto)
        {
            Console.WriteLine(texto);
            Console.ReadLine();
        }

        public static void Loading(string texto, int tempo, int qntPontos, ConsoleColor corFundo = ConsoleColor.Black, ConsoleColor corFonte = ConsoleColor.White)
        {
            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corFonte;
            Console.Write(texto);


            for (int i = 1; i <= qntPontos; i++)
            {
                Console.Write($".");
                Thread.Sleep(tempo);
            }

            Console.ResetColor();
            Console.WriteLine("");
        }

        public static void MenuPf(List<PessoaFisica> listaPf)
        {
            string? opcaoPf;
            // LAÇO DO SUB-MENU
            do
            {
                // SUB-MENU PARA PESSOA FÍSICA
                Console.WriteLine(@$"
                ======================================================
                |          Escolha uma das opções abaixo             |
                | ---------------------------------------------------|
                |            1 - Cadastrar Pessoa Física             |
                |            2 - Listar Pessoa Física                |
                |                                                    |
                |            0 - Voltar ao menu anterior             |
                ======================================================
                ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();
                        // INSTANCIA PF
                        PessoaFisica novaPessoa = new PessoaFisica();
                        Endereco enderecoPessoa = new Endereco();

                        // COLETA DADOS PF
                        Console.WriteLine($"Digite o nome da pessoa física: ");
                        novaPessoa.Nome = Console.ReadLine();
                        Console.WriteLine($"Digite o CPF da pessoa física: ");
                        novaPessoa.Cpf = Console.ReadLine();
                        Console.WriteLine($"Digite a Data de Nascimento da pessoa física: (ex: dd/mm/aaaa) ");
                        novaPessoa.DataNascimento = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da pessoa física: ");
                        novaPessoa.Rendimento = float.Parse(Console.ReadLine()!);

                        // ENDERECO PF
                        Console.WriteLine($"Digite o Logradouro: ");
                        enderecoPessoa.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número: ");
                        enderecoPessoa.Numero = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"O endereço é comercial? S/N ");
                        string? endComercial = Console.ReadLine();

                        if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                        {
                            enderecoPessoa.Comercial = true;
                        }
                        else
                        {
                            enderecoPessoa.Comercial = false;
                        }

                        novaPessoa.Endereco = enderecoPessoa;
                        // ADICIONA NA LISTA
                        listaPf.Add(novaPessoa);
                        Console.WriteLine("Pessoa cadastrada com sucesso!");
                        break;

                    case "2":
                        // LISTA PF
                        Console.WriteLine($"******** Início da Lista de Pessoas Físicas********");
                        foreach (var pessoa in listaPf)
                        {
                            Console.WriteLine(@$"
                                Nome: {pessoa.Nome}
                                Endereço: {pessoa.Endereco!.Logradouro}, Número: {pessoa.Endereco.Numero} 
                                Rendimento Bruto: {pessoa.Rendimento}
                                Rendimento Líquido: {pessoa.PagarImposto()}
                                CPF: {pessoa.Cpf}
                                Data de Nascimento: {pessoa.DataNascimento}
                                Maior de Idade: {pessoa.ValidarDataNascimento()}
                                ");
                        }

                        Console.WriteLine($"******** Fim da Lista de Pessoas Físicas********");
                        Utils.ParadaConsole("Aperte qualquer tecla e <Enter> para continuar");
                        break;
                    case "0":
                        Loading("Retornando ao Menu Principal!", 300, 3, ConsoleColor.Yellow, ConsoleColor.White);
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
            while (opcaoPf != "0");
        }

        public static void MenuPj(List<PessoaJuridica> listaPj)
        {
            string? opcaoPj;
            // LAÇO DO SUB-MENU
            do
            {
                // SUB-MENU PARA PESSOA JURÍDICA
                Console.WriteLine(@$"
                ======================================================
                |          Escolha uma das opções abaixo             |
                | ---------------------------------------------------|
                |            1 - Cadastrar Pessoa Jurídica           |
                |            2 - Listar Pessoa Jurídica              |
                |                                                    |
                |            0 - Voltar ao menu anterior             |
                ======================================================
                ");
                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":
                        Console.Clear();
                        // INSTANCIA Pj
                        PessoaJuridica novaPessoaJuridica = new PessoaJuridica();
                        Endereco enderecoPessoaJuridica = new Endereco();

                        // COLETA DADOS PJ
                        Console.WriteLine($"Digite a Razão Social da pessoa jurídica: ");
                        novaPessoaJuridica.RazaoSocial = Console.ReadLine();
                        Console.WriteLine($"Digite o CNPJ da pessoa jurídica: ");
                        novaPessoaJuridica.Cnpj = Console.ReadLine();
                        Console.WriteLine($"Digite o nome do Representante da pessoa jurídica: ");
                        novaPessoaJuridica.Nome = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da pessoa jurídica: ");
                        novaPessoaJuridica.Rendimento = float.Parse(Console.ReadLine()!);

                        // ENDERECO PJ
                        Console.WriteLine($"Digite o Logradouro: ");
                        enderecoPessoaJuridica.Logradouro = Console.ReadLine();
                        Console.WriteLine($"Digite o número: ");
                        enderecoPessoaJuridica.Numero = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"O endereço é comercial? S/N ");
                        string? endComercial = Console.ReadLine();

                        if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                        {
                            enderecoPessoaJuridica.Comercial = true;
                        }
                        else
                        {
                            enderecoPessoaJuridica.Comercial = false;
                        }

                        novaPessoaJuridica.Endereco = enderecoPessoaJuridica;
                        // ADICIONA NA LISTA
                        listaPj.Add(novaPessoaJuridica);
                        // listaPf.Count;
                        Console.WriteLine("Pessoa cadastrada com sucesso!");
                        break;
                    case "2":
                        // LISTA PJ
                        Console.WriteLine($"******** Início da Lista de Pessoas Jurídicas********");
                        foreach (var pessoa in listaPj)
                        {
                            Console.WriteLine(@$"
                                Representante: {pessoa.Nome}
                                Endereço: {pessoa.Endereco!.Logradouro}, Número: {pessoa.Endereco!.Numero}
                                Rendimento: {pessoa.Rendimento}
                                Rendimento Líquido: {pessoa.PagarImposto()}
                                CNPJ: {pessoa.Cnpj}
                                Formato de CNPJ Válido: {pessoa.ValidarCnpj()}
                                Razão Social: {pessoa.RazaoSocial}
                                ");

                        }

                        Console.WriteLine($"******** Fim da Lista de Pessoas Jurídicas********");
                        Utils.ParadaConsole("Aperte qualquer tecla e <Enter> para continuar");
                        break;
                    case "0":
                        Loading("Retornando ao Menu Principal!", 300, 3, ConsoleColor.Yellow, ConsoleColor.White);
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
            while (opcaoPj != "0");
        }
    }
}