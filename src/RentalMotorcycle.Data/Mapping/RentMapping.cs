using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentalMotorcycle.Business.Entities.Rental;

namespace RentalMotorcycle.Data.Mapping;

public class RentMapping : IEntityTypeConfiguration<Rent>
{
   public void Configure(EntityTypeBuilder<Rent> builder)
   {
      builder.ToTable("rental");

      builder.HasKey(i => i.Id);
      builder.Property(i => i.Id)
         .IsRequired()
         .HasColumnType("uuid")
         .HasColumnName("id");
      
      builder.Property(i => i.Entregador_id)
         .IsRequired()
         .HasColumnType("varchar")
         .HasColumnName("entragor_id");
      
      builder.Property(i => i.Moto_id)
         .IsRequired()
         .HasColumnType("varchar")
         .HasColumnName("moto_id");
      
      builder.Property(i => i.Data_inicio)
         .IsRequired()
         .HasColumnType("date")
         .HasColumnName("data_inicio");
      
      builder.Property(i => i.Data_termino)
         .IsRequired()
         .HasColumnType("date")
         .HasColumnName("data_fim");
      
      builder.Property(i => i.Data_previsao_termino)
         .IsRequired()
         .HasColumnType("date")
         .HasColumnName("data_previsao");
      
      builder.Property(i => i.Data_devolucao)
         .HasColumnType("date")
         .HasColumnName("data_devolucao");
      
      builder.Property(i => i.Plano)
         .HasColumnType("int")
         .HasColumnName("plano");
   }
}