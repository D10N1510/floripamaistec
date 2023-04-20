using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bercario.Models
{
    [Table("Bebe")]
    public class Bebe
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Data_Nascimento")]
        [Required]
        public DateTime Data_Nascimento { get; set; }

        [Column("Peso_Nascimento")]
        [Required]
        public decimal Peso_Nascimento { get; set; }

        [Column("Altura")]
        [Required]
        public int Altura { get; set; }

        [Column("Id_Mae")]
        [Required]
        public int IdMae { get; set; }

        [Column("Id_Parto")]
        [Required]
        public int IdParto { get; set; }

        [ForeignKey("IdMae")]
        public virtual Mae MaeDoBebe { get; set; }

        [ForeignKey("IdParto")]
        public virtual Parto PartoDoBebe { get; set; }

    }
}
