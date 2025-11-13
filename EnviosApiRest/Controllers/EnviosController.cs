using EnviosApiRest.Models.Domain;
using EnviosApiRest.Models.Dto;
using EnviosApiRest.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnviosApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnviosController : ControllerBase
    {
        private readonly IEnvioRepository envioRepository;
        public EnviosController(IEnvioRepository envioRepository) { 
            this.envioRepository = envioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var envios = await envioRepository.GetAllAsync();
            return Ok(envios);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var envio = await envioRepository.GetByIdAsync(id);
            if (envio == null) { 
                return NotFound();
            }
            return Ok(envio);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EnvioCreateDto envioCreateDto)
        {
            // Map 2 Domain Model
            var envioDomainModel = new Envio();
            envioDomainModel.Destinatario = envioCreateDto.Destinatario;
            envioDomainModel.Direccion = envioCreateDto.Direccion;
            envioDomainModel.Estado = envioCreateDto.Estado;

            var status = await envioRepository.CreateAsync(envioDomainModel);

            if (status)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
