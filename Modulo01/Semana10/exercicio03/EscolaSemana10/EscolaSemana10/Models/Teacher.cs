namespace EscolaSemana10.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Department { get; set; }

        public virtual User User_Id { get; set; }
        public virtual ICollection<Discipline> Discipliness { get; set; }
    }
}
