internal class Program
{

    public static void GravaArquivo(string tipoPessoa, string pessoa)
    {
        using (StreamWriter arquivo = new StreamWriter($"./{tipoPessoa} - {pessoa}.txt", true))
        {
            // Console.WriteLine(arquivo.Count());
            arquivo.WriteLine($"Este arquivo é de uma pessoa do tipo {tipoPessoa} de nome {pessoa}");
        }
    }
    private static void Main(string[] args)
    {
        string pessoa;
        string pessoaTipo;
        string opcao;

        do
        {
            Console.WriteLine($"Qual tipo de pessoa quer cadastrar? PF ou PJ? Escreva 0 para sair");
            opcao = Console.ReadLine()!;

            if (opcao!.ToLower() == "pf" || opcao!.ToLower() == "pj")
            {
                pessoaTipo = opcao;
                Console.WriteLine($"Qual é o nome?");
                pessoa = Console.ReadLine()!;
                GravaArquivo(pessoaTipo!, pessoa!);

                Console.Write("Arquivo gravado com sucesso!");
                break;
            }
            else if (opcao != "0")
            {
                Console.WriteLine("Opção inválida");
            }

        } while (opcao != "0");
    }
}

