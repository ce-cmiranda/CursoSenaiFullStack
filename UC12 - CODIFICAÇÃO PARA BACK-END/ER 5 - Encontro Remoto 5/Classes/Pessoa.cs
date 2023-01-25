using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_5___Encontro_Remoto_5.Interfaces;

namespace ER_5___Encontro_Remoto_5.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto();
    }
}