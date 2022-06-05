//importado
using System.ComponentModel.DataAnnotations;

namespace appletenhtmlRazor.Model
{
    public class Suma
    {
        [Required]
        public int Numero1 { get; set; }

        [Required]
        public int Numero2 { get; set; }       

    }
}
