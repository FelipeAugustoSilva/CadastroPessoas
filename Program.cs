using CadastroPessoas.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|   Bem vindo ao sistemas de cadastro de   |
|        Pessoas Fisícas e Juridícas       |
============================================
");

BarraCarregamento("Iniciando", 1000, 30);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|        Escolha uma opção abaixo          |
|------------------------------------------|
|         1 - Pessoa Fisíca                |
|         2 - Pessoa Juridíca              |
|                                          |
|         0 - Sair                         |
============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Name = "Felipe";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.logradouro = "Alameda barao de limeira";
            novoEndPf.numero = 539;
            novoEndPf.complemento = "Senai Informatica";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Name}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {(metodosPf.ValidarDataNasc(novaPf.dataNasc) ? "Sim" : "Não")}
Imposto a ser pago: {metodosPf.PagarImposto(novaPf.Rendimento).ToString("C")}
");
            // Console.WriteLine(metodosPf.ValidarDataNasc(novaPf.dataNasc));
            // Console.WriteLine(novaPf.Name);
            //Console.WriteLine($"Nome: {novaPf.Name} Nome: {novaPf.Name}");
            //Console.WriteLine("Nome: " + novaPf.Name + " Nome:" + novaPf.Name);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aperte ENTER para continuar!");
            Console.ReadLine();
            Console.ResetColor();

            break;

        case "2":
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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Name}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Valido: {(metodosPj.ValidarCnpj(novaPj.Cnpj) ? "Sim" : "Não")}
Endereço: {novaPj.Endereco.logradouro}, N: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Aperte ENTER para continuar!");
            Console.ReadLine();
            Console.ResetColor();

            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!!!");
            Thread.Sleep(5000);

            BarraCarregamento("Finalizando", 1000, 30);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Invalida, por favor digite uma opção válida!");
            Console.ResetColor();
            Thread.Sleep(5000);
            break;
    }


} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo, int quantidade)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write(texto);
    for (var Contador = 0; Contador < quantidade; Contador++)
    {
        Console.Write(".");
        Thread.Sleep(100);
    }
    Console.ResetColor();

}