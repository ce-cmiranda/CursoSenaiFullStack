using ChapterFS11.Models;
using ChapterFS11.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFS11.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult listar()
        {
            try
            {
                return Ok(_livroRepository.GetAll());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult buscaPorId(int id)
        {
            try
            {
                Livro livroBuscado = _livroRepository.GetById(id);
                if (livroBuscado == null)
                {
                    return NotFound();
                }
                return Ok(livroBuscado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult adicionar(Livro livro)
        {
            try
            {
                _livroRepository.AddNewLivro(livro);
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
                _livroRepository.DeleteById(id);
                return Ok("Livro removido com sucesso");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Livro l)
        {
            try
            {
                _livroRepository.EditById(id, l);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



    }
}
