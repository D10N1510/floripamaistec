using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace EscolaSemana10.Models.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.QuizId).IsRequired();
            builder.Property(x => x.Enunciation);
            builder.Property(x => x.Weight).HasColumnType("decimal(4,3)");

            builder.HasOne(x => x.Quiz_Id)
                .WithMany(x => x.Questionss)
                .HasForeignKey(x => x.QuizId)
                .HasConstraintName("FK__QuizQuestion");

            builder.ToTable("Question");
        }
    }
}
