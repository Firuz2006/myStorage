using System;
using System.Windows.Forms;
using Cafe.Class;

namespace Cafe;

public partial class FrmClient : Form
{
    private readonly Client _clientContext;
        
    public FrmClient()
    {
        _clientContext = new Client();
        InitializeComponent();
        _refresh();
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

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var row = dataGridView1.Rows[e.RowIndex];
        _txtAddr.Text =row.Cells[4].Value.ToString();
        _txtName.Text = row.Cells[1].Value.ToString();
        _txtPhone.Text = row.Cells[3].Value.ToString();
        _txtLName.Text = row.Cells[2].Value.ToString();
        _id = int.Parse(row.Cells[0].Value.ToString());
    }
}