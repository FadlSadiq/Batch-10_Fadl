using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public IEnumerable<Product> products { get; set; }
}