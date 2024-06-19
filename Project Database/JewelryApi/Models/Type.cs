using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Type
{
    [Key]
    public int TypeId { get; set; }
    public string TypeName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    [ForeignKey("Category")]
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
}