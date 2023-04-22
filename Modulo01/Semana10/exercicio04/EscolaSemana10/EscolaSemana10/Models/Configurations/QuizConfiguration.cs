using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EscolaSemana10.Models.Configurations
{
    public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DisciplineId).IsRequired();
            builder.Property(x => x.Title);
            builder.Property(x => x.DateOpen);
            builder.Property(x => x.DateClose);

            builder.HasOne(x => x.Discipline_Id)
                .WithMany(x => x.Quizss)
                .HasForeignKey(x => x.DisciplineId)
                .HasConstraintName("FK__Discipline_Q");

            builder.ToTable("Quiz");
        }
    }
}
