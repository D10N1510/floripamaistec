namespace EscolaSemana10.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public decimal Weight { get; set; }
    }
}
