namespace OtoparkYonetimSistemi
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUcretID2 = new System.Windows.Forms.TextBox();
            this.btnUcretGuncelle = new System.Windows.Forms.Button();
            this.btnKampanyaDurumu = new System.Windows.Forms.Button();
            this.txtUcretID = new System.Windows.Forms.TextBox();
            this.txtYeniUcret = new System.Windows.Forms.TextBox();
            this.txtKampanyaID = new System.Windows.Forms.TextBox();
            this.btnKampanyaOlustur = new System.Windows.Forms.Button();
            this.dtpKampanyaBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpKampanyaBaslangıc = new System.Windows.Forms.DateTimePicker();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.txtKampanyaAciklama = new System.Windows.Forms.TextBox();
            this.txtKampanyaAd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKampanyalariGoruntule = new System.Windows.Forms.Button();
            this.btnTarifeListesiniGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 299);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txtUcretID2);
            this.panel1.Controls.Add(this.btnUcretGuncelle);
            this.panel1.Controls.Add(this.btnKampanyaDurumu);
            this.panel1.Controls.Add(this.txtUcretID);
            this.panel1.Controls.Add(this.txtYeniUcret);
            this.panel1.Controls.Add(this.txtKampanyaID);
            this.panel1.Controls.Add(this.btnKampanyaOlustur);
            this.panel1.Controls.Add(this.dtpKampanyaBitis);
            this.panel1.Controls.Add(this.dtpKampanyaBaslangıc);
            this.panel1.Controls.Add(this.txtIndirimOrani);
            this.panel1.Controls.Add(this.txtKampanyaAciklama);
            this.panel1.Controls.Add(this.txtKampanyaAd);
            this.panel1.Location = new System.Drawing.Point(-1, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 222);
            this.panel1.TabIndex = 13;
            // 
            // txtUcretID2
            // 
            this.txtUcretID2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcretID2.Location = new System.Drawing.Point(251, 59);
            this.txtUcretID2.Multiline = true;
            this.txtUcretID2.Name = "txtUcretID2";
            this.txtUcretID2.Size = new System.Drawing.Size(219, 33);
            this.txtUcretID2.TabIndex = 24;
            this.txtUcretID2.Text = "Ücret Tarifesi ID";
            this.txtUcretID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUcretGuncelle
            // 
            this.btnUcretGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcretGuncelle.Location = new System.Drawing.Point(783, 86);
            this.btnUcretGuncelle.Name = "btnUcretGuncelle";
            this.btnUcretGuncelle.Size = new System.Drawing.Size(230, 36);
            this.btnUcretGuncelle.TabIndex = 19;
            this.btnUcretGuncelle.Text = "Ücret Tarifesini Güncelle";
            this.btnUcretGuncelle.UseVisualStyleBackColor = true;
            this.btnUcretGuncelle.Click += new System.EventHandler(this.btnUcretGuncelle_Click);
            // 
            // btnKampanyaDurumu
            // 
            this.btnKampanyaDurumu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKampanyaDurumu.Location = new System.Drawing.Point(497, 47);
            this.btnKampanyaDurumu.Name = "btnKampanyaDurumu";
            this.btnKampanyaDurumu.Size = new System.Drawing.Size(252, 36);
            this.btnKampanyaDurumu.TabIndex = 21;
            this.btnKampanyaDurumu.Text = "Kampanya Durumunu Değiştir";
            this.btnKampanyaDurumu.UseVisualStyleBackColor = true;
            this.btnKampanyaDurumu.Click += new System.EventHandler(this.btnKampanyaDurumu_Click);
            // 
            // txtUcretID
            // 
            this.txtUcretID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcretID.Location = new System.Drawing.Point(783, 8);
            this.txtUcretID.Multiline = true;
            this.txtUcretID.Name = "txtUcretID";
            this.txtUcretID.Size = new System.Drawing.Size(230, 33);
            this.txtUcretID.TabIndex = 17;
            this.txtUcretID.Text = "Ücret Tarifesi ID";
            this.txtUcretID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYeniUcret
            // 
            this.txtYeniUcret.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYeniUcret.Location = new System.Drawing.Point(783, 47);
            this.txtYeniUcret.Multiline = true;
            this.txtYeniUcret.Name = "txtYeniUcret";
            this.txtYeniUcret.Size = new System.Drawing.Size(230, 33);
            this.txtYeniUcret.TabIndex = 18;
            this.txtYeniUcret.Text = "Yeni Ucret";
            this.txtYeniUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKampanyaID
            // 
            this.txtKampanyaID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKampanyaID.Location = new System.Drawing.Point(497, 8);
            this.txtKampanyaID.Multiline = true;
            this.txtKampanyaID.Name = "txtKampanyaID";
            this.txtKampanyaID.Size = new System.Drawing.Size(252, 33);
            this.txtKampanyaID.TabIndex = 23;
            this.txtKampanyaID.Text = "Kampanya ID";
            this.txtKampanyaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKampanyaOlustur
            // 
            this.btnKampanyaOlustur.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKampanyaOlustur.Location = new System.Drawing.Point(251, 156);
            this.btnKampanyaOlustur.Name = "btnKampanyaOlustur";
            this.btnKampanyaOlustur.Size = new System.Drawing.Size(219, 36);
            this.btnKampanyaOlustur.TabIndex = 20;
            this.btnKampanyaOlustur.Text = "Kampanya Oluştur";
            this.btnKampanyaOlustur.UseVisualStyleBackColor = true;
            this.btnKampanyaOlustur.Click += new System.EventHandler(this.btnKampanyaOlustur_Click);
            // 
            // dtpKampanyaBitis
            // 
            this.dtpKampanyaBitis.Location = new System.Drawing.Point(251, 128);
            this.dtpKampanyaBitis.Name = "dtpKampanyaBitis";
            this.dtpKampanyaBitis.Size = new System.Drawing.Size(219, 22);
            this.dtpKampanyaBitis.TabIndex = 22;
            // 
            // dtpKampanyaBaslangıc
            // 
            this.dtpKampanyaBaslangıc.Location = new System.Drawing.Point(251, 100);
            this.dtpKampanyaBaslangıc.Name = "dtpKampanyaBaslangıc";
            this.dtpKampanyaBaslangıc.Size = new System.Drawing.Size(219, 22);
            this.dtpKampanyaBaslangıc.TabIndex = 21;
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIndirimOrani.Location = new System.Drawing.Point(251, 8);
            this.txtIndirimOrani.Multiline = true;
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(219, 33);
            this.txtIndirimOrani.TabIndex = 20;
            this.txtIndirimOrani.Text = "İndirim Oranı";
            this.txtIndirimOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKampanyaAciklama
            // 
            this.txtKampanyaAciklama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKampanyaAciklama.Location = new System.Drawing.Point(13, 59);
            this.txtKampanyaAciklama.Multiline = true;
            this.txtKampanyaAciklama.Name = "txtKampanyaAciklama";
            this.txtKampanyaAciklama.Size = new System.Drawing.Size(219, 133);
            this.txtKampanyaAciklama.TabIndex = 19;
            this.txtKampanyaAciklama.Text = "Kampanya Açıklaması";
            // 
            // txtKampanyaAd
            // 
            this.txtKampanyaAd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKampanyaAd.Location = new System.Drawing.Point(13, 8);
            this.txtKampanyaAd.Multiline = true;
            this.txtKampanyaAd.Name = "txtKampanyaAd";
            this.txtKampanyaAd.Size = new System.Drawing.Size(219, 33);
            this.txtKampanyaAd.TabIndex = 18;
            this.txtKampanyaAd.Text = "Kampanya Adı";
            this.txtKampanyaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnKampanyalariGoruntule);
            this.panel2.Controls.Add(this.btnTarifeListesiniGoruntule);
            this.panel2.Location = new System.Drawing.Point(-1, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 54);
            this.panel2.TabIndex = 14;
            // 
            // btnKampanyalariGoruntule
            // 
            this.btnKampanyalariGoruntule.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKampanyalariGoruntule.Location = new System.Drawing.Point(743, 8);
            this.btnKampanyalariGoruntule.Name = "btnKampanyalariGoruntule";
            this.btnKampanyalariGoruntule.Size = new System.Drawing.Size(261, 36);
            this.btnKampanyalariGoruntule.TabIndex = 16;
            this.btnKampanyalariGoruntule.Text = "Kampanyaları Görüntüle";
            this.btnKampanyalariGoruntule.UseVisualStyleBackColor = true;
            this.btnKampanyalariGoruntule.Click += new System.EventHandler(this.btnKampanyalariGoruntule_Click);
            // 
            // btnTarifeListesiniGoruntule
            // 
            this.btnTarifeListesiniGoruntule.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTarifeListesiniGoruntule.Location = new System.Drawing.Point(13, 8);
            this.btnTarifeListesiniGoruntule.Name = "btnTarifeListesiniGoruntule";
            this.btnTarifeListesiniGoruntule.Size = new System.Drawing.Size(261, 36);
            this.btnTarifeListesiniGoruntule.TabIndex = 15;
            this.btnTarifeListesiniGoruntule.Text = "Fiyat Tarifelerini Görüntüle";
            this.btnTarifeListesiniGoruntule.UseVisualStyleBackColor = true;
            this.btnTarifeListesiniGoruntule.Click += new System.EventHandler(this.btnTarifeListesiniGoruntule_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "Ücret Ayarları";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTarifeListesiniGoruntule;
        private System.Windows.Forms.Button btnKampanyalariGoruntule;
        private System.Windows.Forms.TextBox txtUcretID;
        private System.Windows.Forms.TextBox txtYeniUcret;
        private System.Windows.Forms.Button btnUcretGuncelle;
        private System.Windows.Forms.DateTimePicker dtpKampanyaBaslangıc;
        private System.Windows.Forms.TextBox txtIndirimOrani;
        private System.Windows.Forms.TextBox txtKampanyaAciklama;
        private System.Windows.Forms.TextBox txtKampanyaAd;
        private System.Windows.Forms.TextBox txtKampanyaID;
        private System.Windows.Forms.Button btnKampanyaOlustur;
        private System.Windows.Forms.DateTimePicker dtpKampanyaBitis;
        private System.Windows.Forms.Button btnKampanyaDurumu;
        private System.Windows.Forms.TextBox txtUcretID2;
    }
}