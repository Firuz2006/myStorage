using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Rate : Form
    {
        private readonly Cafe.Class.Rate _rate;
        public Rate()
        {
            _rate = new Cafe.Class.Rate();
            InitializeComponent();
            _refresh();
        }

        private void _refresh()
        {
            _rate.LoadData(dataGridView1);
        }
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            _rate.InsertData(decimal.Parse(_txtUSD.Text),decimal.Parse(_txtTJS.Text));
            _refresh();
        }
    }
}