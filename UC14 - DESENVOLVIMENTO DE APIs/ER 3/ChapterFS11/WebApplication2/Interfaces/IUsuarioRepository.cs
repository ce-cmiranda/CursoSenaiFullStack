﻿using ChapterFS11.Models;

namespace ChapterFS11.Interfaces
{
    public interface IUsuarioRepository
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
}
