using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_2___Encontro_Remoto_2.Interfaces;

namespace ER_2___Encontro_Remoto_2.Classes
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