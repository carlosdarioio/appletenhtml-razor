//importado
using System.ComponentModel.DataAnnotations;

namespace appletenhtmlRazor.Model
{
    public class Potencia
    {
        [Required]
        public float Base { get; set; }

        [Required]
        public float Exponente{ get; set; }       

    }
}
