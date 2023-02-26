using AtividadeOnline3.Models;
using Microsoft.EntityFrameworkCore;

namespace AtividadeOnline3.Contexts
{
    public class SQLcontext : DbContext
    {
        // dbcontext é a ponte entre o modelo de classe e o banco de
        //     dados
        public SQLcontext()
        {
        }
        public SQLcontext(DbContextOptions<SQLcontext>
        options)
        : base(options)
        {
        }
        // vamos utilizar esse método para configurar o banco de
        //        dados
        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para
                //                  especificação
                optionsBuilder.UseSqlServer("Data Source = ESS000N1558804\\SQLEXPRESS; initial catalog = ProjectsAPI;Integrated Security = true; TrustServerCertificate = true");
            }
        }
        // dbset representa as entidades que serão utilizadas
        //            nas operações de leitura, criação, atualização e deleção
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }
}
