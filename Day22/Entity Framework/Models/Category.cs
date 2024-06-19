using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityFramework;

[Table("Categories")]
class Category
{
    [Key] // Key Tabel pada category
    [Required,MaxLength(100)] // this is for CategoryID, this is DataAnotation
    public int CategoryId { get; set; }
    [Required,MaxLength(100)]
    public string CategoryName { get; set; }
    [Column("Description")]
    public string Description { get; set; }
    public IEnumerable<Product> Products { get; set; }
    public Category()
    {
        Products = new List<Product>(); // Use IEnumerable can assign any collection to create
    }

    // public ICollection<Product> Products {get; set;}

}