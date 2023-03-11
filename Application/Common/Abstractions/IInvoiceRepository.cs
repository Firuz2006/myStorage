using Otchet.Core.Models;

namespace Application.Common.Abstractions;

public interface IInvoiceRepository:IRepository<Invoice>
{
    bool Buy(Invoice invoice);
}