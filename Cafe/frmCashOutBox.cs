using System;
using System.Linq;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmCashOutBox : Form
    {
        private readonly CashOutBox _cashOutBoxContext;
        private readonly Storage _storageContext;
        private readonly Expense _expenseContext;
        private readonly Class.Rate _rateContext;

        public FrmCashOutBox()
        {
            _rateContext = new Class.Rate();
            _cashOutBoxContext = new CashOutBox();
            _storageContext = new Storage();
            _expenseContext = new Expense();
               
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
            _cashOutBoxContext.LoadData(dataGridView1);
            
            _cbStorage.Items.Clear();
            _cbStorage.Items.AddRange(_storageContext.GetStorage().ToArray());
            
            _cbExpense.Items.Clear();
            _cbExpense.Items.AddRange(_expenseContext.GetExpense().ToArray());
        }

        protected override void _clear()
        {
            _id = 0;
            _txtTJS.Clear();
            _txtUSD.Clear();
            _cbExpense.Text = "";
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
                _cashOutBoxContext.InsertData(((Item)_cbStorage.SelectedItem).Key, _txtUSD.Text, _txtTJS.Text,
                    ((Item)_cbExpense.SelectedItem).Key);
            }
            else
            {
                _cashOutBoxContext.UpdateData(_id, ((Item)_cbStorage.SelectedItem).Key, _txtUSD.Text, _txtTJS.Text,
                    ((Item)_cbExpense.SelectedItem).Key);
            }
            _clear();
            _refresh();
           
        }

        private void _btnDelete_Click_1(object sender, EventArgs e)
        {
            if (_id == 0) return;
            _cashOutBoxContext.DeleteData(_id);
            _clear();
            _refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            _txtUSD.Text = row.Cells[2].Value.ToString();
            _txtTJS.Text = row.Cells[3].Value.ToString();
            
            var outbox = _cashOutBoxContext.GetById(_id);
            _cbExpense.SelectedItem = _cbExpense.Items.Cast<Item>().Single(p => p.Key == outbox["idExpense"]);
            _cbStorage.SelectedItem = _cbStorage.Items.Cast<Item>().Single(p => p.Key == outbox["idStorage"]);
        }
    }
}