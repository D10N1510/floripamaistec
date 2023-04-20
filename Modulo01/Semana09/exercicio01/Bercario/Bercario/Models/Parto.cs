namespace Bercario.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public int Id_medico { get; set; }
        public DateTime Data_Parto { get; set; }
        public TimeSpan Horario_Parto { get; set; }

    }
}
