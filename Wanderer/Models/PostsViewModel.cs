using System.ComponentModel.DataAnnotations;

namespace Wanderer.Models
{
    public class PostsViewModel
    {
        [Key]
        public int id { get; set; }
        public string Description { get; set; }
        public string link { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
