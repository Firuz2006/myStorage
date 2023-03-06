using System;
using System.Drawing;
using Cafe.Class;
using Cafe.Class.Cafe.Class;

namespace Cafe;

public sealed partial class FrmSale : Form
{
    private readonly Invoice _invoiceContext;
    private readonly Sale _saleContext;
    private readonly Category _categoryContext;
    private readonly Client _clientContext;
    private int _product;
    private int _storage;
    private bool _isPayed;
    private bool _isNew;

   public FrmSale()
   {
       _clientContext = new Client();
        _invoiceContext = new Invoice();
        _saleContext = new Sale();
        _categoryContext = new Category();
        InitializeComponent();
        _refresh();
        _txtSale.KeyPress += TextBoxDoubleValidation;
        _txtTJS.KeyPress += TextBoxDoubleValidation;
        _txtUSD.KeyPress += TextBoxDoubleValidation;
        _isNew = true;

        _btnSubmit.Enabled = false;
    }

    protected override void _refresh()
    {
        // ReSharper disable once CoVariantArrayConversion
        listBox1.Items.AddRange(_categoryContext.GetCategory().ToArray());
        _saleContext.LoadData(dataGridView1);
        _cbClient.Items.AddRange(_clientContext.GetClient().ToArray());
    }


    protected override void _clear()
    {
        _isNew = true;
        _product = 0;
        _storage = 0;
        _txtSale.Text = "";
        _txtQuantityHas.Text = "";
        _txtQuantitySale.Text = "";
        _txtTJS.Text = "";
        _txtUSD.Text = "";
        _cbClient.SelectedItem = null;
        _cbClient.Text = "";
    }

    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
        _clear();
        var catId = ((Item)listBox1.SelectedItem).Key;
        var selFrm = new FrmProdSelect(catId);
        selFrm.Show();
        Enabled = false;

        selFrm.Selected += id =>
        {
            Enabled = true;
            var invoice = _invoiceContext.GetById(id);

            _txtSale.Text = invoice["sale"];
            _txtTJS.Text = invoice["tjs"];
            _txtUSD.Text = invoice["usd"];

            _isPayed = invoice["isPayed"] == "1";
            if (_isPayed)
            {
                _lbIsPayed.Text = @"Да";
                _lbIsPayed.BackColor = Color.Green;
            }
            else
            {
                _lbIsPayed.Text = @"Нет";
                _lbIsPayed.BackColor = Color.Red;
            }

            _txtQuantityHas.Text = invoice["quantity"];
            _txtQuantitySale.Text = _txtQuantityHas.Text;

            _product = int.Parse(invoice["product"]);
            _storage = int.Parse(invoice["storage"]);
            _btnSubmit.Enabled = true;
            _isNew = false;
        };

        selFrm.Cancel += () => Enabled = true;
    }

    private void _btnSubmit_Click(object sender, EventArgs e)
    {
        if (_isNew) return;
        var clientId = ((Item)_cbClient.SelectedValue).Key;
        _saleContext.InsertData(_product, _storage, clientId, int.Parse(_txtQuantitySale.Text),
            decimal.Parse(_txtUSD.Text), decimal.Parse(_txtTJS.Text), _isPayed);
        _clear();
        _refresh();
    }
}