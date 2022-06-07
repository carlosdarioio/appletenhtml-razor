//importado
using System.ComponentModel.DataAnnotations;
namespace appletenhtmlRazor.Model
{
    public class Article
    {
        //prop tab = atajo
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

    }
}
