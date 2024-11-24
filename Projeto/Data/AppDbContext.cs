using AplicationTpDB.Data.Map;
using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PessoaModel> Pessoa { get; set; }
        public DbSet<PessoaEmailModel> PessoaEmails { get; set; }
        public DbSet<PessoaTelefoneModel> PessoaTelefones { get; set; }
        public DbSet<CoberturaPlanoModel> CoberturaPlano { get; set; }
        public DbSet<ConsultaModel> Consulta { get; set; }
        public DbSet<DependenteModel> Dependente { get; set; }
        public DbSet<EspecialidadeModel> Especialidade { get; set; }
        public DbSet<MedicoModel> Medico { get; set; }
        public DbSet<MedicoEspecialidadeModel> MedicoEspecialidade { get; set; }
        public DbSet<PlanoModel> Plano { get; set; }
        public DbSet<ProcedimentoModel> Procedimento { get; set; }
        public DbSet<TitularModel> Titular { get; set; }
        public DbSet<UnidadeMedicaModel> UnidadeMedica { get; set; }
        public DbSet<UnidadeEmailModel> UnidadeEmails { get; set; }
        public DbSet<UnidadeTelefoneModel> UnidadeTelefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MedicoEspecialidadeModel>()
                .HasKey(me => new { me.MedicoCRM, me.EspecialidadeID }); // Define a chave composta

            // Relacionamento entre MedicoEspecialidade e Medico
            modelBuilder.Entity<MedicoEspecialidadeModel>()
                .HasOne(me => me.Medico)
                .WithMany(m => m.MedicoEspecialidades)
                .HasForeignKey(me => me.MedicoCRM); // Relaciona MedicoCRM à chave primária de MedicoModel (CRM)

            // Relacionamento entre MedicoEspecialidade e Especialidade
            modelBuilder.Entity<MedicoEspecialidadeModel>()
                .HasOne(me => me.Especialidade)
                .WithMany(e => e.MedicoEspecialidades)
                .HasForeignKey(me => me.EspecialidadeID); // Relaciona EspecialidadeID à chave primária de EspecialidadeModel (ID)

            // Outras configurações do modelo
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new MedicoMap());




        }
    }
}