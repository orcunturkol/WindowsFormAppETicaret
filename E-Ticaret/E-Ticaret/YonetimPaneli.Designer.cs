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
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiLabel = new System.Windows.Forms.Label();
            this.stokSayisiLabel = new System.Windows.Forms.Label();
            this.urunFiyatiLabel = new System.Windows.Forms.Label();
            this.urunFotografiButton = new System.Windows.Forms.Button();
            this.yukleButton = new System.Windows.Forms.Button();
            this.urunFotografi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriComboBox = new System.Windows.Forms.ComboBox();
            this.urunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunFotografi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // urunFiyatıTextBox
            // 
            this.urunFiyatıTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatıTextBox.Location = new System.Drawing.Point(144, 155);
            this.urunFiyatıTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.urunFiyatıTextBox.Name = "urunFiyatıTextBox";
            this.urunFiyatıTextBox.Size = new System.Drawing.Size(188, 26);
            this.urunFiyatıTextBox.TabIndex = 0;
            this.urunFiyatıTextBox.TextChanged += new System.EventHandler(this.urunFiyatıTextBox_TextChanged);
            // 
            // stokSayisiTextBox
            // 
            this.stokSayisiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokSayisiTextBox.Location = new System.Drawing.Point(144, 94);
            this.stokSayisiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stokSayisiTextBox.Name = "stokSayisiTextBox";
            this.stokSayisiTextBox.Size = new System.Drawing.Size(188, 26);
            this.stokSayisiTextBox.TabIndex = 1;
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiTextBox.Location = new System.Drawing.Point(144, 33);
            this.urunAdiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(188, 26);
            this.urunAdiTextBox.TabIndex = 3;
            // 
            // urunAdiLabel
            // 
            this.urunAdiLabel.AutoSize = true;
            this.urunAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiLabel.Location = new System.Drawing.Point(41, 39);
            this.urunAdiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunAdiLabel.Name = "urunAdiLabel";
            this.urunAdiLabel.Size = new System.Drawing.Size(81, 20);
            this.urunAdiLabel.TabIndex = 4;
            this.urunAdiLabel.Text = "Ürün Adı*:";
            this.urunAdiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stokSayisiLabel
            // 
            this.stokSayisiLabel.AutoSize = true;
            this.stokSayisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokSayisiLabel.Location = new System.Drawing.Point(41, 97);
            this.stokSayisiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stokSayisiLabel.Name = "stokSayisiLabel";
            this.stokSayisiLabel.Size = new System.Drawing.Size(97, 20);
            this.stokSayisiLabel.TabIndex = 4;
            this.stokSayisiLabel.Text = "Stok Sayısı*:";
            this.stokSayisiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunFiyatiLabel
            // 
            this.urunFiyatiLabel.AutoSize = true;
            this.urunFiyatiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFiyatiLabel.Location = new System.Drawing.Point(41, 155);
            this.urunFiyatiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urunFiyatiLabel.Name = "urunFiyatiLabel";
            this.urunFiyatiLabel.Size = new System.Drawing.Size(95, 20);
            this.urunFiyatiLabel.TabIndex = 4;
            this.urunFiyatiLabel.Text = "Ürün Fiyatı*:";
            this.urunFiyatiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunFotografiButton
            // 
            this.urunFotografiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunFotografiButton.Location = new System.Drawing.Point(414, 90);
            this.urunFotografiButton.Margin = new System.Windows.Forms.Padding(2);
            this.urunFotografiButton.Name = "urunFotografiButton";
            this.urunFotografiButton.Size = new System.Drawing.Size(116, 34);
            this.urunFotografiButton.TabIndex = 5;
            this.urunFotografiButton.Text = "Fotoğraf Seç";
            this.urunFotografiButton.UseVisualStyleBackColor = true;
            this.urunFotografiButton.Click += new System.EventHandler(this.urunFotografiButton_Click);
            // 
            // yukleButton
            // 
            this.yukleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yukleButton.Location = new System.Drawing.Point(430, 209);
            this.yukleButton.Name = "yukleButton";
            this.yukleButton.Size = new System.Drawing.Size(80, 31);
            this.yukleButton.TabIndex = 8;
            this.yukleButton.Text = "Yükle";
            this.yukleButton.UseVisualStyleBackColor = true;
            this.yukleButton.Click += new System.EventHandler(this.yukleButton_Click);
            // 
            // urunFotografi
            // 
            this.urunFotografi.Location = new System.Drawing.Point(549, 12);
            this.urunFotografi.Name = "urunFotografi";
            this.urunFotografi.Size = new System.Drawing.Size(467, 369);
            this.urunFotografi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urunFotografi.TabIndex = 10;
            this.urunFotografi.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kategori:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // kategoriComboBox
            // 
            this.kategoriComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriComboBox.FormattingEnabled = true;
            this.kategoriComboBox.Items.AddRange(new object[] {
            "-"});
            this.kategoriComboBox.Location = new System.Drawing.Point(144, 211);
            this.kategoriComboBox.Name = "kategoriComboBox";
            this.kategoriComboBox.Size = new System.Drawing.Size(188, 28);
            this.kategoriComboBox.TabIndex = 11;
            // 
            // urunlerDataGridView
            // 
            this.urunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGridView.Location = new System.Drawing.Point(45, 422);
            this.urunlerDataGridView.Name = "urunlerDataGridView";
            this.urunlerDataGridView.Size = new System.Drawing.Size(380, 150);
            this.urunlerDataGridView.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(455, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 475);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 47);
            this.button2.TabIndex = 14;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 590);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunlerDataGridView);
            this.Controls.Add(this.kategoriComboBox);
            this.Controls.Add(this.urunFotografi);
            this.Controls.Add(this.yukleButton);
            this.Controls.Add(this.urunFotografiButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunFiyatiLabel);
            this.Controls.Add(this.stokSayisiLabel);
            this.Controls.Add(this.urunAdiLabel);
            this.Controls.Add(this.urunAdiTextBox);
            this.Controls.Add(this.stokSayisiTextBox);
            this.Controls.Add(this.urunFiyatıTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "YonetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.Load += new System.EventHandler(this.YonetimPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunFotografi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urunFiyatıTextBox;
        private System.Windows.Forms.TextBox stokSayisiTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.Label urunAdiLabel;
        private System.Windows.Forms.Label stokSayisiLabel;
        private System.Windows.Forms.Label urunFiyatiLabel;
        private System.Windows.Forms.Button urunFotografiButton;
        private System.Windows.Forms.Button yukleButton;
        private System.Windows.Forms.PictureBox urunFotografi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kategoriComboBox;
        private System.Windows.Forms.DataGridView urunlerDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}