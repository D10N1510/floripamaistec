using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK__Parto");

            builder.HasOne(x => x.MedicoDoParto)
                .WithMany(x => x.Partos)
                .HasForeignKey(x => x.IdMedico)
                .HasConstraintName("FK_Id_Medico");

            builder.Property(x => x.Data_Parto);

            builder.Property(x => x.Horario_Parto);

            builder.ToTable("Parto");
        }
    }
}
