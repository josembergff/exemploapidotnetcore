using System.ComponentModel.DataAnnotations;

namespace ApiCoreEntity.Models
{
    public class Blog
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }
        [Required]
        [MaxLength(300)]
        public string Resumo { get; set; }
        [Required]
        [MaxLength(100)]
        public string Url { get; set; }
        [MaxLength(60)]
        public string Autor { get; set; }

    }
}
