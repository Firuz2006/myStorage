namespace Otchet.Core.Models;

public class Invoice:EntityBase
{
    public int Quantity { get; set; }
    public decimal OneDollarIs { get; set; }
    public decimal SellingPrice { get; set; }
    public DateTime Date { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

    public int FirmId { get; set; }
    public Firm Firm { get; set; }

    public int StorageId { get; set; }
    public Storage Storage { get; set; }
}