using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SA2___Atividade_Online_3.Interfaces;

namespace SA2___Atividade_Online_3.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float Rendimento;

        public abstract float PagarImposto();
    }
}