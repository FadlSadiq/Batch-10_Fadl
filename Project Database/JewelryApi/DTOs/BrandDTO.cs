using System.ComponentModel.DataAnnotations.Schema;

public class BrandDTO
{
    public string BrandName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
}