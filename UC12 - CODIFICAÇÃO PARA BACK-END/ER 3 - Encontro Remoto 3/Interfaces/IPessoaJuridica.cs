using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ER_3___Encontro_Remoto_3.Interfaces
{
    public interface IPessoaJuridica
    {
        public bool ValidarCnpj(string cnpj);
    }
}