using System.Reflection.Metadata;
using Application.Common.Abstractions;
using Otchet.Core.Models;
using Otchet.DataBase.Contexts;

namespace Otchet.Repository.BusinessProcessRepository;

public class SaleRepository:Repository<Sale>,ISaleRepository
{
    public SaleRepository(MainDbContext context) : base(context)
    {
    }
}