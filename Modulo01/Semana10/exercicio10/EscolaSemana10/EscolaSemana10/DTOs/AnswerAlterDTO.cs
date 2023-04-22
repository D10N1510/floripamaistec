namespace EscolaSemana10.DTOs
{
    public class AnswerAlterDTO
    {
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public string AnswerText { get; set; }
        public string Image { get; set; }
        public float Score { get; set; }
        public string Observation { get; set; }
    }
}
