using System.ComponentModel.DataAnnotations;

namespace EntityFramework;

class Product
{
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }
    public Category Category { get; set; }
}