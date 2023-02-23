using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmUnit : Form
    {
        private readonly Unit _unit;
        public frmUnit()
        {
            _unit = new Unit();
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _unit.InsertData(txtUnit.Text);
            }
            else
            {
                _unit.UpdateData(_id, txtUnit.Text);
            }

            _unit.LoadData(dgUnit);
            _refresh();
            _clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Message = MessageBox.Show("Вы точно хотите удалить?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No)
            {
                return;
            }
            _unit.DeleteData(_id);
            _clear();
            _refresh();
        }

        private void dgUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgUnit.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            txtUnit.Text = row.Cells[1].Value.ToString();
        }


        protected override void _refresh()
        {
            _unit.LoadData(dgUnit);
        }

        protected override void _clear()
        {
            _id = 0;
            txtUnit.Text = "";
        }
    }
}
