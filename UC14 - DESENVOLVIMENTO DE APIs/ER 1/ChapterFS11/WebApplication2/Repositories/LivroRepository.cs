using ChapterFS11.Contexts;
using ChapterFS11.Models;

namespace ChapterFS11.Repositories
{
    public class LivroRepository
    {
        private readonly SQLcontext _context;
        public LivroRepository(SQLcontext context) 
        {
            _context = context;
        }
        public List<Livro> GetAll()
        {
            return _context.Livros.ToList();
        }
    }
}
