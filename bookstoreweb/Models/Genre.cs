using System.ComponentModel.DataAnnotations;

namespace bookstoreweb.Models
{
    public class Genre
    {
        [Key]
        public int genre_id { get; set; }
        [Required]
        [StringLength(50)]
        public string genre_name { get; set; }
        public ICollection<Book> books { get; set; }

    }
}
