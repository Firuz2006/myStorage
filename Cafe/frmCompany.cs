using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmCompany : Form
    {
        private readonly Firm _firmContext;
        private bool _newCompany;
        public frmCompany()
        {
            _firmContext = new Firm();
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _newCompany = true;
            clearData();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            _newCompany = true;
            _firmContext.LoadData(dgCompany);
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (_newCompany)
            {
                _firmContext.InsertData(txtCompany.Text,phone.Text,address.Text,info.Text);
            }
            else
            {
                _firmContext.UpdateData(int.Parse(txtId.Text), txtCompany.Text,phone.Text,address.Text,info.Text);
            }

            _firmContext.LoadData(dgCompany);
        }
        
        private void clearData()
        {
            txtId.Clear();
            txtCompany.Text = "";
            info.Text = "";
            address.Text = "";
            phone.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Вы точно хотите удалить?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No)
            {
                return;
            }
            int idCompany = Convert.ToInt32(txtId.Text);
            _firmContext.DeleteData(idCompany);
            _firmContext.LoadData(dgCompany);
            clearData();
        }

        private void dgCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _newCompany = false;
            DataGridViewRow row = dgCompany.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtCompany.Text = row.Cells[1].Value.ToString();
            phone.Text = row.Cells[2].Value.ToString();
            address.Text = row.Cells[3].Value.ToString();
            info.Text = row.Cells[4].Value.ToString();
        }
    }
}
