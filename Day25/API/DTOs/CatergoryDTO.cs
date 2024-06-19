using System.ComponentModel.DataAnnotations.Schema;

public class CategoryDTO
{
    public string CategoryName { get; set; }
    [Column(TypeName = "TEXT")]
    public string Description { get; set; }
}