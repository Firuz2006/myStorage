namespace Otchet.Core.Models;

public class Sale:EntityBase
{
    public int Quantity { get; set; }
    public decimal OneDollarId { get; set; }
    public DateTime Date { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
}