using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("M")]
public class Factory
{
    [Key]
    public int FactoryId { get; set; }
    [ForeignKey("Brand")]
    public int BrandId { get; set; }
    [Column(TypeName = "TEXT")]
    public string FactoryName { get; set; }
    public int ProductionPrice { get; set; }
    public IEnumerable<Type> Types { get; set; }
    public Factory()
    {
        Types = new List<Type>();
    }
}