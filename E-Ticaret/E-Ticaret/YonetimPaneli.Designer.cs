namespace E_Ticaret
{
    partial class YonetimPaneli
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
            this.urunFiyatıTextBox = new System.Windows.Forms.TextBox();
            this.stokSayisiTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiLabel = new System.Windows.Forms.Label();
            this.stokSayisiLabel = new System.Windows.Forms.Label();
            this.urunFiyatiLabel = new System.Windows.Forms.Label();
            this.urunFotografiButton = new System.Windows.Forms.Button();
            this.urunFotografi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.urunFotografi)).BeginInit();
            this.SuspendLayout();
            // 
            // urunFiyatıTextBox
            // 
            this.urunFiyatıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatıTextBox.Location = new System.Drawing.Point(193, 136);
            this.urunFiyatıTextBox.Name = "urunFiyatıTextBox";
            this.urunFiyatıTextBox.Size = new System.Drawing.Size(252, 30);
            this.urunFiyatıTextBox.TabIndex = 0;
            // 
            // stokSayisiTextBox
            // 
            this.stokSayisiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokSayisiTextBox.Location = new System.Drawing.Point(193, 84);
            this.stokSayisiTextBox.Name = "stokSayisiTextBox";
            this.stokSayisiTextBox.Size = new System.Drawing.Size(252, 30);
            this.stokSayisiTextBox.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(193, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 30);
            this.textBox3.TabIndex = 2;
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiTextBox.Location = new System.Drawing.Point(193, 32);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(252, 30);
            this.urunAdiTextBox.TabIndex = 3;
            // 
            // urunAdiLabel
            // 
            this.urunAdiLabel.AutoSize = true;
            this.urunAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiLabel.Location = new System.Drawing.Point(68, 32);
            this.urunAdiLabel.Name = "urunAdiLabel";
            this.urunAdiLabel.Size = new System.Drawing.Size(102, 25);
            this.urunAdiLabel.TabIndex = 4;
            this.urunAdiLabel.Text = "Ürün Adı*:";
            this.urunAdiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stokSayisiLabel
            // 
            this.stokSayisiLabel.AutoSize = true;
            this.stokSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokSayisiLabel.Location = new System.Drawing.Point(68, 84);
            this.stokSayisiLabel.Name = "stokSayisiLabel";
            this.stokSayisiLabel.Size = new System.Drawing.Size(124, 25);
            this.stokSayisiLabel.TabIndex = 4;
            this.stokSayisiLabel.Text = "Stok Sayısı*:";
            this.stokSayisiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunFiyatiLabel
            // 
            this.urunFiyatiLabel.AutoSize = true;
            this.urunFiyatiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatiLabel.Location = new System.Drawing.Point(68, 136);
            this.urunFiyatiLabel.Name = "urunFiyatiLabel";
            this.urunFiyatiLabel.Size = new System.Drawing.Size(119, 25);
            this.urunFiyatiLabel.TabIndex = 4;
            this.urunFiyatiLabel.Text = "Ürün Fiyatı*:";
            this.urunFiyatiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunFotografiButton
            // 
            this.urunFotografiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFotografiButton.Location = new System.Drawing.Point(540, 184);
            this.urunFotografiButton.Name = "urunFotografiButton";
            this.urunFotografiButton.Size = new System.Drawing.Size(155, 42);
            this.urunFotografiButton.TabIndex = 5;
            this.urunFotografiButton.Text = "Fotoğraf Seç";
            this.urunFotografiButton.UseVisualStyleBackColor = true;
            this.urunFotografiButton.Click += new System.EventHandler(this.urunFotografiButton_Click);
            // 
            // urunFotografi
            // 
            this.urunFotografi.Location = new System.Drawing.Point(782, 32);
            this.urunFotografi.Name = "urunFotografi";
            this.urunFotografi.Size = new System.Drawing.Size(238, 194);
            this.urunFotografi.TabIndex = 6;
            this.urunFotografi.TabStop = false;
            // 
            // YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 1055);
            this.Controls.Add(this.urunFotografi);
            this.Controls.Add(this.urunFotografiButton);
            this.Controls.Add(this.urunFiyatiLabel);
            this.Controls.Add(this.stokSayisiLabel);
            this.Controls.Add(this.urunAdiLabel);
            this.Controls.Add(this.urunAdiTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.stokSayisiTextBox);
            this.Controls.Add(this.urunFiyatıTextBox);
            this.Name = "YonetimPaneli";
            this.Text = "Yönetim Paneli";
            this.Load += new System.EventHandler(this.YonetimPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunFotografi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunFiyatıTextBox;
        private System.Windows.Forms.TextBox stokSayisiTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.Label urunAdiLabel;
        private System.Windows.Forms.Label stokSayisiLabel;
        private System.Windows.Forms.Label urunFiyatiLabel;
        private System.Windows.Forms.Button urunFotografiButton;
        private System.Windows.Forms.PictureBox urunFotografi;
    }
}