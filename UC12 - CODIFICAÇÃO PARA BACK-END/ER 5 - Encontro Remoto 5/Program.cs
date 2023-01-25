﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using ER_5___Encontro_Remoto_5.Classes;

PessoaFisica novaPessoa = new PessoaFisica();
Endereco enderecoPessoa = new Endereco();


enderecoPessoa.Logradouro = "Rua 1";
enderecoPessoa.Numero = 100;
enderecoPessoa.Comercial = false;


novaPessoa.Nome = "Carlos";
novaPessoa.Endereco = enderecoPessoa;
novaPessoa.Rendimento = 10000000;
novaPessoa.Cpf ="000.000.000-37";
novaPessoa.DataNascimento = "26/01/2015";



PessoaJuridica novaPessoa2 = new PessoaJuridica();
Endereco enderecoPessoa2 = new Endereco();

enderecoPessoa2.Logradouro = "Rua 2";
enderecoPessoa2.Numero = 200;
enderecoPessoa2.Comercial = true;
novaPessoa2.Cnpj ="00.000.000/0000-05";
// novaPessoa2.Cnpj ="00000000000005";
novaPessoa2.RazaoSocial ="Empresa 1 LTDA";



novaPessoa2.Nome = "Empresa 1";
novaPessoa2.Endereco = enderecoPessoa2;
novaPessoa2.Rendimento = 20000000;

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