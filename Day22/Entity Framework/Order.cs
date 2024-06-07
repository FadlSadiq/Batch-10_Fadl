using System.ComponentModel.DataAnnotations;

namespace EntityFramework;

class Order
{
    [Key]
    public int OrderId { get; set; }
    public string OrderName { get; set; }
    public int ProductId { get; set; }
    public DateTime RequestDate { get; set; }
    public DateTime OrderData { get; set; }
}