using System;
using System.Linq;
using System.Windows.Forms;
using Cafe.Class;
using Cafe.Class.Cafe.Class;

namespace Cafe
{
    public partial class frmSale : Form
    {
        private readonly Firm _firmContext;
        private readonly Product _productContext;
        private readonly Storage _storageContext;
        private readonly Sale _saleContext;

        public frmSale()
        {
            _productContext = new Product();
            _saleContext = new Sale();
            _firmContext = new Firm();
            _storageContext = new Storage();
            InitializeComponent();
            _refresh();
        }

        protected override void _refresh()
        {
            _cbFirm.Items.Clear();
            _cbFirm.Items.AddRange(_firmContext.GetFirm().ToArray());
            
            _cbProduct.Items.Clear();
            _cbProduct.Items.AddRange(_productContext.GetProduct().ToArray());

            _cbStorage.Items.Clear();
            _cbStorage.Items.AddRange(_storageContext.GetStorage().ToArray());
            
            _saleContext.LoadData(dataGridView1);
        }

        protected override void _clear()
        {
            _txtQuantity.Text = "";
            _txtTJS.Text = "";
            _txtUSD.Text = "";
            _cbProduct.SelectedIndex = 0;
            _cbFirm.SelectedIndex = 0;
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            int idProduct = ((Item)_cbProduct.SelectedItem).Key,
                quantity = int.Parse(_txtQuantity.Text),
                idStorage = ((Item)_cbStorage.SelectedItem).Key;

            decimal USD = int.Parse(_txtUSD.Text),
                TJS = int.Parse(_txtTJS.Text);
            
            if (_id==0)
            {
                _saleContext.InsertData(idProduct,idStorage,quantity,USD,TJS,_isPayed.Checked);
            }
            else
            {
                _saleContext.UpdateData(_id,idProduct,idStorage,quantity,USD,TJS,_isPayed.Checked);
            }
            _refresh();
            _clear();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_id == 0) return;
            _saleContext.DeleteData(_id);
            _refresh();
            _clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            _txtQuantity.Text = row.Cells[2].Value.ToString();
            _txtTJS.Text = row.Cells[4].Value.ToString();
            _txtUSD.Text = row.Cells[3].Value.ToString();
            _cbProduct.SelectedItem=_cbProduct.Items.Cast<Item>().Single(p=>p.Key==int.Parse(row.Cells[1].Value.ToString()));
            _cbStorage.SelectedItem = _cbStorage.Items.Cast<Item>().Single(p=>p.Key==int.Parse(row.Cells[7].Value.ToString()));
            _isPayed.Checked = row.Cells[8].Value.ToString()=="1";
            _id = int.Parse(row.Cells[0].Value.ToString());
            
        }
    }
}