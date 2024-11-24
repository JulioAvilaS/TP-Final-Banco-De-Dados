using AplicationTpDB.Models;

namespace AplicationTpDB.Interface
{
    public interface IConsultaRepository : IBaseRepository<ConsultaModel>
    {
        Task<List<ConsultaModel>> GetAllConsultas();
        Task<List<ConsultaModel>> GetConsultasPorPessoa(string cpf);
        Task<List<ConsultaModel>> GetConsultasPorMedico(int crm);
        Task<ConsultaModel> MarcarConsulta(ConsultaModel consulta);
        Task<bool> DesmarcarConsulta(int id);

    }
}
