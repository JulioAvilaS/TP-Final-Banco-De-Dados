using AplicationTpDB.Models;

namespace AplicationTpDB.Interface
{
    public interface IUnidadeMedicaRepository
    {
        Task<UnidadeMedicaModel> GetUnidadeMedicaPorNome(string nome);

    }
}
