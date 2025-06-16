using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalMotorcycle.Business.Entities.DeliveryMen;

namespace RentalMotorcycle.Data.Mapping;

public class DeliveryManMapping : IEntityTypeConfiguration<DeliveryMan>
{
    public void Configure(EntityTypeBuilder<DeliveryMan> builder)
    {
        builder.ToTable("DeliveryMan");
        
        builder.HasKey(i => i.Identificador);
        builder.Property(i => i.Identificador)
            .IsRequired(true)
            .HasColumnType("varchar")
            .HasColumnName("id");
        
        builder.Property(i => i.Nome)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("nome");
        
        builder.Property(i => i.Cnpj)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("cnpj");
        
        builder.Property(i => i.Data_nascimento)
            .IsRequired()
            .HasColumnType("date")
            .HasColumnName("data_nascimento");
        
        builder.Property(i => i.Numero_cnh)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("cnh");
        
        builder.Property(i => i.Tipo_cnh)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("tipo_cnh");
        
        builder.Property(i => i.Imagem_cnh)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("imagem_cnh");
    }
}