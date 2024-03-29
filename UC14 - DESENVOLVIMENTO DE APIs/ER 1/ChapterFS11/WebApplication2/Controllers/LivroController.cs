﻿using ChapterFS11.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterFS11.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
