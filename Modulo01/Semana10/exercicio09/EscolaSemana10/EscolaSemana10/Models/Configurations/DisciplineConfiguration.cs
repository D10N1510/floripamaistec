using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EscolaSemana10.Models.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TeacherId).IsRequired();
            builder.Property(x => x.DisciplineName);

            builder.HasOne(x => x.Teacher_Id)
                .WithMany(x => x.Discipliness)
                .HasForeignKey(x => x.TeacherId)
                .HasConstraintName("FK__TeacherDiscipline");

            builder.ToTable("Discipline");
        }
    }
}
