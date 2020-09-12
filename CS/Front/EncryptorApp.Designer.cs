namespace Encryptor.Front
{
    partial class EncryptorApp
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptorApp));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyEncrypt = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpEncrypt = new System.Windows.Forms.TabPage();
            this.cbShowKeyEncrypt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDecrypt = new System.Windows.Forms.TabPage();
            this.cbShowKeyDecrypt = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyDecrypt = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tpEncrypt.SuspendLayout();
            this.tpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(196, 104);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.EncryptClick);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(196, 104);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.DecryptClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "This key is used to encrypt your file.";
            // 
            // txtKeyEncrypt
            // 
            this.txtKeyEncrypt.Location = new System.Drawing.Point(16, 52);
            this.txtKeyEncrypt.Name = "txtKeyEncrypt";
            this.txtKeyEncrypt.Size = new System.Drawing.Size(255, 20);
            this.txtKeyEncrypt.TabIndex = 0;
            this.txtKeyEncrypt.UseSystemPasswordChar = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpEncrypt);
            this.tabControl.Controls.Add(this.tpDecrypt);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(8, 8);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 166);
            this.tabControl.TabIndex = 6;
            this.tabControl.TabStop = false;
            // 
            // tpEncrypt
            // 
            this.tpEncrypt.Controls.Add(this.cbShowKeyEncrypt);
            this.tpEncrypt.Controls.Add(this.label2);
            this.tpEncrypt.Controls.Add(this.label1);
            this.tpEncrypt.Controls.Add(this.txtKeyEncrypt);
            this.tpEncrypt.Controls.Add(this.btnEncrypt);
            this.tpEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tpEncrypt.Name = "tpEncrypt";
            this.tpEncrypt.Padding = new System.Windows.Forms.Padding(10);
            this.tpEncrypt.Size = new System.Drawing.Size(284, 140);
            this.tpEncrypt.TabIndex = 0;
            this.tpEncrypt.Text = "Encrypt file";
            this.tpEncrypt.UseVisualStyleBackColor = true;
            // 
            // cbShowKeyEncrypt
            // 
            this.cbShowKeyEncrypt.AutoSize = true;
            this.cbShowKeyEncrypt.Location = new System.Drawing.Point(16, 78);
            this.cbShowKeyEncrypt.Name = "cbShowKeyEncrypt";
            this.cbShowKeyEncrypt.Size = new System.Drawing.Size(73, 17);
            this.cbShowKeyEncrypt.TabIndex = 7;
            this.cbShowKeyEncrypt.TabStop = false;
            this.cbShowKeyEncrypt.Text = "Show key";
            this.cbShowKeyEncrypt.UseVisualStyleBackColor = true;
            this.cbShowKeyEncrypt.CheckedChanged += new System.EventHandler(this.ShowEncryptKey);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter key";
            // 
            // tpDecrypt
            // 
            this.tpDecrypt.Controls.Add(this.cbShowKeyDecrypt);
            this.tpDecrypt.Controls.Add(this.label3);
            this.tpDecrypt.Controls.Add(this.label4);
            this.tpDecrypt.Controls.Add(this.txtKeyDecrypt);
            this.tpDecrypt.Controls.Add(this.btnDecrypt);
            this.tpDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tpDecrypt.Name = "tpDecrypt";
            this.tpDecrypt.Padding = new System.Windows.Forms.Padding(10);
            this.tpDecrypt.Size = new System.Drawing.Size(284, 140);
            this.tpDecrypt.TabIndex = 1;
            this.tpDecrypt.Text = "Decrypt file";
            this.tpDecrypt.UseVisualStyleBackColor = true;
            // 
            // cbShowKeyDecrypt
            // 
            this.cbShowKeyDecrypt.AutoSize = true;
            this.cbShowKeyDecrypt.Location = new System.Drawing.Point(16, 78);
            this.cbShowKeyDecrypt.Name = "cbShowKeyDecrypt";
            this.cbShowKeyDecrypt.Size = new System.Drawing.Size(73, 17);
            this.cbShowKeyDecrypt.TabIndex = 11;
            this.cbShowKeyDecrypt.TabStop = false;
            this.cbShowKeyDecrypt.Text = "Show key";
            this.cbShowKeyDecrypt.UseVisualStyleBackColor = true;
            this.cbShowKeyDecrypt.CheckedChanged += new System.EventHandler(this.ShowDecryptKey);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type here the key used to encrypt your file.";
            // 
            // txtKeyDecrypt
            // 
            this.txtKeyDecrypt.Location = new System.Drawing.Point(16, 52);
            this.txtKeyDecrypt.Name = "txtKeyDecrypt";
            this.txtKeyDecrypt.Size = new System.Drawing.Size(255, 20);
            this.txtKeyDecrypt.TabIndex = 0;
            this.txtKeyDecrypt.UseSystemPasswordChar = true;
            // 
            // EncryptorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 182);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptorApp";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CC Encryptor";
            this.tabControl.ResumeLayout(false);
            this.tpEncrypt.ResumeLayout(false);
            this.tpEncrypt.PerformLayout();
            this.tpDecrypt.ResumeLayout(false);
            this.tpDecrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyEncrypt;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpEncrypt;
        private System.Windows.Forms.TabPage tpDecrypt;
        private System.Windows.Forms.CheckBox cbShowKeyEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbShowKeyDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyDecrypt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

