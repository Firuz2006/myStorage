﻿using System;
using System.Windows.Forms;

namespace Cafe
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSale());
         //   Application.Run(new numberpad());

        }
    }
}
