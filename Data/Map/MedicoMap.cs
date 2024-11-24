using AplicationTpDB.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace AplicationTpDB.Data.Map
{
    public class MedicoMap : IEntityTypeConfiguration<MedicoModel>
    {
        void IEntityTypeConfiguration<MedicoModel>.Configure(EntityTypeBuilder<MedicoModel> builder)
        {
            builder.HasKey(x => x.PessoaCPF);
            builder.Property(x => x.CRM).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DataAdmissao).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Pessoa).IsRequired().HasMaxLength(100); //tipos são objetos: <PessoaModel>
            builder.Property(x => x.Especialidades).IsRequired().HasMaxLength(100); //tipos são objetos: <Especialidades>
        
        }
    }
}
