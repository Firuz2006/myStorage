using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmStorage : Form
    {
        private bool _isNew;
        private readonly Storage _storageContext;
        public frmStorage()
        {
            InitializeComponent();
            _storageContext = new Storage();
            refresh();
        }

        private void refresh()
        {
            _isNew = true;
            _storageContext.LoadData(storageDataGridView);
        }
        
        private void save_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                _storageContext.InsertData(name.Text,address.Text);
            }
            else
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    _storageContext.UpdateData(int.Parse(id.Text), name.Text,address.Text);
                }
            }
            refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                return;
            }
            _storageContext.DeleteData(int.Parse(id.Text));
            _isNew = true;
            refresh();
        }
        

        private void new_Click_1(object sender, EventArgs e)
        {
            _isNew = true;
            id.Text = "";
            name.Text = "";
            address.Text = "";
        }
        
        private void storageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isNew = false;
            var row = storageDataGridView.Rows[e.RowIndex];
            id.Text = row.Cells[0].Value.ToString();
            name.Text = row.Cells[1].Value.ToString();
            address.Text = row.Cells[2].Value.ToString();
        }
    }
}