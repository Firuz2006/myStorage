using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void _btnClient_Click(object sender, EventArgs e)
        {
            if (IsClientOpened)
            {
                MessageBox.Show("Эта форма уже открыта");
            }
            else
            {
                new frmClient().Show();
                IsCategoryOpened = true;
            }
        }

        private void _btnRate_Click(object sender, EventArgs e)
        {
            if (IsRateOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

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
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmStorage().Show();
                IsStorageOpened = true;
            }
            
        }

        private void _btnProduct_Click(object sender, EventArgs e)
        {
            if (IsProductOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmProduct().Show();
                IsProductOpened = true;
            }

        }

        private void _bntUnit_Click(object sender, EventArgs e)
        {
            if (IsUnitOpened)
            {
                MessageBox.Show("Эта форма уже открыта");
  
            }
            else
            {
                new frmUnit().Show();
                IsUnitOpened = true;
            }

        }

        private void _btnSale_Click(object sender, EventArgs e)
        {
            if (IsSaleOpened)
            {
                MessageBox.Show("Эта форма уже открыта");
 
            }
            else
            {
                new frmSale().Show();
                IsSaleOpened = true;
            }

        }

        private void _btnFirm_Click(object sender, EventArgs e)
        {
            if (IsFirmOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmCompany().Show();
                IsFirmOpened = true;
            }

        }

        private void _btnInvoice_Click(object sender, EventArgs e)
        {
            if (IsInvoiceOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmInvoice().Show();
                IsInvoiceOpened = true;
            }

        }

        private void _btnCategory_Click(object sender, EventArgs e)
        {
            if (IsCategoryOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmCategory().Show();
                IsCategoryOpened = true;
            }

        }

        private void _btnCashIn_Click(object sender, EventArgs e)
        {
            if (IsCashInOpened)
            {
                MessageBox.Show("Эта форма уже открыта");

            }
            else
            {
                new frmCashInBox().Show();
                IsCashInOpened = true;
            }

        }

        private void _btnCashOut_Click(object sender, EventArgs e)
        {
            
        }

        protected override void _refresh()
        {
            //not think
        }

        protected override void _clear()
        {
            //not think
        }
    }
}