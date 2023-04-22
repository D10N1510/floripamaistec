using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bercario.Models
{
    public class Parto
    {
        
        public int Id { get; set; }
        
        public int IdMedico { get; set; }
       
        public DateTime Data_Parto { get; set; }
        
        public TimeSpan Horario_Parto { get; set; }

       
        public virtual Medico MedicoDoParto { get; set; }


        public virtual ICollection<Bebe> BebesDoParto { get; set; }


        public void Display()
        {

        }
    }
}
