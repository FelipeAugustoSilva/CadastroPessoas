
using CadastroPessoas.Classes;

// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Name = "Felipe";
// novaPf.dataNasc = new DateTime (2000, 01, 01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5f;

// novoEndPf.logradouro = "Alameda barao de limeira";
// novoEndPf.numero = 539;
// novoEndPf.complemento = "Senai Informatica";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;


// Console.WriteLine(@$"
// Nome: {novaPf.Name}
// Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
// ");


//Console.WriteLine(metodosPf.ValidarDataNasc(novaPf.dataNasc));
//Console.WriteLine(novaPf.Name);
//Console.WriteLine($"Nome: {novaPf.Name} Nome: {novaPf.Name}");
//Console.WriteLine("Nome: " + novaPf.Name + " Nome:" + novaPf.Name);


PessoaJuridica novaPj = new PessoaJuridica();
PessoaJuridica metodosPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.Name = "Nome Pj";
novaPj.RazaoSocial = "Razão Social Pj";
novaPj.Cnpj = "00000000000100";
novaPj.Rendimento = 10000.5f;

novoEndPj.logradouro = "alameda barão de limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica";
novoEndPj.endComercial = true;

novaPj.Endereco = novoEndPj;

//Console.WriteLine(metodosPj.ValidarCnpj(novaPj.Cnpj));
Console.WriteLine(@$"
Nome: {novaPj.Name}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Valido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, N: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

