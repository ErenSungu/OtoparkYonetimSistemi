namespace OtoparkYonetimSistemi
{
    partial class Form4_1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TalepIcerikleri = new System.Windows.Forms.Button();
            this.btnCevapDuzenle = new System.Windows.Forms.Button();
            this.btnDestekGoruntule = new System.Windows.Forms.Button();
            this.btnTalepDurumuDegistir = new System.Windows.Forms.Button();
            this.btnCevapOlustur = new System.Windows.Forms.Button();
            this.txtTalepCevabi = new System.Windows.Forms.TextBox();
            this.txtDestekID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 333);
            this.dataGridView1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btn_TalepIcerikleri);
            this.panel1.Controls.Add(this.btnCevapDuzenle);
            this.panel1.Controls.Add(this.btnDestekGoruntule);
            this.panel1.Controls.Add(this.btnTalepDurumuDegistir);
            this.panel1.Controls.Add(this.btnCevapOlustur);
            this.panel1.Controls.Add(this.txtTalepCevabi);
            this.panel1.Controls.Add(this.txtDestekID);
            this.panel1.Location = new System.Drawing.Point(-4, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 178);
            this.panel1.TabIndex = 13;
            // 
            // btn_TalepIcerikleri
            // 
            this.btn_TalepIcerikleri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_TalepIcerikleri.Location = new System.Drawing.Point(702, 120);
            this.btn_TalepIcerikleri.Name = "btn_TalepIcerikleri";
            this.btn_TalepIcerikleri.Size = new System.Drawing.Size(266, 36);
            this.btn_TalepIcerikleri.TabIndex = 16;
            this.btn_TalepIcerikleri.Text = "Talep İçeriklerini Getir";
            this.btn_TalepIcerikleri.UseVisualStyleBackColor = true;
            this.btn_TalepIcerikleri.Click += new System.EventHandler(this.btn_TalepIcerikleri_Click);
            // 
            // btnCevapDuzenle
            // 
            this.btnCevapDuzenle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevapDuzenle.Location = new System.Drawing.Point(824, 67);
            this.btnCevapDuzenle.Name = "btnCevapDuzenle";
            this.btnCevapDuzenle.Size = new System.Drawing.Size(202, 36);
            this.btnCevapDuzenle.TabIndex = 15;
            this.btnCevapDuzenle.Text = "Cevap Düzenle";
            this.btnCevapDuzenle.UseVisualStyleBackColor = true;
            this.btnCevapDuzenle.Click += new System.EventHandler(this.btnCevapDuzenle_Click);
            // 
            // btnDestekGoruntule
            // 
            this.btnDestekGoruntule.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDestekGoruntule.Location = new System.Drawing.Point(16, 120);
            this.btnDestekGoruntule.Name = "btnDestekGoruntule";
            this.btnDestekGoruntule.Size = new System.Drawing.Size(282, 36);
            this.btnDestekGoruntule.TabIndex = 14;
            this.btnDestekGoruntule.Text = "Talep/Destek Listesini Görüntüle";
            this.btnDestekGoruntule.UseVisualStyleBackColor = true;
            this.btnDestekGoruntule.Click += new System.EventHandler(this.btnDestekGoruntule_Click);
            // 
            // btnTalepDurumuDegistir
            // 
            this.btnTalepDurumuDegistir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTalepDurumuDegistir.Location = new System.Drawing.Point(321, 120);
            this.btnTalepDurumuDegistir.Name = "btnTalepDurumuDegistir";
            this.btnTalepDurumuDegistir.Size = new System.Drawing.Size(282, 36);
            this.btnTalepDurumuDegistir.TabIndex = 15;
            this.btnTalepDurumuDegistir.Text = "Talep Durumu Değiştir";
            this.btnTalepDurumuDegistir.UseVisualStyleBackColor = true;
            this.btnTalepDurumuDegistir.Click += new System.EventHandler(this.btnTalepDurumuDegistir_Click);
            // 
            // btnCevapOlustur
            // 
            this.btnCevapOlustur.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevapOlustur.Location = new System.Drawing.Point(616, 67);
            this.btnCevapOlustur.Name = "btnCevapOlustur";
            this.btnCevapOlustur.Size = new System.Drawing.Size(202, 36);
            this.btnCevapOlustur.TabIndex = 14;
            this.btnCevapOlustur.Text = "Cevap Oluştur";
            this.btnCevapOlustur.UseVisualStyleBackColor = true;
            this.btnCevapOlustur.Click += new System.EventHandler(this.btnCevapOlustur_Click);
            // 
            // txtTalepCevabi
            // 
            this.txtTalepCevabi.BackColor = System.Drawing.Color.White;
            this.txtTalepCevabi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTalepCevabi.Location = new System.Drawing.Point(16, 10);
            this.txtTalepCevabi.Multiline = true;
            this.txtTalepCevabi.Name = "txtTalepCevabi";
            this.txtTalepCevabi.Size = new System.Drawing.Size(587, 104);
            this.txtTalepCevabi.TabIndex = 14;
            this.txtTalepCevabi.Text = "Talep Cevabı Giriniz";
            // 
            // txtDestekID
            // 
            this.txtDestekID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDestekID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDestekID.Location = new System.Drawing.Point(702, 28);
            this.txtDestekID.Multiline = true;
            this.txtDestekID.Name = "txtDestekID";
            this.txtDestekID.Size = new System.Drawing.Size(266, 33);
            this.txtDestekID.TabIndex = 1;
            this.txtDestekID.Text = "Destek ID";
            this.txtDestekID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4_1";
            this.ShowIcon = false;
            this.Text = "Destek/Talep Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTalepCevabi;
        private System.Windows.Forms.TextBox txtDestekID;
        private System.Windows.Forms.Button btnCevapOlustur;
        private System.Windows.Forms.Button btnTalepDurumuDegistir;
        private System.Windows.Forms.Button btnDestekGoruntule;
        private System.Windows.Forms.Button btnCevapDuzenle;
        private System.Windows.Forms.Button btn_TalepIcerikleri;
    }
}