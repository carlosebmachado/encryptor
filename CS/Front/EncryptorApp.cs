using Encryptor.Back;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encryptor.Front
{
    public partial class EncryptorApp : Form
    {
        public EncryptorApp()
        {
            InitializeComponent();
        }

        private void EncryptClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ? 
                    openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyEncypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] encFile = CryptographyControl.Encrypt(bFile, key, CryptographyControl.DefaultInitVector(16));
                    File.WriteAllBytes(path + ".encrypted", encFile);
                }
            }
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ?
                    openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyDecrypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] decFile = CryptographyControl.Decrypt(bFile, key, CryptographyControl.DefaultInitVector(16));
                    File.WriteAllBytes(path.Substring(0, path.Length - 10), decFile);
                }
            }
        }

        private void ShowEncryptKey(object sender, EventArgs e)
        {
            if (cbShowKeyEncrypt.Checked)
                txtKeyEncypt.UseSystemPasswordChar = false;
            else
                txtKeyEncypt.UseSystemPasswordChar = true;
        }

        private void ShowDecryptKey(object sender, EventArgs e)
        {
            if (cbShowKeyDecrypt.Checked)
                txtKeyDecrypt.UseSystemPasswordChar = false;
            else
                txtKeyDecrypt.UseSystemPasswordChar = true;
        }
    }
}
