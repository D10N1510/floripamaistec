using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EscolaSemana10.Models.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId);
            builder.Property(x => x.Period);
            builder.Property(x => x.RA);

            builder.HasOne(x => x.User_Id)
                .WithMany(x => x.Studentss)
                .HasForeignKey(x => x.UserId)
                .HasConstraintName("FK__User_S");

            builder.ToTable("Student");
        }
    }
}
