using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_2___Encontro_Remoto_2.Interfaces;

namespace ER_2___Encontro_Remoto_2.Classes
{
    public class PessoaFisica: Pessoa,IPessoaFisica
    {
        public string? Cpf { get; set; }
        public string? DataNascimento { get; set; }

        public bool ValidarDataNascimento(string DataNascimento)
        {
            throw new NotImplementedException();
        }
    }
    
}