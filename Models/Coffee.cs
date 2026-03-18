using System.ComponentModel.DataAnnotations;

namespace Proel4W_FInal.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        [Display(Name = "Coffee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between ₱0.01 and ₱10,000.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:₱#,##0.00}")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
    }
}
