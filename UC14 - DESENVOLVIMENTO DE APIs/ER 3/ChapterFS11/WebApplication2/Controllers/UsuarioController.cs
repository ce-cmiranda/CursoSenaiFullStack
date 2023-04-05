using ChapterFS11.Models;
using ChapterFS11.Interfaces;
using ChapterFS11.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using static ChapterFS11.Interfaces.IUsuarioRepository;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace ChapterFS11.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly Interfaces.IUsuarioRepository.IUsuarioRepository _iUsuarioRepository;

        public LoginController(Interfaces.IUsuarioRepository.IUsuarioRepository iUsuarioRepository)
        {
            _iUsuarioRepository = iUsuarioRepository;
        }

        [HttpGet("{id}")]

        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Usuario usuarioEncontrado = _iUsuarioRepository.BuscarPorId(id);

                if (usuarioEncontrado != null)
                {
                    return Ok(usuarioEncontrado);
                }
                return NotFound();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                _iUsuarioRepository.Cadastrar(usuario);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _iUsuarioRepository.Deletar(id);
                return Ok("Usuário deletado com sucesso");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            try
            {
                _iUsuarioRepository.Atualizar(id, usuario);
                return Ok("Usuário atualizado com sucesso");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}