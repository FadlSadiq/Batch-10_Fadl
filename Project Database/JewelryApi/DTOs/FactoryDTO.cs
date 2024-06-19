using System.ComponentModel.DataAnnotations.Schema;

public class FactoryDTO
{
    [Column(TypeName = "TEXT")]
    public string FactoryName { get; set; }
    public int ProductionPrice { get; set; }
}