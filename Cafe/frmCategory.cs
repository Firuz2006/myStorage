using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmCategory : Form
    {
        private bool _isNew;
        private readonly Category _categoryContext;
        public frmCategory()
        {
            InitializeComponent();
            _categoryContext = new Category();
            refresh();
        }

        private void refresh()
        {
            _isNew = true;
            _categoryContext.LoadData(categoryDataGrid);
        }
        private void new_Click(object sender, EventArgs e)
        {
            _isNew = true;
            id.Visible = false;
            label1.Visible = false;
            id.Text = "";
            name.Text = "";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                _categoryContext.InsertData(name.Text);
            }
            else
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    _categoryContext.UpdateData(int.Parse(id.Text), name.Text);
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
            _categoryContext.DeleteData(int.Parse(id.Text));
            _isNew = true;
            refresh();
        }
        
        private void categoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _isNew = false;
            var row = categoryDataGrid.Rows[e.RowIndex];
            id.Text = row.Cells[0].Value.ToString();
            name.Text = row.Cells[1].Value.ToString();   
        }
        
    }
}