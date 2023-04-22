namespace EscolaSemana10.Models
{
    public class Answer
    {

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string AnswerText { get; set; }
        public string Image { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }

        public virtual Question Question_Id { get; set; }
        public virtual Student Student_Id { get; set; }

    }
}
