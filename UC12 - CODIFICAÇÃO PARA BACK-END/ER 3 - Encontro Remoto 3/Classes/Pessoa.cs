using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_3___Encontro_Remoto_3.Interfaces;

namespace ER_3___Encontro_Remoto_3.Classes
{
    public class Pessoa: IPessoa
    {
        public string? Nome;
        public Endereco? Endereco;
        public float? Rendimento;

        public float PagarImporto(float redimento)
        {
            throw new NotImplementedException();
        }
    }
}