﻿using ChapterFS11.Contexts;
using ChapterFS11.Interfaces;
using ChapterFS11.Models;

namespace ChapterFS11.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SQLcontext _context;

        public UsuarioRepository(SQLcontext context)
        {
            _context = context;
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuarioEncontrado = _context.Usuarios.Find(id)!;

            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Email = usuario.Email;
                usuarioEncontrado.Senha = usuario.Senha;
                usuarioEncontrado.Tipo = usuario.Tipo;

                _context.Usuarios.Update(usuarioEncontrado);
                _context.SaveChanges();
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id)!;
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            _context.Usuarios.Add(novoUsuario);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuario = _context.Usuarios.Find(id)!;
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha)!;
        }
    }
}
