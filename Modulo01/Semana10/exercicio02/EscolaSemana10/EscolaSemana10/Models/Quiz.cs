namespace EscolaSemana10.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public string Title { get; set; }
        public DateTime DateOpen { get; set; }
        public DateTime DateClose { get; set; }
    }
}
