using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encryptor
{
    public partial class EncryptorForm : Form
    {
        public EncryptorForm()
        {
            InitializeComponent();
        }

        private void EncryptClick(object sender, EventArgs e)
        {
            if (KeyIsNullOrEmpty(txtKeyEncrypt.Text))
            {
                return;
            }

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ? openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyEncrypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] encFile = Cryptography.Encrypt(bFile, key, Cryptography.DefaultInitVector(16));

                    var name = openFileDialog.FileNames[0].Split('\\');
                    saveFileDialog.FileName = name[name.Length - 1] + ".encrypted";

                    dr = saveFileDialog.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        path = saveFileDialog.FileNames.Length > 0 ? saveFileDialog.FileNames[0] : null;
                        if (path != null)
                        {
                            File.WriteAllBytes(path, encFile);
                        }
                    }
                }
            }
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            if (KeyIsNullOrEmpty(txtKeyDecrypt.Text))
            {
                return;
            }

            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var path = openFileDialog.FileNames.Length > 0 ? openFileDialog.FileNames[0] : null;
                if (path != null)
                {
                    byte[] key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(txtKeyDecrypt.Text));
                    byte[] bFile = File.ReadAllBytes(path);
                    byte[] decFile = Cryptography.Decrypt(bFile, key, Cryptography.DefaultInitVector(16));

                    if (decFile == null)
                    {
                        MessageBox.Show("Could not decrypt the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var names = openFileDialog.FileNames[0].Split('\\');
                    var name = names[names.Length - 1];

                    saveFileDialog.FileName = name.EndsWith(".encrypted") ? name.Substring(0, name.Length - 10) : name;

                    dr = saveFileDialog.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        path = saveFileDialog.FileNames.Length > 0 ? saveFileDialog.FileNames[0] : null;
                        if (path != null)
                        {
                            File.WriteAllBytes(path, decFile);
                        }
                    }
                }
            }
        }

        private void ShowEncryptKey(object sender, EventArgs e)
        {
            ShowKey(cbShowKeyEncrypt, txtKeyEncrypt);
        }

        private void ShowDecryptKey(object sender, EventArgs e)
        {
            ShowKey(cbShowKeyDecrypt, txtKeyDecrypt);
        }

        private void ShowKey(CheckBox cbKey, TextBox txtKey)
        {
            txtKey.UseSystemPasswordChar = !cbKey.Checked;
        }

        private bool KeyIsNullOrEmpty(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Key cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
    }
}
