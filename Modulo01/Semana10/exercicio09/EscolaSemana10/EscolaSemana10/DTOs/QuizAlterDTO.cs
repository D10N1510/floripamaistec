namespace EscolaSemana10.DTOs
{
    public class QuizAlterDTO
    {
        public int DisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
    }
}
