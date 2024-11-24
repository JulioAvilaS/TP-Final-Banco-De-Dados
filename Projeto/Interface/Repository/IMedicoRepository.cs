using AplicationTpDB.Models;

namespace AplicationTpDB.Interface.Repository
{
    public interface IMedicoRepository
    {
        Task<List<MedicoModel>> BuscarTodosMedicos();
        Task<MedicoModel> BuscarPorId(string id);

        Task<MedicoModel> AdicionarMedico(MedicoModel pessoa);

        Task<MedicoModel> AtualizarMedico(MedicoModel pessoa, string id);

        Task<MedicoModel> ApagarMedico(int crm);
    }
}
