using AplicationTpDB.Data;
using AplicationTpDB.Domain.Repositorios.BaseRepository;
using AplicationTpDB.Interface;
using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Domain.Repositorios
{
    public class ConsultaRepository : BaseRepository<ConsultaModel>, IConsultaRepository
    {
        private readonly AppDbContext _context;

        public ConsultaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<bool> DesmarcarConsulta(int id)
        {
            var consulta = await _context.Consulta.FindAsync(id);
            if (consulta == null)
            {
                return false;
            }
            _context.Consulta.Remove(consulta);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<List<ConsultaModel>> GetConsultasPorMedico(int crm)
        {
            return await _context.Consulta
                .Where(c => c.MedicoCRM == crm)
                .ToListAsync();
        }

        public async Task<List<ConsultaModel>> GetConsultasPorPessoa(string cpf)
        {
            return await _context.Consulta
              .Where(c => c.CPFPaciente == cpf)
              .ToListAsync();
        }

        public async Task<List<ConsultaModel>> GetAllConsultas()
        {
            return await _context.Consulta.ToListAsync();
        }

        public async Task<ConsultaModel> MarcarConsulta(ConsultaModel consulta)
        {

            _context.Consulta.Add(consulta);
            await _context.SaveChangesAsync();
            return consulta;
        }
    }
}
