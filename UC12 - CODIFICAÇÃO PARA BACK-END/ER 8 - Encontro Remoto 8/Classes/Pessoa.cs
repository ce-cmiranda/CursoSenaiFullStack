using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_8___Encontro_Remoto_8.Interfaces;

namespace ER_8___Encontro_Remoto_8.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto();
    }
}