using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Map
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(x => x.VeiculoId);
            builder.Property(x => x.Marca).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Modelo).IsRequired().HasMaxLength(30).HasColumnType("Varchar(30)");
            builder.Property(x => x.Ano).IsRequired().HasColumnType("int");
            builder.Property(x => x.Quilometragem).IsRequired().HasColumnType("decimal");
        }
    }
}
