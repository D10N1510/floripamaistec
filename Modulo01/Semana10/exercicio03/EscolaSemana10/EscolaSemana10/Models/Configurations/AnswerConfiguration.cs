using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EscolaSemana10.Models.Configurations
{
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.QuestionId).IsRequired();
            builder.Property(x => x.StudentId).IsRequired();
            builder.Property(x => x.AnswerText);
            builder.Property(x => x.Score);
            builder.Property(x => x.Image);
            builder.Property(x => x.Observation);

            builder.HasOne(x => x.Question_Id)
                .WithMany(x => x.Answerss)
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuestionAnswer");

            builder.HasOne(x => x.Student_Id)
                .WithMany(x => x.Answerss)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentAnswer");


            builder.ToTable("Answer");
        }
    }
}
