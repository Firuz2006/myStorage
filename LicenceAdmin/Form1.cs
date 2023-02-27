using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string EncryptData(string textData, string Encryptionkey)  
        {  
            RijndaelManaged objrij = new RijndaelManaged();  
            objrij.Mode = CipherMode.CBC;  
            objrij.Padding = PaddingMode.PKCS7;  
            objrij.KeySize = 0x80;  
            objrij.BlockSize = 0x80;  

            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);  
            byte[] EncryptionkeyBytes ={ 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };  
  
            int len = passBytes.Length;  
            if (len > EncryptionkeyBytes.Length)  
            {  
                len = EncryptionkeyBytes.Length;  
            }  
            Array.Copy(passBytes, EncryptionkeyBytes, len);  
  
            objrij.Key = EncryptionkeyBytes;  
            objrij.IV = EncryptionkeyBytes;  
  
            ICryptoTransform objtransform = objrij.CreateEncryptor();  
            byte[] textDataByte = Encoding.UTF8.GetBytes(textData);  
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));  
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = EncryptData(textBox1.Text, "84D34188-BB71-4379-B403-3F816E0B350E");
        }
    }
}