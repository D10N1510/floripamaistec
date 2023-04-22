namespace EscolaSemana10.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Period { get; set; }
        public int RA { get; set; }

        public virtual User User_Id { get; set; }
        public virtual ICollection<Student_Discipline> Student_Discipliness { get; set; }
        public virtual ICollection<Answer> Answerss { get; set; }

    }
}
