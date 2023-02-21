using System.ComponentModel.DataAnnotations;

namespace bookstoreweb.Models
{
    public class Publisher
    {
        [Key]
        public int publisher_id { get; set; }
        [Required]
        [StringLength(50)]
        public string publisher_name { get; set; }
        public string publisher_address { get; set; }
        public string publisher_email { get; set; }
        public ICollection<Book> books { get; set; }
    }
}
