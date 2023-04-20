using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bercario.Models.Configurations
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK__Bebe");
            
            builder.HasOne(x => x.MaeDoBebe)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.IdMae)
                .HasConstraintName("FK_Id_Mae");

            builder.HasOne(x => x.PartoDoBebe)
                .WithMany(x => x.BebesDoParto)
                .HasForeignKey(x => x.IdParto)
                .HasConstraintName("FK_Id_Parto");

            builder.Property(x => x.Data_Nascimento)
                .IsRequired();

            builder.Property(x => x.Peso_Nascimento)
                .HasColumnType("decimal(4,3)")
                .IsRequired();

            builder.Property(x => x.Altura)
                .IsRequired();

            builder.ToTable("Bebe");
        }
    }
}
