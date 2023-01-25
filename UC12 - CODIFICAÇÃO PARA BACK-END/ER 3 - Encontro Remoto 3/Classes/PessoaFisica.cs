using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_3___Encontro_Remoto_3.Interfaces;

namespace ER_3___Encontro_Remoto_3.Classes
{
    public class PessoaFisica: Pessoa,IPessoaFisica
    {
        public string? Cpf { get; set; }
        public string? DataNascimento { get; set; }

        public bool ValidarDataNascimento()
        {
            DateTime dataAtual = DateTime.Today;
            DateTime dataNascimentoConvertida;
            DateTime.TryParse(DataNascimento, out dataNascimentoConvertida);
            int yearDif = dataAtual.Year - dataNascimentoConvertida.Year;

            if (dataAtual.Month == dataNascimentoConvertida.Month)
            {
                yearDif = dataAtual.Day < dataNascimentoConvertida.Day ? yearDif-1:yearDif;
            }
            else if(dataAtual.Month == dataNascimentoConvertida.Month)
            {
                yearDif = yearDif--;
            }

            
            // Console.WriteLine(yearDif);

            if(yearDif >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
    
}