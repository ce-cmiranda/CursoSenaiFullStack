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


        /*        [HttpPost]

                public IActionResult Login(LoginViewModel dadosLogin)
                {
                    try
                    {
                        Usuario usuarioBuscado = _iUsuarioRepository.Login(dadosLogin?.email!, dadosLogin?.senha!)!;

                        if (usuarioBuscado == null)
                        {
                            return Unauthorized(new { msg = "Email ou Senha incorreto" });
                        }

                        //inicio da configuração do token
                        var minhasClaims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado ?.Email!),
                            new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado?.id.ToString()!),
                            new Claim(ClaimTypes.Role, usuarioBuscado ?.Tipo!)
                        };

                        var chave = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chapter-chave-autenticacao"));

                        var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

                        var meuToken = new JwtSecurityToken(

                            issuer: "chapter.webapi",
                            audience: "chapter.webapi",
                            claims: minhasClaims,
                            expires: DateTime.Now.AddMinutes(60),
                            signingCredentials: credenciais
                            );

                        return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(meuToken) });

                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }

                }*/





    }
}