using System;
using System.Windows.Forms;

namespace Cafe
{
    public class Form:System.Windows.Forms.Form
    {
        protected int _id;
        protected static bool IsClientOpened;
        protected static bool IsInvoiceOpened;
        protected static bool IsExpenseOpened;
        protected static bool IsCashInOpened;
        protected static bool IsCategoryOpened;
        protected static bool IsSaleOpened;
        protected static bool IsRateOpened;
        protected static bool IsUnitOpened;
        protected static bool IsProductOpened;
        protected static bool IsStorageOpened;
        protected static bool IsCashOutOpened;
        protected static bool IsFirmOpened;
        protected static bool IsReportOpened;
        protected static bool IsIncomeOpened { get; set; }


        protected void TextBoxDoubleValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
        protected override void OnClosed(EventArgs e)
        {
            switch (this)
            {
                case FrmStorage _:
                    IsStorageOpened = false;
                    break;
                case Rate _:
                    IsRateOpened = false;
                    break;
                case FrmCompany _:
                    IsFirmOpened = false;
                    break;
                case FrmClient _:
                    IsClientOpened = false;
                    break;
                case FrmInvoice _:
                    IsInvoiceOpened = false;
                    break;
                case FrmSale _:
                    IsSaleOpened = false;
                    break;
                case FrmCashInBox _:
                    IsCashInOpened = false;
                    break;
                case FrmCategory _:
                    IsCategoryOpened = false;
                    break;
                case FrmUnit _:
                    IsUnitOpened = false;
                    break;
                case FrmProduct _:
                    IsProductOpened = false;
                    break;
                case FrmIncome _:
                    IsIncomeOpened = false;
                    break;
            }

            base.OnClosed(e);
        }

        protected virtual void _refresh(){}
        protected virtual void _clear(){}
    }
}