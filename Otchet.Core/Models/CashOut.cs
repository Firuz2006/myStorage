namespace Otchet.Core.Models;

public class CashOut
{
    public int Id { get; set; }
    public decimal OneDollarIs { get; set; }
    public bool IsMoneyTypeUsd { get; set; }
    public bool IsClientMoney { get; set; }
    public int ClientId { get; set; }
    public decimal Money { get; set; }
    public string Desk { get; set; }
    public int BankId { get; set; }
    public DateTime Date { get; set; }=DateTime.Now;
}