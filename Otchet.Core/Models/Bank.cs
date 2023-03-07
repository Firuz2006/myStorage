namespace Otchet.Core.Models;

public class Bank
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal CashUsd { get; set; }
    public decimal CashTjs { get; set; }
    public List<CashIn> CashIns { get; set; }
    public override string ToString() => Name;
}