using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;namespace EscolaSemana10.Models.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.Department);

            builder.HasOne(x => x.User_Id)
                .WithMany(x => x.Teacherss)
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK__User_T");

            builder.ToTable("Teacher");
        }
    }
}
