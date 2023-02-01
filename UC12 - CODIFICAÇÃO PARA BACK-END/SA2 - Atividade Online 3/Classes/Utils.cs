using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SA2___Atividade_Online_3.Classes;

namespace SA2___Atividade_Online_3.Classes
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
                        //ADICIONA NO ARQUIVO TXT DE PESSOAS FÍSICAS

                        using (StreamWriter arquivoPf = new StreamWriter("./PessoaFisica.txt", true))
                        {
                            arquivoPf.WriteLine($"{novaPessoa.Nome}$%{novaPessoa.Cpf}$%{novaPessoa.DataNascimento}$%{novaPessoa.Rendimento}$%{novaPessoa.Endereco.Logradouro}$%{novaPessoa.Endereco.Numero}$%{novaPessoa.Endereco.Comercial}");
                        }
                        Console.WriteLine("Pessoa cadastrada com sucesso!");
                        break;

                    case "2":
                        // LISTA PF
                        // Console.WriteLine(File.ReadLines("./PessoaFisica.txt").Count());
                        Console.WriteLine($"******** Início da Lista de Pessoas Físicas********");
                        //LE OS DADOS NO ARQUIVO TXT DE PESSOAS FÍSICAS
                        using (StreamReader arquivoPf = new StreamReader("./PessoaFisica.txt"))
                        {
                            string? linhaPessoa;
                            while ((linhaPessoa = arquivoPf.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split("$%");
                                // INSTANCIA PF
                                PessoaFisica pessoa = new PessoaFisica();
                                Endereco pessoaEndereco = new Endereco();

                                pessoa.Nome = dadosPessoa[0];
                                pessoa.Cpf = dadosPessoa[1];
                                pessoa.DataNascimento = dadosPessoa[2];
                                pessoa.Rendimento = float.Parse(dadosPessoa[3]!);

                                // ENDERECO PF
                                pessoaEndereco.Logradouro = dadosPessoa[4];
                                pessoaEndereco.Numero = int.Parse(dadosPessoa[5]!);
                                endComercial = dadosPessoa[6];
                                if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                                {
                                    pessoaEndereco.Comercial = true;
                                }
                                else
                                {
                                    pessoaEndereco.Comercial = false;
                                }

                                pessoa.Endereco = pessoaEndereco;

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
                        using (StreamWriter arquivoPj = new StreamWriter("./PessoaJuridica.txt", true))
                        {
                            arquivoPj.WriteLine($"{novaPessoaJuridica.RazaoSocial}$%{novaPessoaJuridica.Nome}$%{novaPessoaJuridica.Cnpj}$%{novaPessoaJuridica.Rendimento}$%{novaPessoaJuridica.Endereco.Logradouro}$%{novaPessoaJuridica.Endereco.Numero}$%{novaPessoaJuridica.Endereco.Comercial}");
                        }
                        Console.WriteLine("Pessoa cadastrada com sucesso!");
                        break;
                    case "2":
                        // LISTA PJ
                        Console.WriteLine($"******** Início da Lista de Pessoas Jurídicas********");

                        using (StreamReader arquivoPj = new StreamReader("./PessoaJuridica.txt"))
                        {
                            string? linhaPessoa;
                            while ((linhaPessoa = arquivoPj.ReadLine()) != null)
                            {
                                string[] dadosPessoa = linhaPessoa.Split("$%");
                                PessoaJuridica pessoa = new PessoaJuridica();
                                Endereco endereco = new Endereco();

                                pessoa.RazaoSocial = dadosPessoa[0];
                                pessoa.Nome = dadosPessoa[1];
                                pessoa.Cnpj = dadosPessoa[2];
                                pessoa.Rendimento = float.Parse(dadosPessoa[3]!);

                                // ENDERECO PJ
                                endereco.Logradouro = dadosPessoa[4];
                                endereco.Numero = int.Parse(dadosPessoa[5]!);
                                endComercial = dadosPessoa[6];

                                if (endComercial == "S" || endComercial == "s" || endComercial == "sim")
                                {
                                    endereco.Comercial = true;
                                }
                                else
                                {
                                    endereco.Comercial = false;
                                }

                                pessoa.Endereco = endereco;


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