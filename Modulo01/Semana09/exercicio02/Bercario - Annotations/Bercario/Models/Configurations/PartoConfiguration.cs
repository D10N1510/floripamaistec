using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configurations
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasOne(x => x.MedicoDoParto)
                .WithMany(x => x.Partos)
                .HasForeignKey(x => x.IdMedico)
                .HasConstraintName("FK_Id_Medico");

        }
    }
}
