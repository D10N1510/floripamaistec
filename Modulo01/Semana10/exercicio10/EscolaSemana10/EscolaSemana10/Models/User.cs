namespace EscolaSemana10.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Teacher> Teacherss { get; set; }
        public virtual ICollection<Student> Studentss { get; set; }


    }
}
