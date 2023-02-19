using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Cafe.Class;
namespace Cafe
{
    public partial class frmProduct : Form
    {
        public bool newData;
        string fileName;
        public bool newImage;
        Product product;
        Category category;
        Unit unit;
        public frmProduct()
        {
            product = new Product();
            category = new Category();
            unit = new Unit();
            InitializeComponent();
        }

        private void clearData()
        {
            txtId.Clear();
            txtProduct.Clear();
            fileName = "";
            openImage.FileName = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newData = true;
            clearData();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            newData = true;
            product = new Product();
            product.LoadData(dgProduct);
            GetCategory();
            GetUnit();
        }

        private void GetCategory()
        {
            foreach (Item item in category.GetCategory())
            {
                cbCategory.Items.Add(item);
                cbCategory.DisplayMember = "Value";
            }
        }

        private void GetUnit()
        {
            foreach (Item item in unit.GetUnit())
            {
                cbUnit.Items.Add(item);
                cbUnit.DisplayMember = "Value";
            }
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
                int idProduct = Convert.ToInt32(txtId.Text);
                product.DeleteData(idProduct);
                product.LoadData(dgProduct);
                clearData();
            }
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            
            DialogResult Message;
            string SaveData = "";
            bool status;
            Item categoryItem = (Item)cbCategory.SelectedItem;
            Item unitItem = (Item)cbUnit.SelectedItem;
            

            if (newData)
            {
                Message = MessageBox.Show("Хотите добавить в базу?", "Informations", MessageBoxButtons.YesNo);
                if (Message == DialogResult.No)
                {
                    return;
                }
                product.InsertData(txtProduct.Text,categoryItem.Key,unitItem.Key);
                    // unitItem.Key, status, txtBarcode.Text);
            }
            else
            {
                product.UpdateData(int.Parse(txtId.Text),txtProduct.Text,categoryItem.Key,unitItem.Key);
            }


            product.LoadData(dgProduct);
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rows = dgProduct.Rows[e.RowIndex];
                txtId.Text = rows.Cells[0].Value.ToString();
                txtProduct.Text = rows.Cells[1].Value.ToString();
                cbCategory.Text = rows.Cells[2].Value.ToString();
                cbUnit.Text = rows.Cells[3].Value.ToString();

                // new data is false if textbox not null
                newData = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error:" + exception.Message.ToString());
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
