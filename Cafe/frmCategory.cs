using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmCategory : Form
    {
        private readonly Category _categoryContext;
        public FrmCategory()
        {
            InitializeComponent();
            _categoryContext = new Category();
            _refresh();
        }

        private void new_Click(object sender, EventArgs e)
        {
            _clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _categoryContext.InsertData(name.Text);
            }
            else
            {
                if (!string.IsNullOrEmpty(name.Text))
                {
                    _categoryContext.UpdateData(id:_id, name.Text);
                }
            }
            _refresh();
            _clear();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                return;
            }
            _categoryContext.DeleteData(_id);
            _refresh();
            _clear();
        }
        
        private void categoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = categoryDataGrid.Rows[e.RowIndex];
            _id= int.Parse(row.Cells[0].Value.ToString());
            name.Text = row.Cells[1].Value.ToString();   
        }

        protected override void _refresh()
        {
            _categoryContext.LoadData(categoryDataGrid);
        }

        protected override void _clear()
        {
            _id = 0;
            name.Text = "";
        }
    }
}