using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_6___Encontro_Remoto_6.Interfaces;

namespace ER_6___Encontro_Remoto_6.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto();
    }
}