using System;
using System.Linq;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmCashInBox : Form
    {
        private readonly CashInBox _cashInBoxContext;
        private readonly Storage _storageContext;
        private readonly Income _incomeContext;
        private readonly Class.Rate _rateContext;

        public FrmCashInBox()
        {
            _rateContext = new Class.Rate();
            _cashInBoxContext = new CashInBox();
            _storageContext = new Storage();
            _incomeContext = new Income();
               
            InitializeComponent();
            _refresh();
            _txtUSD.KeyPress += TextBoxDoubleValidation;
            _txtTJS.KeyPress += TextBoxDoubleValidation;
        }

        protected override void _refresh()
        {
            var rate=_rateContext.GetLastRate();
            _txtTJS.Text = rate.Key.ToString();
            _txtUSD.Text = rate.Value.ToString();
            _cashInBoxContext.LoadData(dataGridView1);
            
            _cbStorage.Items.Clear();
            _cbStorage.Items.AddRange(_storageContext.GetStorage().ToArray());
            
            _cbIncome.Items.Clear();
            _cbIncome.Items.AddRange(_incomeContext.GetIncome().ToArray());
        }

        protected override void _clear()
        {
            _id = 0;
            _txtTJS.Clear();
            _txtUSD.Clear();
            _cbIncome.Text = "";
            _cbStorage.Text = "";
        }


        private void _btnNew_Click_1(object sender, EventArgs e)
        {
            _clear();
            _refresh();
        }


        private void _btnSave_Click_1(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _cashInBoxContext.InsertData(((Item)_cbStorage.SelectedItem).Key,_txtUSD.Text,_txtTJS.Text,((Item)_cbIncome.SelectedItem).Key);
            }
            else
            {
                _cashInBoxContext.UpdateData(_id,((Item)_cbStorage.SelectedItem).Key,_txtUSD.Text,_txtTJS.Text,((Item)_cbIncome.SelectedItem).Key);
            }
            _clear();
            _refresh();
        }

        private void _btnDelete_Click_1(object sender, EventArgs e)
        {
            if (_id == 0) return;
            _cashInBoxContext.DeleteData(_id);
            _clear();
            _refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var row = dataGridView1.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            _txtUSD.Text = row.Cells[2].Value.ToString();
            _txtTJS.Text = row.Cells[3].Value.ToString();
            
            var inbox = _cashInBoxContext.GetById(_id);
            _cbIncome.SelectedItem = _cbIncome.Items.Cast<Item>().Single(p=>p.Key==inbox["idIncome"]);
            _cbStorage.SelectedItem = _cbStorage.Items.Cast<Item>()
                .Single(p => p.Key == inbox["idStorage"]);
            
        }
    }
}