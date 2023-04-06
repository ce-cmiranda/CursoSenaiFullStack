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
        public Livro GetById(int id)
        {
            return _context.Livros.Find(id)!;
        }

        public void AddNewLivro(Livro novoLivro)
        {
            _context.Add(novoLivro);
            _context.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Livro livro = _context.Livros.Find(id)!;
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }

        public void EditById(int id, Livro l)
        {
            Livro livro = _context.Livros.Find(id)!;
            if (livro != null)
            {
                livro.Titulo = l.Titulo;
                livro.QuantidadePaginas = l.QuantidadePaginas;
                livro.Disponivel = l.Disponivel;
                _context.Livros.Update(livro);
                _context.SaveChanges();

            }
        }
    }
}
