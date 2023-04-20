using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bercario.Models
{
    [Table("Mae")]
    public class Mae
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("Nome")]
        [StringLength(60)]
        [Required]
        public string Nome { get; set; }

        [Column("Endereco")]
        [StringLength(300)]
        [Required]
        public string Endereco { get; set; }

        [Column("Telefone")]
        [StringLength(20)]
        public string Telefone { get; set; }

        [Column("Data_Nascimento")]
        [Required]
        public DateTime Data_Nascimento { get; set; }

        public virtual ICollection<Bebe> Bebes { get;}
    }
}
