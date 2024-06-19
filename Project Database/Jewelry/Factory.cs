using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("M")]
public class Factory
{
    [Key]
    public int FactoryId { get; set; }
    [ForeignKey("Brand")]
    public int BrandId { get; set; }
    public string FactoryName { get; set; }
    [Column(TypeName = "TEXT")]
    public int ProductionPrice { get; set; }
    public IEnumerable<Type> types { get; set; }
}