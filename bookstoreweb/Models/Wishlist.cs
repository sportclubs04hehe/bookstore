using System.ComponentModel.DataAnnotations;

namespace bookstoreweb.Models
{
    public class Wishlist
    {
        [Key]
        public int WishlistId { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
