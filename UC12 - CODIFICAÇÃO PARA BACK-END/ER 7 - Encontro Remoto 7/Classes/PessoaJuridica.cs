using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_7___Encontro_Remoto_7.Interfaces;
using System.Text.RegularExpressions;

namespace ER_7___Encontro_Remoto_7.Classes
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public bool ValidarCnpj()
        {
            Console.WriteLine(Cnpj);
            if (Regex.IsMatch(Cnpj!, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$)|^(\d{14}$))"))
            // if (Regex.IsMatch(Cnpj!, @"/^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$/"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override float PagarImposto()
        {
            float rendimento = Rendimento;
            if (rendimento <= 5000)
            {
                return (rendimento - (rendimento / 100) * 6);
            }
            else if (rendimento <= 10000)
            {
                return (rendimento - (rendimento / 100) * 8);
            }
            else
            {
                return (rendimento - (rendimento / 100) * 10);
            }
        }
    }

}