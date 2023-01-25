using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_2___Encontro_Remoto_2.Interfaces;


namespace ER_2___Encontro_Remoto_2.Classes
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica
    {
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }

}