using AplicationTpDB.Data;
using AplicationTpDB.Interface.Repository;
using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Domain.Repositorios
{
    public class MedicoRepositorio : IMedicoRepository
    {

        private readonly AppDbContext _appBbContext;
        public MedicoRepositorio(AppDbContext appDbContext)
        {
            _appBbContext = appDbContext;
        }

        public async Task<MedicoModel> BuscarPorId(string id)
        {
            return await _appBbContext.Medico.FirstOrDefaultAsync(x => x.PessoaCPF == id);
        }

        public async Task<List<MedicoModel>> BuscarTodosMedicos()
        {
            return await _appBbContext.Medico.ToListAsync();
        }
        public async Task<MedicoModel> AdicionarMedico(MedicoModel medico)
        {
            await _appBbContext.Medico.AddAsync(medico);
            await _appBbContext.SaveChangesAsync();

            return medico;
        }

        public async Task<MedicoModel> ApagarMedico(int crm)
        {
            MedicoModel medicoPorId = await _appBbContext.Medico
                .Include(m => m.MedicoEspecialidades)
                .FirstOrDefaultAsync(m => m.CRM == crm);

            if (medicoPorId == null)
            {
                throw new Exception("Médico não encontrado");
            }

            if (medicoPorId.MedicoEspecialidades != null)
            {
                _appBbContext.MedicoEspecialidade.RemoveRange(medicoPorId.MedicoEspecialidades);
            }

            _appBbContext.Medico.Remove(medicoPorId);

            await _appBbContext.SaveChangesAsync();

            return medicoPorId;
        }


        public async Task<bool> AtualizarMedico(MedicoModel medico, string id)
        {
            MedicoModel medicoPorId = await BuscarPorId(id);

            if (medicoPorId == null)
            {
                throw new Exception("Médico não encontrado");
            }

            _appBbContext.Medico.Remove(medicoPorId);
            _appBbContext.SaveChanges();

            return true;
        }

        Task<MedicoModel> IMedicoRepository.AtualizarMedico(MedicoModel pessoa, string id)
        {
            throw new NotImplementedException();
        }
    }
}