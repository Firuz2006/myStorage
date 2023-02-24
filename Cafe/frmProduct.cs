using System;
using System.Linq;
using System.Windows.Forms;
using Cafe.Class;
namespace Cafe
{
    public partial class FrmProduct : Form
    {
        private readonly Product _productContext;
        private readonly Category _categoryContext;
        private readonly Unit _unitContext;
        public FrmProduct()
        {
            _productContext = new Product();
            _categoryContext=new Category();
            _unitContext=new Unit();
            InitializeComponent();
            _refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)=>_clear();
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_id==0)return;
            _productContext.DeleteData(_id);
            _productContext.LoadData(dgProduct);
            _clear();
            _refresh();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            var categoryItem = (Item)cbCategory.SelectedItem;
            var unitItem = (Item)cbUnit.SelectedItem;
            
            if (_id==0)
                _productContext.InsertData(txtProduct.Text,categoryItem.Key,unitItem.Key);
            else
                _productContext.UpdateData(_id,txtProduct.Text,categoryItem.Key,unitItem.Key);
            
            _refresh();
            _clear();
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rows = dgProduct.Rows[e.RowIndex];
                _id = int.Parse(rows.Cells[0].Value.ToString());

                var product = _productContext.GetProductById(_id);
                int catId = int.Parse(product["idCategory"]),unitId=int.Parse(product["idUnit"]);
                
                txtProduct.Text = rows.Cells[1].Value.ToString();
                cbCategory.SelectedItem = cbCategory.Items.Cast<Item>().First(p=>p.Key==catId);
                
                cbUnit.SelectedItem = cbUnit.Items.Cast<Item>().First(p=>p.Key==unitId);;

            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Error:" + exception.Message);
            }
        }


        protected sealed override void _refresh()
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
            cbCategory.Text="";
            cbUnit.Text = "";
            _id = 0;
        }
    }
}
