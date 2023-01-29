using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_7___Encontro_Remoto_7.Interfaces;

namespace ER_7___Encontro_Remoto_7.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto();
    }
}