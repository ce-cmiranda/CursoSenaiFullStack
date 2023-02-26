using AtividadeOnline3.Models;
using AtividadeOnline3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeOnline3.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly ManagerRepository _managerRepository;

        public ManagerController(ManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        [HttpGet]
        public IActionResult listar()
        {
            try
            {
                return Ok(_managerRepository.GetAll());
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
                Manager managerBuscado = _managerRepository.GetById(id);
                if (managerBuscado == null)
                {
                    return NotFound();
                }
                return Ok(managerBuscado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPost]
        public IActionResult adicionar(Manager gerente)
        {
            try
            {
                _managerRepository.AddNewManager(gerente);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Alterar(int id, Manager l)
        {
            try
            {
                _managerRepository.EditById(id, l);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }



    }
}
