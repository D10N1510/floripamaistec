namespace EscolaSemana10.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int DisciplineId { get; set; }

        public virtual Student Student_Id { get; set; }
        public virtual Discipline Discipline_Id { get; set; }
    }
}
