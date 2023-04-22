using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EscolaSemana10.Models.Configurations
{
    public class Student_DisciplineConfiguration : IEntityTypeConfiguration<Student_Discipline>
    {
        public void Configure(EntityTypeBuilder<Student_Discipline> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StudentId).IsRequired();
            builder.Property(x => x.DisciplineId).IsRequired();

            builder.HasOne(x => x.Student_Id)
                .WithMany(x => x.Student_Discipliness)
                .HasForeignKey(x=>x.StudentId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK__Student_SD");

            builder.HasOne(x => x.Discipline_Id)
                .WithMany(x => x.Student_Discipliness)
                .HasForeignKey(x => x.DisciplineId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK__Discipline_SD"); ;
                

            builder.ToTable("Student_Discipline");
        }
    }
}
