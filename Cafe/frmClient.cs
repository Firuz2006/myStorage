using System;
using Cafe.Class;

namespace Cafe
{
    public partial class frmClient : Form
    {
        private readonly Client _clientContext;
        
        public frmClient()
        {
            _clientContext = new Client();
            InitializeComponent();
        }

        protected override void _refresh()
        {
            _clientContext.LoadData(dataGridView1);
        }

        protected override void _clear()
        {
            _txtAddr.Text = "";
            _txtName.Text = "";
            _txtPhone.Text = "";
            _txtLName.Text = "";
            _id = 0;
        }

        private void _btnNew_Click(object sender, EventArgs e)
        {
            _clear();
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
            _clear();
        }

        private void _btnDelete_Click(object sender, EventArgs e)
        {
            if (_id==0)
            {
                return;
            }
            _clientContext.DeleteData(_id);
            _refresh();
        }
    }
}