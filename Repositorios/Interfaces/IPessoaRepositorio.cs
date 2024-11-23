using AplicationTpDB.Models;

namespace AplicationTpDB.Repositorios.Interfaces
{
    public interface IPessoaRepositorio
    {
        Task<List<PessoaModel>> BuscarTodasPessoas();
        Task<PessoaModel> BuscarPorId(string id);

        Task<PessoaModel> AdicionarPessoa(PessoaModel pessoa);

        Task<PessoaModel> AtualizarPessoa(PessoaModel pessoa, int id);

        Task<PessoaModel> ApagarPessoa(int id);
    }
}
