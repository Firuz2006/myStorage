using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.CashRepository;

public class BankRepository:Repository<Bank>
{
    public BankRepository(MainDbContext context):base(context)
    {
        
    }
    
    public bool CreateBank(string name)
    {
        _dbSet.Add(new Bank() { CashTjs = 0, CashUsd = 0,Name = name});
        return true;
    }

    public bool Pay(int bankId, decimal oneDollarIs, bool isUsd, decimal money ,int clientId=1)
    {
        var bank=_dbSet.SingleOrDefault(b => b.Id == bankId);
        if (bank == null) return false;

        if (isUsd)
        {
            bank.CashUsd += money;
        }
        else
        {
            bank.CashTjs += money;
        }

        
        CashIn cashIn = new()
        {
            Money = money,
            IsMoneyTypeUsd = isUsd,
            OneDollarIs = oneDollarIs,
            IsClientMoney = clientId==1,
            BankId = bankId,
            ClientId = clientId
        };

        _context.CashIns.Add(cashIn);
        _context.SaveChanges();
        return true;
    }

    public bool WithDraw(int bankId, decimal oneDollarIs, bool isUsd, decimal money ,int clientId=1)
    {
        var bank=_context.Banks.SingleOrDefault(b => b.Id == bankId);
        if (bank == null) return false;

        if (isUsd)
        {
            bank.CashUsd -= money;
        }
        else
        {
            bank.CashTjs -= money;
        }

        
        CashOut cashOut = new()
        {
            Money = money,
            IsMoneyTypeUsd = isUsd,
            OneDollarIs = oneDollarIs,
            IsClientMoney = clientId==1,
            BankId = bankId,
            ClientId = clientId
        };

        _context.CashOuts.Add(cashOut);
        _context.SaveChanges();
        return true;
    }
}