using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bercario.Models.Configurations
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {

            builder.HasKey(x => x.Id).HasName("PK__Medico");

            builder.Property(x => x.CRM)
                .HasMaxLength(15);

            builder.Property(x => x.Nome)
                    .HasMaxLength(60);

            builder.Property(x => x.Celular);

            builder.Property(x => x.Especialidade)
                .HasMaxLength(100);

            builder.ToTable("Medico");
        }
    }
}
