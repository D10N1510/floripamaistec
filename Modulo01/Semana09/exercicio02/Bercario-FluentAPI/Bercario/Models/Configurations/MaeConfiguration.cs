using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bercario.Models.Configurations
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {

        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK__Mae");

            builder.Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasMaxLength(20);
                
            builder.Property(x => x.Data_Nascimento)
                .IsRequired();

            builder.ToTable("Mae");
        }
    }
}
