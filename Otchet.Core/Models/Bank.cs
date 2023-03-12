namespace Otchet.Core.Models;

public class Bank:EntityBase
{
    
    public string Name { get; set; }
    public decimal CashUsd { get; set; }
    public decimal CashTjs { get; set; }
    public List<CashIn> CashIns { get; set; }
    public List<CashOut> CashOuts { get; set; }
    public override string ToString() => Name;
}