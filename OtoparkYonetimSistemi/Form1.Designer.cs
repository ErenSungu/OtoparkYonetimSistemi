namespace OtoparkYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnAracParkBilgi = new System.Windows.Forms.Button();
            this.btnAracBilgiAyar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMusteriBilgi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otopark Yönetim Sistemi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnAracParkBilgi);
            this.groupBox1.Controls.Add(this.btnAracBilgiAyar);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnMusteriBilgi);
            this.groupBox1.Location = new System.Drawing.Point(21, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(259, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(4, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finansal Ajanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(4, 218);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(251, 48);
            this.button6.TabIndex = 4;
            this.button6.Text = "Ücret Ayarları Sayfası";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAracParkBilgi
            // 
            this.btnAracParkBilgi.BackColor = System.Drawing.Color.White;
            this.btnAracParkBilgi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAracParkBilgi.FlatAppearance.BorderSize = 0;
            this.btnAracParkBilgi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracParkBilgi.Location = new System.Drawing.Point(4, 22);
            this.btnAracParkBilgi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAracParkBilgi.Name = "btnAracParkBilgi";
            this.btnAracParkBilgi.Size = new System.Drawing.Size(251, 43);
            this.btnAracParkBilgi.TabIndex = 3;
            this.btnAracParkBilgi.Text = "Araç Park Bilgisi Sayfası";
            this.btnAracParkBilgi.UseVisualStyleBackColor = false;
            this.btnAracParkBilgi.Click += new System.EventHandler(this.btnAracParkBilgi_Click);
            // 
            // btnAracBilgiAyar
            // 
            this.btnAracBilgiAyar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracBilgiAyar.Location = new System.Drawing.Point(4, 169);
            this.btnAracBilgiAyar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAracBilgiAyar.Name = "btnAracBilgiAyar";
            this.btnAracBilgiAyar.Size = new System.Drawing.Size(251, 43);
            this.btnAracBilgiAyar.TabIndex = 2;
            this.btnAracBilgiAyar.Text = "Araç Bilgisi Ayarları Sayfası";
            this.btnAracBilgiAyar.UseVisualStyleBackColor = true;
            this.btnAracBilgiAyar.Click += new System.EventHandler(this.btnAracBilgiAyar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(4, 120);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Personel Bilgisi Sayfası";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMusteriBilgi
            // 
            this.btnMusteriBilgi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBilgi.Location = new System.Drawing.Point(4, 71);
            this.btnMusteriBilgi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMusteriBilgi.Name = "btnMusteriBilgi";
            this.btnMusteriBilgi.Size = new System.Drawing.Size(251, 43);
            this.btnMusteriBilgi.TabIndex = 3;
            this.btnMusteriBilgi.Text = "Müşteri Bilgisi Sayfası";
            this.btnMusteriBilgi.UseVisualStyleBackColor = true;
            this.btnMusteriBilgi.Click += new System.EventHandler(this.btnMusteriBilgi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(301, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAracBilgiAyar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMusteriBilgi;
        private System.Windows.Forms.Button btnAracParkBilgi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

