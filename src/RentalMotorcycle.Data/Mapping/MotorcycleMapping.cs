using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalMotorcycle.business.Entities.Motorcycle;

namespace RentalMotorcycle.Data.Mapping;

public class MotorcycleMapping : IEntityTypeConfiguration<Motorcycle>
{
    public void Configure(EntityTypeBuilder<Motorcycle> builder)
    {
        builder.ToTable("motorcycle");
        
        builder.HasKey(i => i.Id);
        builder.Property(i => i.Id)
            .IsRequired()
            .HasColumnType("uuid")
            .HasColumnName("id");
        
        builder.Property(i => i.Identificador)
            .IsRequired()
            .HasColumnType("varchar")
            .HasColumnName("identificador");
        
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