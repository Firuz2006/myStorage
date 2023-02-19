using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmInvoice : Form
    {
        private bool _isNew=true;
        private readonly Product _productContext;
        private readonly Firm _firmContext;
        private readonly Invoice _invoiceContext;
        private readonly Storage _storageContext;
        
        public frmInvoice()
        {
            _productContext = new Product();
            _invoiceContext = new Invoice();
            _firmContext = new Firm();
            _storageContext = new Storage();
            InitializeComponent();
            _refresh();
        }

        private void _refresh()
        {
            _cbFirm.Items.Clear();
            _cbFirm.Items.AddRange(_firmContext.GetFirm().ToArray());
            
            _cbProduct.Items.Clear();
            _cbProduct.Items.AddRange(_productContext.GetProduct().ToArray());

            _cbStorage.Items.Clear();
            _cbStorage.Items.AddRange(_storageContext.GetStorage().ToArray());
            
            _invoiceContext.LoadData(dataGridView1);
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            _txtQuantity.Text = "";
            _txtSale.Text = "";
            _txtTJS.Text = "";
            _txtUSD.Text = "";
            _cbProduct.SelectedIndex = 0;
            _cbFirm.SelectedIndex = 0;
            _isPayed.Checked = false;
            id.Text = "";
            _refresh();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            int idFirm = ((Item)_cbFirm.SelectedItem).Key,
                idProduct = ((Item)_cbProduct.SelectedItem).Key,
                quantity = int.Parse(_txtQuantity.Text),
                idStorage = ((Item)_cbStorage.SelectedItem).Key;

            decimal USD = int.Parse(_txtUSD.Text),
                TJS = int.Parse(_txtTJS.Text),
                salePrice = int.Parse(_txtSale.Text);
            
            if (_isNew)
            {
                _invoiceContext.InsertData(idFirm,idProduct,idStorage,quantity,USD,TJS,salePrice,_isPayed.Checked);
            }
            else
            {
                _invoiceContext.UpdateData(int.Parse(id.Text),idFirm,idProduct,idStorage,quantity,USD,TJS,salePrice,_isPayed.Checked);
            }
            _refresh();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                return;
            }
            _invoiceContext.DeleteData(int.Parse(id.Text));
            _refresh();
        }
    }
}