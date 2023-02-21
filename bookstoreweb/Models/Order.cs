using System.ComponentModel.DataAnnotations;

namespace bookstoreweb.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime DateOrdered { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public int UserId { get; set; }
        public Users User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}