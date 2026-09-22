using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookVault.Models;

/// <summary>Represents a book product in the BookVault catalog.</summary>
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Book title is required.")]
    [DisplayName("Title")]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Author name is required.")]
    [DisplayName("Author")]
    [MaxLength(150)]
    public string Author { get; set; } = string.Empty;

    [Required(ErrorMessage = "Price is required.")]
    [DisplayName("Price ($)")]
    [Range(0.01, 9999.99, ErrorMessage = "Price must be between $0.01 and $9,999.99.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Genre is required.")]
    [DisplayName("Genre")]
    [MaxLength(100)]
    public string Genre { get; set; } = string.Empty;

    [Required(ErrorMessage = "Stock quantity is required.")]
    [DisplayName("Stock Quantity")]
    [Range(0, 10000, ErrorMessage = "Stock must be between 0 and 10,000.")]
    public int StockQuantity { get; set; }

    [DisplayName("Date Added")]
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}
