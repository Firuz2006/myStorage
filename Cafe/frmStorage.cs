using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmStorage : Form
    {
        private readonly Storage _storageContext;
        public FrmStorage()
        {
            InitializeComponent();
            _storageContext = new Storage();
            _refresh();
        }

        
        private void save_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _storageContext.InsertData(name.Text,address.Text);
            }
            else
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    _storageContext.UpdateData(_id, name.Text,address.Text);
                }
            }
            _refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                return;
            }
            _storageContext.DeleteData(_id);
            _id = 0;
            _refresh();
            _clear();
        }
        

        private void new_Click_1(object sender, EventArgs e)
        {
            _clear();
        }
        
        private void storageDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = storageDataGridView.Rows[e.RowIndex];
            _id = int.Parse(row.Cells[0].Value.ToString());
            name.Text = row.Cells[1].Value.ToString();
            address.Text = row.Cells[2].Value.ToString();
        }

        protected override void _refresh()
        {
            _storageContext.LoadData(storageDataGridView);
        }

        protected override void _clear()
        {
            _id = 0;
            name.Text = "";
            address.Text = "";
        }
    }
}