namespace Otchet.Core.Models;

public sealed class Product:EntityBase
{
    public string Name { get; set; }
    
    public int UnitId { get; set; }
    public Unit Unit { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public List<Invoice> Invoices { get; set; }
    public List<Sale> Sales { get; set; }
    public override string ToString()=> Name;

}