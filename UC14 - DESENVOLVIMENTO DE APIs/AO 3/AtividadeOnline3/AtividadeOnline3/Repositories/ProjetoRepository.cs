using AtividadeOnline3.Contexts;
using AtividadeOnline3.Models;

namespace AtividadeOnline3.Repositories
{
    public class ProjetoRepository
    {
        private readonly SQLcontext _context;
        public ProjetoRepository(SQLcontext context)
        {
            _context = context;
        }
        public List<Projeto> GetAll()
        {
            return _context.Projetos.ToList();
        }
        public Projeto GetById(int id)
        {
            return _context.Projetos.Find(id)!;
        }

        public void AddNewProjeto(Projeto novoProjeto)
        {
            _context.Add(novoProjeto);
            _context.SaveChanges();
        }

        public void EditById(int id, Projeto l)
        {
            Projeto projeto = _context.Projetos.Find(id)!;
            if (projeto != null)
            {
                projeto.Titulo = l.Titulo;
                _context.Projetos.Update(projeto);
                _context.SaveChanges();

            }
        }
    }
}
