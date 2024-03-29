﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bercario.Models
{

    [Table("Medico")]
    public class Medico
    {
        [Key]
        [Column("Id")]
        [Required]
        public int Id { get; set; }

        [Column("CRM")]
        [StringLength(15)]
        [Required]
        public string CRM { get; set; }

        [Column("Nome")]
        [StringLength(60)]
        [Required]
        public string Nome { get; set; }

        [Column("Celular")]
        public int Celular { get; set; }

        [Column("Especialidade")]
        [StringLength(20)]
        public string Especialidade { get; set; }


        public virtual ICollection<Parto> Partos { get; set; }
    }
}
