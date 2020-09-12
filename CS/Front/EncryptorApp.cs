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
            if(txtKeyEncrypt.Text.Equals(""))
            {
                MessageBox.Show("Key cannot be empty.");
                return;
            }

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ? 
                    openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyEncrypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] encFile = CryptographyControl.Encrypt(bFile, key, CryptographyControl.DefaultInitVector(16));

                    var name = openFileDialog.FileNames[0].Split('\\');
                    saveFileDialog.FileName = name[name.Length-1] + ".encrypted";

                    dr = saveFileDialog.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        path = saveFileDialog.FileNames.Length > 0 ?
                            saveFileDialog.FileNames[0] : null;
                        if (path != null)
                            File.WriteAllBytes(path, encFile);
                    }
                }
            }
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            if (txtKeyDecrypt.Text.Equals(""))
            {
                MessageBox.Show("Key cannot be empty.");
                return;
            }

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ?
                    openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyDecrypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] decFile = CryptographyControl.Decrypt(bFile, key, CryptographyControl.DefaultInitVector(16));

                    File.WriteAllBytes(path, decFile);
                    var names = openFileDialog.FileNames[0].Split('\\');
                    var name = names[names.Length - 1];

                    if (name.Length > 10 && name.Substring(name.Length - 10).Equals(".encrypted"))
                        saveFileDialog.FileName = name.Substring(0, name.Length - 10);
                    else
                        saveFileDialog.FileName = name;

                    dr = saveFileDialog.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        path = saveFileDialog.FileNames.Length > 0 ?
                            saveFileDialog.FileNames[0] : null;
                        if (path != null)
                            File.WriteAllBytes(path, decFile);
                    }
                }
            }
        }

        private void ShowEncryptKey(object sender, EventArgs e)
        {
            if (cbShowKeyEncrypt.Checked)
                txtKeyEncrypt.UseSystemPasswordChar = false;
            else
                txtKeyEncrypt.UseSystemPasswordChar = true;
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
