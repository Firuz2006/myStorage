using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class FrmProdSelect : Form
    {
        private readonly Category _categoryContext=new(); 
        private readonly Product _productContext=new();
        private readonly int _categoryId;

        public event _Selected Selected;
        public delegate void _Selected(int id);

        public delegate void cancel();

        public event cancel Cancel;

        public FrmProdSelect(int catId)
        {
            _categoryId = catId;
            InitializeComponent();
            _refresh();
            
        }
        
        protected override void _refresh()
        {
            _productContext.LoadDataByCategory(dataGridView1,_categoryId);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(a);
            Selected.Invoke(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            Cancel.Invoke();
        }
    }
}