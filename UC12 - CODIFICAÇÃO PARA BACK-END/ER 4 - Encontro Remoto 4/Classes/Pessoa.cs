using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ER_4___Encontro_Remoto_4.Interfaces;

namespace ER_4___Encontro_Remoto_4.Classes
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