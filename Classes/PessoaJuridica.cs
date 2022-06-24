using System.Text.RegularExpressions;
using CadastroPessoas.Interfaces;

namespace CadastroPessoas.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }

        public string? RazaoSocial { get; set; }


        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento / 100 * 3;

            }else if(rendimento <= 6000)
            {
                return rendimento / 100 * 6;

            }else if(rendimento <= 10000)
            {
                return rendimento / 100 * 10;
            }else
            {
                return rendimento /100 * 12;
            }
        }


        //XX.XXX.XXX/0001-XX ----- XXXXXXXX0001XX
        public bool ValidarCnpj(string cnpj)
        {
            bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\{4}-\d{2})|(\d{14})$)");

            //if (Regex.IsMatch(cnpj,  @"(^(\d{2}.\d{3}.\d{3}/\{4}-\d{2})|(\d{14})$)"))
            if (retornoCnpjValido == true)
            {
                if (cnpj.Length == 18)
                {
                    string subStringCnpj = cnpj.Substring(11, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }

                }
                else if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                        return true;
                    }

                }
            }
            return false;



        }
    }
}