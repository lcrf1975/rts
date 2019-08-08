using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace KeyGen
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "@Omnitracs";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            label_Key_Value.Text = Encrypt(dateTimePicker_Date.Value.ToString());
            Clipboard.SetText(label_Key_Value.Text);
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            DateTime TODAY = DateTime.Today;
            dateTimePicker_Date.Value = TODAY;
            dateTimePicker_Date.Value = dateTimePicker_Date.Value.AddDays(30);
        }
    }
}
