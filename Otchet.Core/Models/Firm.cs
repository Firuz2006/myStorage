namespace Otchet.Core.Models;

public class Firm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public List<Invoice> Invoices { get; set; }
    public override string ToString()=> Name;

}