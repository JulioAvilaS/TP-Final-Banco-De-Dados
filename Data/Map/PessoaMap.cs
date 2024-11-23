using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AplicationTpDB.Models;


namespace AplicationTpDB.Data.Map
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaModel>
    {
        void IEntityTypeConfiguration<PessoaModel>.Configure(EntityTypeBuilder<PessoaModel> builder)
        {
            builder.HasKey(x => x.CPF);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Genero).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DataNascimento).IsRequired().HasMaxLength(100);
            builder.Property(x => x.CEP).IsRequired().HasMaxLength(100);
            builder.Property(x => x.NumeroEndereco).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Rua).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(100);
        }
    }
}
