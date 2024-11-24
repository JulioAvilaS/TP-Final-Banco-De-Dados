using AplicationTpDB.Models;
using AplicationTpDB.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicationTpDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoRepositorio _medicoRepositorio;

        public MedicoController(IMedicoRepositorio medicoRepositorio)
        {
            _medicoRepositorio = medicoRepositorio;
        }

        [HttpGet]

        public async Task<ActionResult<List<MedicoModel>>> BuscarTodosMedicos()
        {
            List<MedicoModel> medico = await _medicoRepositorio.BuscarTodosMedicos();
            return Ok(medico);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<MedicoModel>>> BuscarPorId(string cpf)
        {
            MedicoModel medico = await _medicoRepositorio.BuscarPorId(cpf);
            return Ok(medico);
        }

        [HttpPost]
        public async Task<ActionResult<List<MedicoModel>>> Cadastrar([FromBody] MedicoModel medicoModel)
        {
            MedicoModel medico = await _medicoRepositorio.AdicionarMedico(medicoModel);
            return Ok(medico);
        }
    }
}
