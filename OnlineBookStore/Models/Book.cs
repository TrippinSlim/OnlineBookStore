using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineBookStore.Models
{
    public class Book
    {
        public long? BookID { get; set; }
        [Required(ErrorMessage = "Please enter a title for a book")]
        public string Title { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a description for a book")]
        public string Description { get ; set; } = String.Empty;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive number")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please pick a specific category for a book")]
        public string Category { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a supplier name for a book")]
        public string Supplier { get; set; } = String.Empty;
    }
}
