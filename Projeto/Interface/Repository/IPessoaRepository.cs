using AplicationTpDB.Models;

namespace AplicationTpDB.Interface.Repository
{
    public interface IPessoaRepository
    {
        Task<List<PessoaModel>> BuscarTodasPessoas();
        Task<PessoaModel> BuscarPorId(string id);

        Task<PessoaModel> AdicionarPessoa(PessoaModel pessoa);

        Task<PessoaModel> AtualizarPessoa(PessoaModel pessoa, string id);

        Task<bool> ApagarPessoa(string id);
    }
}
