using System;
using System.Windows.Forms;

namespace Cafe
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {   
            Console.Beep();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
         //   Application.Run(new numberpad());

        }
    }
}
