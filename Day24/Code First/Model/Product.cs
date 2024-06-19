using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public int? Price { get; set; }
    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}