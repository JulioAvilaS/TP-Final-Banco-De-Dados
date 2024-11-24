using AplicationTpDB.Models;

namespace AplicationTpDB.Repositorios.Interfaces
{
    public interface IMedicoRepositorio
    {
        Task<List<MedicoModel>> BuscarTodosMedicos();
        Task<MedicoModel> BuscarPorId(string id);

        Task<MedicoModel> AdicionarMedico(MedicoModel pessoa);

        Task<MedicoModel> AtualizarMedico(MedicoModel pessoa, string id);

        Task<MedicoModel> ApagarMedico(string id);
    }
}
