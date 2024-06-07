using System.ComponentModel.DataAnnotations;
namespace EntityFramework;

class Category
{
    [Key] // Key Tabel pada category
    [Required,MaxLength(100)] // this is for CategoryID, this is DataAnotation
    public int CategoryId { get; set; }
    
    public string CategoryName { get; set; }
    [Required,MaxLength(100)]
    public string Description { get; set; }

    public ICollection<Product> Products {get; set;}

}