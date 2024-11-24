using AplicationTpDB.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AplicationTpDB.Repositorios.Interfaces;
using AplicationTpDB.Models;

namespace AplicationTpDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoaModel>>> BuscarPessoas(){

            List<PessoaModel> pessoa = await _pessoaRepositorio.BuscarTodasPessoas();    
            return Ok(pessoa);
        }

        [HttpGet("{cpf}")]
        public async Task<ActionResult<List<PessoaModel>>> BuscarPorId(string cpf )
        {

            PessoaModel pessoa= await _pessoaRepositorio.BuscarPorId(cpf);
            return Ok(pessoa);
        }

        [HttpGet]
        public async Task<ActionResult<List<PessoaModel>>> Cadastrar([FromBody] PessoaModel pessoaModel)
        {
            PessoaModel pessoa = await _pessoaRepositorio.AdicionarPessoa(pessoaModel);

            return Ok(pessoa);
        }
    }
}
