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
    public partial class frmUnit : Form
    {
        Unit unit;
        bool newUnit;
        public frmUnit()
        {
            unit = new Unit();
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newUnit = true;
            clearData();
        }

        private void clearData()
        {
            txtId.Clear();
            txtUnit.Text = "";
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            if (newUnit)
            {
                unit.InsertData(txtUnit.Text);
            }
            else
            {
                unit.UpdateData(Convert.ToInt32(txtId.Text), txtUnit.Text);
            }

            unit.LoadData(dgUnit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Вы точно хотите удалить?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No)
            {
                return;
            }
            else
            {
                int idUnit = Convert.ToInt32(txtId.Text);
                unit.DeleteData(idUnit);
                unit.LoadData(dgUnit);
                clearData();
            }
        }

        private void dgUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newUnit = false;
            DataGridViewRow row = dgUnit.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtUnit.Text = row.Cells[1].Value.ToString();
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            newUnit = true;
            unit.LoadData(dgUnit);
        }
    }
}
