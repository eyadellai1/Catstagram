using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catstagram.Models
{
    public class Post
    {
        public Post()
        {
            DateAdded = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public string? Image { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Comment { get; set; }

        public DateTime DateAdded { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

    }
}
