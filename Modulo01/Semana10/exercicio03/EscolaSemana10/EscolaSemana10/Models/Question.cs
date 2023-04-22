namespace EscolaSemana10.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }

        public virtual Quiz Quiz_Id { get; set; }

        public virtual ICollection<Answer> Answerss { get; set; }
    }
}
