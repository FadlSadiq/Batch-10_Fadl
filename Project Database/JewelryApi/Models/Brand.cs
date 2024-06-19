using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Brand")]
public class Brand
{
    [Key]
    public int BrandId { get; set; }
    public string BrandName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
    public IEnumerable<Type> Types { get; set; }
    public Brand()
    {
        Types = new List<Type>();
    }
}