using System.Text.RegularExpressions;
using CadastroPessoas.Classes;

Console.Clear();
Console.WriteLine(@$"
============================================
|   Bem vindo ao sistemas de cadastro de   |
|        Pessoas Fisícas e Juridícas       |
============================================
");

BarraCarregamento("Iniciando", 1000, 30);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

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
            string? opcaoPf;
            do
            {

                Console.Clear();
                Console.WriteLine(@$"
============================================
|        Escolha uma opção abaixo          |
|------------------------------------------|
|         1 - Cadastrar Pessoa Fisíca      |
|         2 - Listar Pessoa Fisíca         |
|                                          |
|         0 - Voltar ao menu anterior      |
============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();
                switch (opcaoPf)
                {
                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica que deseja cadastrar");
                        novaPf.Name = Console.ReadLine();

                        // PARA COMENTAR, SELECIONA O TEXTO E APERTA CTRL + ;
                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento Ex:DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime DataConvertida;
                        //         DateTime.TryParse(dataNascimento, out DataConvertida);
                        //         novaPf.dataNasc = DataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Data digitada invalida, por favor digite uma data valida");
                        //         Console.ResetColor();
                        //         Thread.Sleep(2000);
                        //     }
                        // } while (dataValida == false);

                        // Console.WriteLine($"Digite o numero do CPF");
                        // novaPf.Cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o rendimento mensal(DIGITR SOMENTE NUMEROS)");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o complemento");
                        // novoEndPf.complemento = Console.ReadLine();

                        // Console.WriteLine($"Este endereco é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPf.Endereco = novoEndPf;

                        // listaPf.Add(novaPf);


                        //StreamWriter sw = new StreamWriter($"{novaPf.Name}.txt");
                        //sw.WriteLine(novaPf.Name);
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Name}.txt"))
                        {
                            sw.WriteLine(novaPf.Name);
                        }


                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(2000);

                        break;
                    case "2":
                        Console.Clear();

                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Name}
                        // Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero}
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}
                        // ");
                        //                                 Console.WriteLine("Aperte ENTER para continuar");
                        //                                 Console.ReadLine();

                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista vazia");
                        //                             Thread.Sleep(2000);
                        //                         }

                        //using (StreamReader sr = new StreamReader())
                        //{

                        //}

                        using (StreamReader sr = new StreamReader("Felipe Augusto da Silva.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Aperte ENTER para continuar!");
                        Console.ReadLine();
                        Console.ResetColor();



                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Invalida, por favor digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(5000);

                        break;
                }

            } while (opcaoPf != "0");


            // Console.WriteLine(metodosPf.ValidarDataNasc(novaPf.dataNasc));
            // Console.WriteLine(novaPf.Name);
            //Console.WriteLine($"Nome: {novaPf.Name} Nome: {novaPf.Name}");
            //Console.WriteLine("Nome: " + novaPf.Name + " Nome:" + novaPf.Name);

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Aperte ENTER para continuar!");
            //Console.ReadLine();
            //Console.ResetColor();

            break;

        case "2":

            string? opcaoPj;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
============================================
|        Escolha uma opção abaixo          |
|------------------------------------------|
|       1 - Cadastrar Pessoa Juridica      |
|       2 - Listar Pessoa Juridica         |
|                                          |
|         0 - Voltar ao menu anterior      |
============================================
");
                opcaoPj = Console.ReadLine();
                PessoaJuridica metodosPj = new PessoaJuridica();
                switch (opcaoPj)
                {
                    case "1":
                        PessoaJuridica novaPj = new PessoaJuridica();
                        Endereco novoEndPj = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa juridica que deseja cadastrar");
                        novaPj.Name = Console.ReadLine();

                        Console.WriteLine($"Digite a razão social");
                        novaPj.RazaoSocial = Console.ReadLine();

                        //Console.WriteLine($"Digite o numero do CNPJ(APENAS NUMEROS)");
                        bool cnpjValido;
                        do
                        {
                            Console.WriteLine($"Digite o CNPJ (APENAS NÚMEROS)");
                            string? CnpjV = Console.ReadLine();

                            cnpjValido = metodosPj.ValidarCnpj(CnpjV);

                            if (cnpjValido)
                            {
                                novaPj.Cnpj = CnpjV;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"CNPJ inválido. Por favor, digite um CNPJ válido");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                            }
                        } while (cnpjValido == false);

                        novaPj.Cnpj = Console.ReadLine();



                        Console.WriteLine($"Digite o rendimento mensal(APENAS NUMEROS)");
                        novaPj.Rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPj.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero");
                        novoEndPj.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Complemento");
                        novoEndPj.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereco é comercial? S/N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPj.endComercial = true;
                        }
                        else
                        {
                            novoEndPj.endComercial = false;
                        }

                        novaPj.Endereco = novoEndPj;

                        metodosPj.Inserir(novaPj);

                        //List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();
                        //foreach (PessoaJuridica cadaItem in ListaPj)
                        //{
                            
                        //}



                        listaPj.Add(novaPj);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                    case "2":
                        Console.Clear();

                        

                        if (listaPj.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPessoaJ in listaPj)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
Nome: {cadaPessoaJ.Name}
Razão Social: {cadaPessoaJ.RazaoSocial}
CNPJ: {cadaPessoaJ.Cnpj}
Endereço: {cadaPessoaJ.Endereco.logradouro}, N: {cadaPessoaJ.Endereco.numero}
Complemento: {cadaPessoaJ.Endereco.complemento}
");

                                Console.WriteLine("Aperte 'ENTER' para continuar");
                                Console.ReadLine();

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(2000);
                        }

                        

                        break;
                    case "0":

                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Invalida, por favor digite uma opção válida!");
                        Console.ResetColor();
                        Thread.Sleep(5000);
                        break;
                }


            } while (opcaoPj != "0");

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine($"Aperte ENTER para continuar!");
            //Console.ReadLine();
            //Console.ResetColor();

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