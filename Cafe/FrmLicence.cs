using System;
using System.Windows.Forms;

namespace Cafe
{
    public partial class FrmLicence : Form
    {
        private readonly Licence _licence = new Licence();
        public FrmLicence()
        {
            InitializeComponent();
            if (_licence.CheckLicence())
            {
                new FrmMain().Show();
                Close();
            }
            _lbCpuId.Text = _licence.CPUId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_licence.CreateLicence(_txtLicence.Text)) return;
            new FrmMain().Show();
            Close();
        }
    }
}