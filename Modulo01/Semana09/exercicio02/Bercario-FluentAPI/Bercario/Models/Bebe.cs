using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bercario.Models
{
    public class Bebe
    {
        public int Id { get; set; }

      
        public DateTime Data_Nascimento { get; set; }

       
        public decimal Peso_Nascimento { get; set; }

        
        public int Altura { get; set; }

       
        public int IdMae { get; set; }

      
        public int IdParto { get; set; }

      
        public virtual Mae MaeDoBebe { get; set; }

       
        public virtual Parto PartoDoBebe { get; set; }

    }
}
