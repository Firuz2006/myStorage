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
    public partial class frmSale : Form
    {
        Category category;
        Product product;
        Point buttonCategorySize;
        TableCategory tableCategory;
        Table table;
        Sale sale;
        int idTable = -1;
        Control lastControl;
        public string numberRole = "DIGITS";

        public frmSale()
        {
            category = new Category();
            product = new Product();
            tableCategory = new TableCategory();
            table = new Table();
            sale = new Sale();
            InitializeComponent();
        }
        public void getCategory()
        {
            int height = pCategory.Height - 8;
            int xPosition = 4;
            buttonCategorySize.X = height;
            buttonCategorySize.Y = height;
            List<Item> lstCategory = category.GetCategory();
            foreach (Item item in lstCategory)
            {
                Button newButton = new Button();
                newButton.Height = height;
                newButton.Width = height;
                newButton.TextAlign = ContentAlignment.BottomCenter;
                newButton.Location = new Point(xPosition, 4);
                xPosition += height + 4;

                newButton.Text = item.Value;
                newButton.Parent = pCategory;

                newButton.BackgroundImageLayout = ImageLayout.Stretch;
                newButton.BackgroundImage = Image.FromFile(item.Image);
                newButton.ForeColor = Color.White;
                newButton.Font = new Font(this.Font, FontStyle.Bold);

                newButton.Name = item.Key.ToString();
                newButton.Click += new EventHandler(this.clickCategoryButton);
            }


        }

        public void clickCategoryButton(Object sender, EventArgs e)
        {
            Button newButtonCategory = (Button)sender;
            getProduct(Convert.ToInt32(newButtonCategory.Name));
        }

        public void getTableCategory()
        {
            List<Item> lstTableCategory = tableCategory.GetCategory();
            foreach (Item item in lstTableCategory)
            {
                tCTable.TabPages.Add(item.Key.ToString(), item.Value);

                List<Item> lstTable = table.GetTable(item.Key);
                int xPosition = 4;
                int height = tCTable.Height / 2 + 20;
                foreach (Item iTable in lstTable)
                {

                    Button newButton = new Button();
                    newButton.Height = height;
                    newButton.Width = height;
                    newButton.TextAlign = ContentAlignment.MiddleCenter;
                    newButton.Location = new Point(xPosition, 4);
                    xPosition += height + 4;

                    newButton.Text = iTable.Value;

                    newButton.Font = new Font(this.Font, FontStyle.Bold);

                    newButton.Name = iTable.Key.ToString();
                    newButton.Click += new EventHandler(this.clickTableButton);

                    tCTable.TabPages[item.Key.ToString()].Controls.Add(newButton);


                }
            }
        }

        private void clickTableButton(Object sender, EventArgs e)
        {
            Button newButton = (Button)sender;
            lblTable.Text = newButton.Text;
            this.idTable = Convert.ToInt32(newButton.Name);
            this.LoadSale(Convert.ToInt32(newButton.Name));
        }

        public void getProduct(int idCategory)
        {

            pProduct.Controls.Clear();
            int height = buttonCategorySize.X - 8;
            int yPosition = 4;
            List<Item> lstProduct = product.GetProduct(Convert.ToInt32(idCategory));
            foreach (Item item in lstProduct)
            {
                Button newButton = new Button();
                newButton.Height = height;
                newButton.Width = buttonCategorySize.Y;
                newButton.TextAlign = ContentAlignment.BottomCenter;
                // newButton.Location = new Point(4, yPosition);
                yPosition += height + 4;

                newButton.Text = item.Value;
                newButton.Name = item.Key.ToString();

                newButton.BackgroundImageLayout = ImageLayout.Stretch;
                newButton.BackgroundImage = Image.FromFile(item.Image);
                newButton.ForeColor = Color.White;
                newButton.Font = new Font(this.Font, FontStyle.Bold);

                newButton.Click += new EventHandler(this.addProductToDataGridView);

                pProduct.Controls.Add(newButton);
                pProduct.AutoScroll = true;

            }
        }


        public void addProductToDataGridView(Object sender, EventArgs e)
        {
            if (this.idTable >= 0)
            {
                Button newButton = (Button)sender;
                int productId = Convert.ToInt32(newButton.Name);

                IDictionary<string, string> productDictionary = product.GetProductById(productId);
                try
                {
                    double productPrice = Convert.ToDouble(productDictionary["productPrice"]);
                    bool existProduct = false;
                    foreach (DataGridViewRow row in dgProductList.Rows)
                    {
                        if (row.Cells[6].Value.ToString() == productDictionary["productId"])
                        {
                            sale.UpdateData(productPrice, Convert.ToDouble(row.Cells[1].Value) + 1, Convert.ToInt32(productDictionary["productId"]),
                            Convert.ToInt32(productDictionary["idUnit"]), frmLogin.IdUser, this.idTable, false, Convert.ToInt32(row.Cells[7].Value));

                            existProduct = true;
                            break;
                        }
                    }

                    if (!existProduct)
                    {
                        sale.InsertData(productPrice, 1, Convert.ToInt32(productDictionary["productId"]),
                            Convert.ToInt32(productDictionary["idUnit"]), frmLogin.IdUser, this.idTable, false);
                    }

                    this.LoadSale(this.idTable);
                }
                catch (Exception ex)
                {

                }

                lblProductTotalPrice.Text = this.getProductTotalPrice().ToString();
            }
        }

        public void LoadSale(int idTable)
        {
            try
            {
                dgProductList.Rows.Clear();
                MySqlDataReader reader = sale.GetSaleByTableId(idTable);
                while (reader.Read())
                {
                    dgProductList.Rows.Add(reader.GetString("product"),
                                            reader.GetString("count"),
                                            reader.GetString("unit"),
                                            reader.GetString("price"),
                                            Convert.ToDouble(reader.GetString("count")) * Convert.ToDouble(reader.GetString("price")),
                                            false,
                                            reader.GetString("idProduct"),
                                            reader.GetString("idSale"),
                                            reader.GetString("idUnit")
                                            );
                }
                sale.closeConnection();
            }
            catch (Exception ex)
            {

            }

        }

        public void deleteProductFromDataGridView(Object sender, EventArgs e)
        {
            while (hasChekedRow() >= 0)
            {
                int idSale = Convert.ToInt32(dgProductList.Rows[hasChekedRow()].Cells["idSale"].Value);
                sale.DeleteData(idSale);
                dgProductList.Rows.RemoveAt(hasChekedRow());
            }
        }

        public int hasChekedRow()
        {
            foreach (DataGridViewRow row in dgProductList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[5].Value))
                {
                    return row.Index;
                }
            }
            return -1;
        }

        public double getProductTotalPrice()
        {
            double totalPrice = 0.00;
            foreach (DataGridViewRow row in dgProductList.Rows)
            {
                totalPrice += Convert.ToDouble(row.Cells[4].Value);
            }

            return totalPrice;
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            getCategory();
            getTableCategory();
        }

        private void frmSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmLogin().Show();
        }

        private void dgProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateProductList()
        {
            try
            {
                DataGridViewRow row = dgProductList.Rows[dgProductList.CurrentRow.Index];
                row.Cells["productAmount"].Value =
                    Convert.ToDouble(row.Cells["productPrice"].Value) *
                    Convert.ToDouble(row.Cells["productCount"].Value);
                sale.UpdateData(Convert.ToDouble(row.Cells["productPrice"].Value), Convert.ToDouble(row.Cells["productCount"].Value), Convert.ToInt32(row.Cells["id"].Value),
                            Convert.ToInt32(row.Cells["idUnit"].Value), frmLogin.IdUser, this.idTable, false, Convert.ToInt32(row.Cells["idSale"].Value));
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
            lblProductTotalPrice.Text = this.getProductTotalPrice().ToString();
        }

        private void dgProductList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.updateProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.deleteProductFromDataGridView(sender, e);
            lblProductTotalPrice.Text = this.getProductTotalPrice().ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            this.dgProductList.CurrentCell.Value = 10;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bool isFocused = false;

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

            //   MessageBox.Show(ActiveControl.GetType().ToString());
        }

        private void dgProductList_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lastControl = this.dgProductList;
        }

        private void txtNumkey_MouseClick(object sender, MouseEventArgs e)
        {
            lastControl = this.txtValue;
        }

        private void numpudButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button) sender;
                if (this.lastControl is DataGridView)
                {
                    DataGridView dg = (DataGridView) lastControl; 

                    int dotStart = dg.CurrentCell.Value.ToString().IndexOf('.'); 
                    if ((dotStart > -1 && btn.Text.Trim() != "." ) || (dotStart < 0))
                    {
                       dg.CurrentCell.Value += btn.Text;
                    }
                    
                }
                else if (this.lastControl is TextBox)
                {
                    int dotStart = lastControl.Text.IndexOf('.');
                    if ((dotStart > -1 && btn.Text.Trim() != ".") || (dotStart < 0))
                    {
                        if (numberRole == "DIGITS")
                        {
                            lastControl.Text += btn.Text;
                        }
                        else
                        {
                            MakeAmount(btn.Text);
                        }
                    }
                }
                this.updateProductList();
            }
            catch (Exception ex)
            {

            }
        }

        private void MakeAmount(string amountTxt)
        {
            decimal meanWhile;
            txtValue.Text = txtValue.Text + amountTxt;
            if (txtValue.Text.Length == 1)
            {
                txtValue.Text = "0.0" + txtValue.Text;
            }

            if (txtValue.Text.Length > 4)
            {
                meanWhile = Convert.ToDecimal(txtValue.Text) * 10;
                txtValue.Text = meanWhile.ToString("G29");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            decimal meanWhile;
            string control = null;

            if (lastControl is DataGridView)
            {
                DataGridView dg = (DataGridView)lastControl;
                control = dg.CurrentCell.Value.ToString();
            }
            else if (lastControl is TextBox)
            {
                TextBox txtBox = (TextBox)lastControl;
                control = txtBox.Text;
            }

            if (numberRole == "DIGITS")
            {
                control = control + "0";
            }
            else
            {
                control = control + "0";
                if (control.Length == 1)
                {
                    control = "0.0" + control;
                }
                if (control.Length >= 4)
                {
                    meanWhile = Convert.ToDecimal(control) * 10;
                    control = meanWhile.ToString("G29");
                }
                if (Convert.ToDecimal(control) < 1)
                {
                    control = control + "0";
                }
                if (control.IndexOf(".") < 0)
                {
                    control = control + ".00";
                }
                if (Convert.ToDecimal(control) > 1 && (control.Length - control.IndexOf(".") - 1 == 1))
                {
                    control = control + "0";
                }
            }

            if (lastControl is DataGridView)
            {
                DataGridView dg = (DataGridView)lastControl;
                dg.CurrentCell.Value = control;
            }
            else if (lastControl is TextBox)
            {
                TextBox txtBox = (TextBox)lastControl;
                txtBox.Text = control;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (this.lastControl is DataGridView)
            {
                DataGridView dg = (DataGridView)lastControl;
                string dgValue = dg.CurrentCell.Value.ToString();
                if(dgValue.Length > 0)
                    dg.CurrentCell.Value = dgValue.Substring(0, dgValue.Length - 1).TrimEnd('.');
            }
            else if (this.lastControl is TextBox)
            {
                TextBox txtBox = (TextBox)lastControl;
                string tbValue = txtBox.Text;
                if(tbValue.Length > 0)
                    txtBox.Text = tbValue.Substring(0, tbValue.Length - 1).TrimEnd('.');
            }


            this.updateProductList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadSale(this.idTable);
        }

        private void dgProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lastControl = this.dgProductList;
            this.updateProductList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.updateProductList();
        }
    }
}
