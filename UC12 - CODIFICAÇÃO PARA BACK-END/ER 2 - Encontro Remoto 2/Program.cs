// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ER_2___Encontro_Remoto_2.Classes;

PessoaFisica novaPessoa = new PessoaFisica();
Endereco enderecoPessoa = new Endereco();


enderecoPessoa.Logradouro = "Rua 1";
enderecoPessoa.Numero = 100;
enderecoPessoa.Comercial = false;


novaPessoa.Nome = "Carlos";
novaPessoa.Endereco = enderecoPessoa;
novaPessoa.Rendimento = 10000000;
novaPessoa.Cpf ="000.000.000-37";
novaPessoa.DataNascimento = "01/01/2000";


PessoaJuridica novaPessoa2 = new PessoaJuridica();
Endereco enderecoPessoa2 = new Endereco();

enderecoPessoa2.Logradouro = "Rua 2";
enderecoPessoa2.Numero = 200;
enderecoPessoa2.Comercial = true;
novaPessoa2.Cnpj ="00.000.000/0000-00";
novaPessoa2.RazaoSocial ="Empresa 1 LTDA";



novaPessoa2.Nome = "Empresa 1";
novaPessoa2.Endereco = enderecoPessoa2;
novaPessoa2.Rendimento = 20000000;

Console.WriteLine("**** Pessoa 1 ****");
Console.WriteLine(@$"
Nome: {novaPessoa.Nome}
Endereço: {novaPessoa.Endereco.Logradouro}, Número: {novaPessoa.Endereco.Numero} 
Rendimento: {novaPessoa.Rendimento}
CPF: {novaPessoa.Cpf}
Data de Nascimento: {novaPessoa.DataNascimento}
");

Console.WriteLine("**** Pessoa 2 ****");
Console.WriteLine(@$"
Nome: {novaPessoa2.Nome}
Endereço: {novaPessoa2.Endereco.Logradouro}, Número: {novaPessoa2.Endereco.Numero}
Rendimento: {novaPessoa2.Rendimento}
CNPJ: {novaPessoa2.Cnpj}
Razão Social: {novaPessoa2.RazaoSocial}
");