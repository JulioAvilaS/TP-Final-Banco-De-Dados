using AplicationTpDB.Data;
using AplicationTpDB.Models;
using AplicationTpDB.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Repositorios
{
    public class MedicoRepositorio : IMedicoRepositorio
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

        public async Task<MedicoModel> ApagarMedico(string id)
        {
            MedicoModel medicoPorId = await BuscarPorId(id);

            if (medicoPorId == null)
            {
                throw new Exception("Médico não encontrado");
            }

            medicoPorId.PessoaCPF = medicoPorId.PessoaCPF;
            medicoPorId.Status = medicoPorId.Status;
            medicoPorId.Especialidades = medicoPorId.Especialidades;
            medicoPorId.CRM = medicoPorId.CRM;
            medicoPorId.DataAdmissao = medicoPorId.DataAdmissao;
            medicoPorId.Pessoa = medicoPorId.Pessoa;

            _appBbContext.Medico.Update(medicoPorId);
            _appBbContext.SaveChangesAsync();

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

    }
}