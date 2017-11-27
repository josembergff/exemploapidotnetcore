using System.ComponentModel.DataAnnotations;

namespace ApiCoreEntity.Models
{
    public class Post
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }
        [Required]
        [MaxLength(500)]
        public string Texto { get; set; }
        public Blog Blog { get; set; }

    }
}