using AtividadeOnline3.Contexts;
using AtividadeOnline3.Models;

namespace AtividadeOnline3.Repositories
{
    public class ManagerRepository
    {
        private readonly SQLcontext _context;
        public ManagerRepository(SQLcontext context)
        {
            _context = context;
        }
        public List<Manager> GetAll()
        {
            return _context.Managers.ToList();
        }
        public Manager GetById(int id)
        {
            return _context.Managers.Find(id)!;
        }

        public void AddNewManager(Manager novoGerente)
        {
            _context.Add(novoGerente);
            _context.SaveChanges();
        }

        public void EditById(int id, Manager l)
        {
            Manager gerente = _context.Managers.Find(id)!;
            if (gerente != null)
            {
                gerente.ManagerName = l.ManagerName;
                _context.Managers.Update(gerente);
                _context.SaveChanges();

            }
        }
    }
}
