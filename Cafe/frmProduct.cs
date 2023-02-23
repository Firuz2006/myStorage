using System;
using System.Windows.Forms;
using Cafe.Class;
namespace Cafe
{
    public partial class frmProduct : Form
    {
        private readonly Product _productContext;
        private readonly Category _categoryContext;
        private readonly Unit _unitContext;
        public frmProduct()
        {
            _productContext = new Product();
            _categoryContext=new Category();
            _unitContext=new Unit();
            InitializeComponent();
            _refresh();
        }

        private void clearData()
        {
            txtProduct.Clear();
            openImage.FileName = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Message;
            Message = MessageBox.Show("Вы точно хотите удалить?", "Warning", MessageBoxButtons.YesNo);
            if (Message == DialogResult.No)
            {
                return;
            }
            _productContext.DeleteData(_id);
            _productContext.LoadData(dgProduct);
            clearData();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            
            DialogResult Message;
            string SaveData = "";
            Item categoryItem = (Item)cbCategory.SelectedItem;
            Item unitItem = (Item)cbUnit.SelectedItem;
            

            if (_id==0)
            {
                Message = MessageBox.Show("Хотите добавить в базу?", "Informations", MessageBoxButtons.YesNo);
                if (Message == DialogResult.No)
                {
                    return;
                }
                _productContext.InsertData(txtProduct.Text,categoryItem.Key,unitItem.Key);
                    // unitItem.Key, status, txtBarcode.Text);
            }
            else
            {
                _productContext.UpdateData(_id,txtProduct.Text,categoryItem.Key,unitItem.Key);
            }


            
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = dgProduct.Rows[e.RowIndex];
                _id = int.Parse(rows.Cells[0].Value.ToString());
                txtProduct.Text = rows.Cells[1].Value.ToString();
                cbCategory.Text = rows.Cells[2].Value.ToString();
                cbUnit.Text = rows.Cells[3].Value.ToString();

                // new data is false if textBox not null
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message.ToString());
            }
        }


        protected override void _refresh()
        {
            _productContext.LoadData(dgProduct);
            
            cbCategory.Items.Clear();
            cbCategory.Items.AddRange(_categoryContext.GetCategory().ToArray());
            
            cbUnit.Items.Clear();
            cbUnit.Items.AddRange(_unitContext.GetUnit().ToArray());
        }

        protected override void _clear()
        {
            txtProduct.Clear();
        }
    }
}
