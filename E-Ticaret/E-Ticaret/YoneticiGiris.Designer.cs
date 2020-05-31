namespace E_Ticaret
{
    partial class YoneticiGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullaniciAdiLabel = new System.Windows.Forms.Label();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.girisYapButton = new System.Windows.Forms.Button();
            this.cikisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdiTextBox
            // 
            this.kullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiTextBox.Location = new System.Drawing.Point(170, 86);
            this.kullaniciAdiTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kullaniciAdiTextBox.Name = "kullaniciAdiTextBox";
            this.kullaniciAdiTextBox.Size = new System.Drawing.Size(130, 26);
            this.kullaniciAdiTextBox.TabIndex = 0;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.Location = new System.Drawing.Point(170, 123);
            this.sifreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '*';
            this.sifreTextBox.Size = new System.Drawing.Size(130, 26);
            this.sifreTextBox.TabIndex = 0;
            // 
            // kullaniciAdiLabel
            // 
            this.kullaniciAdiLabel.AutoSize = true;
            this.kullaniciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdiLabel.Location = new System.Drawing.Point(72, 86);
            this.kullaniciAdiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kullaniciAdiLabel.Name = "kullaniciAdiLabel";
            this.kullaniciAdiLabel.Size = new System.Drawing.Size(97, 20);
            this.kullaniciAdiLabel.TabIndex = 1;
            this.kullaniciAdiLabel.Text = "Kullanıcı Adı:";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreLabel.Location = new System.Drawing.Point(115, 123);
            this.sifreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(46, 20);
            this.sifreLabel.TabIndex = 2;
            this.sifreLabel.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yönetici Paneli Giriş\r\n";
            // 
            // girisYapButton
            // 
            this.girisYapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisYapButton.Location = new System.Drawing.Point(238, 161);
            this.girisYapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.girisYapButton.Name = "girisYapButton";
            this.girisYapButton.Size = new System.Drawing.Size(76, 28);
            this.girisYapButton.TabIndex = 4;
            this.girisYapButton.Text = "Giriş Yap";
            this.girisYapButton.UseVisualStyleBackColor = true;
            this.girisYapButton.Click += new System.EventHandler(this.girisYapButton_Click);
            // 
            // cikisButton
            // 
            this.cikisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(104, 161);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(76, 28);
            this.cikisButton.TabIndex = 5;
            this.cikisButton.Text = "Çıkış";
            this.cikisButton.UseVisualStyleBackColor = true;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 244);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.girisYapButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.kullaniciAdiLabel);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciAdiTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş Paneli";
            this.Load += new System.EventHandler(this.YoneticiGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullaniciAdiTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label kullaniciAdiLabel;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button girisYapButton;
        private System.Windows.Forms.Button cikisButton;
    }
}