using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmCompany : Form
    {
        private readonly Firm _firmContext;
        public FrmCompany()
        {
            _firmContext = new Firm();
            InitializeComponent();
            _refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _clear();
        }


        private void bntSave_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _firmContext.InsertData(txtCompany.Text,phone.Text,address.Text,info.Text);
            }
            else
            {
                _firmContext.UpdateData(_id, txtCompany.Text,phone.Text,address.Text,info.Text);
            }

            _firmContext.LoadData(dgCompany);
            _refresh();_clear();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Вы точно хотите удалить?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No)
            {
                return;
            }
            
            _firmContext.DeleteData(_id);
            _firmContext.LoadData(dgCompany);
            _clear();
        }

        private void dgCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgCompany.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            txtCompany.Text = row.Cells[1].Value.ToString();
            phone.Text = row.Cells[2].Value.ToString();
            address.Text = row.Cells[3].Value.ToString();
            info.Text = row.Cells[4].Value.ToString();
        }

        protected override void _refresh()
        {
            _firmContext.LoadData(dgCompany);
        }

        protected override void _clear()
        {
            _id = 0;
            txtCompany.Text = "";
            info.Text = "";
            address.Text = "";
            phone.Text = "";
        }
    }
}
