using System;
using Cafe.Class;

namespace Cafe
{
    public abstract class Form:System.Windows.Forms.Form
    {
        protected int _id;
        protected static bool IsClientOpened;
        protected static bool IsCompanyOpened;
        protected static bool IsInvoiceOpened;
        protected static bool IsCashInOpened;
        protected static bool IsCategoryOpened;
        protected static bool IsSaleOpened;
        protected static bool IsRateOpened;
        protected static bool IsUnitOpened;
        protected static bool IsProductOpened;
        protected static bool IsStorageOpened;
        protected static bool IsUserOpened;
        protected static bool IsCashOutOpened;
        protected static bool IsFirmOpened;
        
        protected override void OnClosed(EventArgs e)
        {
            switch (this)
            {
                case frmStorage _:
                    IsStorageOpened = false;
                    break;
                case Rate _:
                    IsRateOpened = false;
                    break;
                case frmCompany _:
                    IsFirmOpened = false;
                    break;
                case frmClient _:
                    IsClientOpened = false;
                    break;
                case frmInvoice _:
                    IsInvoiceOpened = false;
                    break;
                case frmSale _:
                    IsSaleOpened = false;
                    break;
                case frmCashInBox _:
                    IsCashInOpened = false;
                    break;
                case frmCategory _:
                    IsCategoryOpened = false;
                    break;
                case frmUnit _:
                    IsUnitOpened = false;
                    break;
                case frmProduct _:
                    IsProductOpened = false;
                    break;
            }

            base.OnClosed(e);
        }

        protected abstract void _refresh();
        protected abstract void _clear();
    }
}