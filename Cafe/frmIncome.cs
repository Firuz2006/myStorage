using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmIncome : Form
    {
        private readonly Income _incomeContext;
        public FrmIncome()
        {
            _incomeContext = new Income();
            InitializeComponent();
            _refresh();
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            _clear();
        }

        protected override void _clear()
        {
            _id = 0;
            _txtName.Clear();
        }

        protected override void _refresh()
        {
            _incomeContext.LoadData(dataGridView1);
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_id==0)
                _incomeContext.InsertData(_txtName.Text);
            else
                _incomeContext.UpdateData(_id,_txtName.Text);
            _refresh();
            _clear();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_id == 0) return;
            _incomeContext.DeleteData(_id);
            _refresh();
            _clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            _txtName.Text = row.Cells[1].Value.ToString();
        }
    }
}