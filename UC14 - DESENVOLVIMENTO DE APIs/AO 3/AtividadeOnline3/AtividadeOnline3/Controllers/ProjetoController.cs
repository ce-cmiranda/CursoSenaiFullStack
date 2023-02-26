using AtividadeOnline3.Models;
using AtividadeOnline3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeOnline3.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;
        //private readonly ManagerRepository _managerRepository;

        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
            //_managerRepository = managerRepository;
        }

        [HttpGet]
        public IActionResult listar()
        {
            try
            {
                return Ok(_projetoRepository.GetAll());
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
                Projeto projetoBuscado = _projetoRepository.GetById(id);
                if (projetoBuscado == null)
                {
                    return NotFound();
                }
                return Ok(projetoBuscado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public IActionResult adicionar(Projeto projeto)
        {
            try
            {
                //Console.WriteLine(projeto);
                //Manager managerBuscado = _managerRepository!.GetById(projeto.Manager!.ManagerId);
                //Console.WriteLine(managerBuscado);
                //projeto.Manager = managerBuscado;
                _projetoRepository.AddNewProjeto(projeto);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Projeto l)
        {
            try
            {
                _projetoRepository.EditById(id, l);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



    }
}
