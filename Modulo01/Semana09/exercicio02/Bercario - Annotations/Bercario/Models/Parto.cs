using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bercario.Models
{
    [Table("Parto")]
    public class Parto
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Id_medico")]
        [Required]
        public int IdMedico { get; set; }

        [Column("Data_Parto")]
        [Required]
        public DateTime Data_Parto { get; set; }

        [Column("Horario_Parto")]
        [Required]
        public TimeSpan Horario_Parto { get; set; }

        [ForeignKey("IdMedico")]
        public virtual Medico MedicoDoParto { get; set; }


        public virtual ICollection<Bebe> BebesDoParto { get;}


        public void Display()
        {

        }
    }
}
