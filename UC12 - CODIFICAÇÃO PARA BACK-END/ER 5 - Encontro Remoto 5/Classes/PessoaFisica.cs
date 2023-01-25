using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_5___Encontro_Remoto_5.Interfaces;

namespace ER_5___Encontro_Remoto_5.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
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
                yearDif = dataAtual.Day < dataNascimentoConvertida.Day ? yearDif - 1 : yearDif;
            }
            else if (dataAtual.Month == dataNascimentoConvertida.Month)
            {
                yearDif = yearDif--;
            }


            // Console.WriteLine(yearDif);

            if (yearDif >= 18)
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
            if (rendimento <= 1500)
            {
                return rendimento;
            }
            else if (rendimento <= 5000)
            {
                return (rendimento - (rendimento / 100) * 3);
            }
            else
            {
                return (rendimento - (rendimento / 100) * 5);
            }
        }
    }

}