using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cafe.Class;
namespace Cafe
{
    public partial class frmAdmin :Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmLogin().Show();  
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmCategory().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // new frmInvoice().Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            new frmProduct().Show();
        }
    }
}
