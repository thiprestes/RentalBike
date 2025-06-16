using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalMotorcycle.Business.Entities.Motorcycles;

namespace RentalMotorcycle.Data.Mapping;

public class MotorcycleMapping : IEntityTypeConfiguration<Motorcycle>
{
    public void Configure(EntityTypeBuilder<Motorcycle> builder)
    {
        builder.ToTable("motorcycle");
        
        builder.HasKey(i => i.Identificador);
        builder.Property(i => i.Identificador)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("id");
        
        builder.Property(i => i.Ano)
            .IsRequired()
            .HasColumnType("integer")
            .HasColumnName("ano");
        
        builder.Property(i => i.Modelo)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("modelo");
        
        builder.Property(i => i.Placa)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("placa");
    }    
}