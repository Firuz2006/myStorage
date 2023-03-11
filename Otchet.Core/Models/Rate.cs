namespace Otchet.Core.Models;

public class Rate:EntityBase
{
    
    public decimal Usd { get; set; }
    public decimal Tjs { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}