using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void _btnClient_Click(object sender, EventArgs e)
        {
            if (IsClientOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");
            }
            else
            {
                new FrmClient().Show();
                IsClientOpened = true;
            }
        }

        private void _btnRate_Click(object sender, EventArgs e)
        {
            if (IsRateOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new Rate().Show();
                IsRateOpened = true;
            }
        }

        private void _btnStorage_Click(object sender, EventArgs e)
        {
            if (IsStorageOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmStorage().Show();
                IsStorageOpened = true;
            }
            
        }

        private void _btnProduct_Click(object sender, EventArgs e)
        {
            if (IsProductOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmProduct().Show();
                IsProductOpened = true;
            }

        }

        private void _bntUnit_Click(object sender, EventArgs e)
        {
            if (IsUnitOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");
  
            }
            else
            {
                new FrmUnit().Show();
                IsUnitOpened = true;
            }

        }

        private void _btnSale_Click(object sender, EventArgs e)
        {
            if (IsSaleOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");
 
            }
            else
            {
                new FrmSale().Show();
                IsSaleOpened = true;
            }

        }

        private void _btnFirm_Click(object sender, EventArgs e)
        {
            if (IsFirmOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmCompany().Show();
                IsFirmOpened = true;
            }

        }

        private void _btnInvoice_Click(object sender, EventArgs e)
        {
            if (IsInvoiceOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmInvoice().Show();
                IsInvoiceOpened = true;
            }

        }

        private void _btnCategory_Click(object sender, EventArgs e)
        {
            if (IsCategoryOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmCategory().Show();
                IsCategoryOpened = true;
            }

        }

        private void _btnCashIn_Click(object sender, EventArgs e)
        {
            if (IsCashInOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmCashInBox().Show();
                IsCashInOpened = true;
            }

        }

        private void _btnCashOut_Click(object sender, EventArgs e)
        {
            if (IsCashOutOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmCashOutBox().Show();
                IsCashOutOpened = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsIncomeOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmIncome().Show();
                IsIncomeOpened = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsExpenseOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");

            }
            else
            {
                new FrmExpense().Show();
                IsExpenseOpened = true;
            }
        }

        private void _btnReport_Click(object sender, EventArgs e)
        {
            if (IsReportOpened)
            {
                MessageBox.Show(@"Эта форма уже открыта");
            }
            else
            {
                new FrmReport().Show();
                IsReportOpened = true;
            }
        }
    }
}