using ChapterFS11.Contexts;
using ChapterFS11.Models;
using ChapterFS11.Repositories;

namespace ChapterFS11.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario usuario);

        void Deletar(int id);

        Usuario Login(string email, string senha);

    }
}