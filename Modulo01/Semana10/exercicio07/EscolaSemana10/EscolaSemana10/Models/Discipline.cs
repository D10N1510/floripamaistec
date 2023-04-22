namespace EscolaSemana10.Models
{
    public class Discipline
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string DisciplineName { get; set; }

        public virtual Teacher Teacher_Id { get; set; }

        public virtual ICollection<Student_Discipline> Student_Discipliness { get; set; }
        public virtual ICollection<Quiz> Quizss { get; set; }

    }
}
