using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PessoaModel> Pessoa {  get; set; }
        public DbSet<PessoaEmailModel> PessoaEmails { get; set; }
        public DbSet<PessoaTelefoneModel> PessoaTelefones { get; set; }

    }
}
