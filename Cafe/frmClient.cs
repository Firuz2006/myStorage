using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe
{
    public partial class frmClient : Form
    {
        private int _id;

        private readonly Client _clientContext;
            
        public frmClient()
        {
            _clientContext = new Client();
            InitializeComponent();
        }

        private void _refresh()
        {
            _clientContext.LoadData(dataGridView1);
        }
        private void _btnNew_Click(object sender, EventArgs e)
        {
            _txtAddr.Text = "";
            _txtName.Text = "";
            _txtPhone.Text = "";
            _txtLName.Text = "";
            _id = 0;
            _refresh();
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                _clientContext.InsertData(_txtName.Text,_txtLName.Text,_txtPhone.Text,_txtAddr.Text);
            }
            else
            {
                _clientContext.UpdateData(_id,_txtName.Text,_txtLName.Text,_txtPhone.Text,_txtAddr.Text);
            }
            _refresh();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                return;
            }
            _clientContext.DeleteData(_id);
            
        }
    }
}