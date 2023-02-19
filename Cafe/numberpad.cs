using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paypi
{
    public partial class numberpad : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        public string numberRole = "MONEY";
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public numberpad()
        {
            InitializeComponent();
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

        private void num1_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "1";
            }
            else
                MakeAmount(num1.Text);
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "2";
            }
            else
                MakeAmount(num2.Text);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "3";
            }
            else
                MakeAmount(num3.Text);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "4";
            }
            else
                MakeAmount(num4.Text);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "5";
            }
            else
                MakeAmount(num5.Text);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "6";
            }
            else
                MakeAmount(num6.Text);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "7";
            }
            else
                MakeAmount(num7.Text);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "8";
            }
            else
                MakeAmount(num8.Text);
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "9";
            }
            else
                MakeAmount(num9.Text);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            decimal meanWhile;
            if (numberRole == "DIGITS")
            {
                txtValue.Text = txtValue.Text + "0";
            }
            else
            {
                txtValue.Text = txtValue.Text + "0";
                if (txtValue.Text.Length == 1)
                {
                    txtValue.Text = "0.0" + txtValue.Text;
                }
                if (txtValue.Text.Length >= 4)
                {
                    meanWhile = Convert.ToDecimal(txtValue.Text) * 10;
                    txtValue.Text = meanWhile.ToString("G29");
                }
                if (Convert.ToDecimal(txtValue.Text) < 1)
                {
                    txtValue.Text = txtValue.Text + "0";
                }
                if (txtValue.Text.IndexOf(".") < 0)
                {
                    txtValue.Text = txtValue.Text + ".00";
                }
                if (Convert.ToDecimal(txtValue.Text) > 1 && (txtValue.Text.Length - txtValue.Text.IndexOf(".") - 1 == 1))
                {
                    txtValue.Text = txtValue.Text + "0";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtValue.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          //  LanguageSettings.fromKeyPad = txtValue.Text;
            Close();
        }
    }
}
