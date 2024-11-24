using AplicationTpDB.Models;

namespace AplicationTpDB.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<PessoaModel>> BuscarTodasPessoas();
        Task<PessoaModel> BuscarPorId(string id);

        Task<PessoaModel> AdicionarPessoa(PessoaModel pessoa);

        Task<PessoaModel> AtualizarPessoa(PessoaModel pessoa, string id);

        Task<PessoaModel> ApagarPessoa(string id);
    }
}
