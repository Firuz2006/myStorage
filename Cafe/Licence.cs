using System;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace Cafe
{
    internal class Licence
    {
        private string _encryptData(string strData,string strKey)
        
        {
                RijndaelManaged objrij = new RijndaelManaged();  
                objrij.Mode = CipherMode.CBC;  
                objrij.Padding = PaddingMode.PKCS7;  
                objrij.KeySize = 0x80;  
                objrij.BlockSize = 0x80;  

                byte[] passBytes = Encoding.UTF8.GetBytes(strKey);  
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
                byte[] textDataByte = Encoding.UTF8.GetBytes(strData);  
            var f=Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
            return f;
        }
       

        public readonly string CPUId;
        private readonly RegistryKey _user;
        
        public Licence()
        {
            _user = Registry.CurrentUser;
            CPUId = GetCPUId();
        }
        private string GetCPUId()
        {
            var cpuID = string.Empty;
            var mc = new ManagementClass("win32_processor");
            var moc = mc.GetInstances();
            
            foreach (ManagementObject mo in moc)
                if (cpuID == "")
                    cpuID = mo.Properties["processorID"].Value.ToString();
            
            return cpuID;
        }
        internal bool CheckLicence()
        {
            
            if (_user.GetSubKeyNames().SingleOrDefault(p => p == "optLicence") == null) return false;
            
            var licence = _user.GetValue("optLicence").ToString();
            var cpuLicence = _encryptData(CPUId, "84D34188-BB71-4379-B403-3F816E0B350E");
            return licence == cpuLicence;
        }

        internal bool CreateLicence(string licence)
        {
            if (CheckLicence()) return true;
            if (_encryptData(CPUId, "84D34188-BB71-4379-B403-3F816E0B350E") !=licence) return false;
            
            var opt = _user.CreateSubKey("optLicence");
            opt.SetValue("optLicence",licence);
            
            return true;
        }
    }
}