using System.ComponentModel.DataAnnotations.Schema;

public class TypeDTO
{
    [Column(TypeName = "TEXT")]
    public string TypeName { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
}