using System.ComponentModel.DataAnnotations;

namespace AtividadeOnline3.Models
{
    public class Projeto
    {
        [Key] public int ProjectId { get; set; }
        public string? Titulo { get; set; }
        public bool Ativo { get; set; }
        public int ManagerId { get; set; }

    }
}
