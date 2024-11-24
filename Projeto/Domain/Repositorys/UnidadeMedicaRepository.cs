using AplicationTpDB.Data;
using AplicationTpDB.Domain.Repositorios.BaseRepository;
using AplicationTpDB.Interface;
using AplicationTpDB.Models;

namespace AplicationTpDB.Domain.Repositorios
{
    public class UnidadeMedicaRepository : BaseRepository<UnidadeMedicaModel>, IUnidadeMedicaRepository
    {
        private readonly AppDbContext _context;

        public UnidadeMedicaRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _context = appDbContext;
        }

        public Task<UnidadeMedicaModel> GetUnidadeMedicaPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
