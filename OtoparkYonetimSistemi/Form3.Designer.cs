namespace OtoparkYonetimSistemi
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpParkSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpParkTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtParkAlaniNo = new System.Windows.Forms.TextBox();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.txtAracIcerikNo = new System.Windows.Forms.TextBox();
            this.btnAracGirisiYap = new System.Windows.Forms.Button();
            this.txtAracModelNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKampanyaID = new System.Windows.Forms.TextBox();
            this.btnAracCıkısıYap = new System.Windows.Forms.Button();
            this.txtAracParkID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParkAlanlariGoster = new System.Windows.Forms.Button();
            this.btnParkEdilmisAraclar = new System.Windows.Forms.Button();
            this.btnGecmisAracKaydiGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbOtoparkYonetimSistemiDataSet2 = new OtoparkYonetimSistemi.dbOtoparkYonetimSistemiDataSet2();
            this.dbOtoparkYonetimSistemiDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAracParkBilgileriGetirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAracParkBilgileriGetirTableAdapter = new OtoparkYonetimSistemi.dbOtoparkYonetimSistemiDataSet2TableAdapters.spAracParkBilgileriGetirTableAdapter();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAracParkBilgileriGetirBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox6.Controls.Add(this.dtpParkSaati);
            this.groupBox6.Controls.Add(this.dtpParkTarihi);
            this.groupBox6.Controls.Add(this.txtParkAlaniNo);
            this.groupBox6.Controls.Add(this.txtAracPlaka);
            this.groupBox6.Controls.Add(this.txtMusteriNo);
            this.groupBox6.Controls.Add(this.txtAracIcerikNo);
            this.groupBox6.Controls.Add(this.btnAracGirisiYap);
            this.groupBox6.Controls.Add(this.txtAracModelNo);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(1, 312);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(956, 170);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // dtpParkSaati
            // 
            this.dtpParkSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpParkSaati.Location = new System.Drawing.Point(476, 108);
            this.dtpParkSaati.Name = "dtpParkSaati";
            this.dtpParkSaati.ShowUpDown = true;
            this.dtpParkSaati.Size = new System.Drawing.Size(227, 23);
            this.dtpParkSaati.TabIndex = 12;
            // 
            // dtpParkTarihi
            // 
            this.dtpParkTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpParkTarihi.Location = new System.Drawing.Point(243, 108);
            this.dtpParkTarihi.Name = "dtpParkTarihi";
            this.dtpParkTarihi.Size = new System.Drawing.Size(227, 23);
            this.dtpParkTarihi.TabIndex = 11;
            // 
            // txtParkAlaniNo
            // 
            this.txtParkAlaniNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParkAlaniNo.Location = new System.Drawing.Point(10, 98);
            this.txtParkAlaniNo.Multiline = true;
            this.txtParkAlaniNo.Name = "txtParkAlaniNo";
            this.txtParkAlaniNo.Size = new System.Drawing.Size(227, 33);
            this.txtParkAlaniNo.TabIndex = 9;
            this.txtParkAlaniNo.Text = "Park Alanı No";
            this.txtParkAlaniNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracPlaka.Location = new System.Drawing.Point(10, 56);
            this.txtAracPlaka.Multiline = true;
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(227, 33);
            this.txtAracPlaka.TabIndex = 8;
            this.txtAracPlaka.Text = "Araç Plakası";
            this.txtAracPlaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriNo.Location = new System.Drawing.Point(709, 56);
            this.txtMusteriNo.Multiline = true;
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(227, 33);
            this.txtMusteriNo.TabIndex = 4;
            this.txtMusteriNo.Text = "Müşteri No";
            this.txtMusteriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAracIcerikNo
            // 
            this.txtAracIcerikNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracIcerikNo.Location = new System.Drawing.Point(476, 56);
            this.txtAracIcerikNo.Multiline = true;
            this.txtAracIcerikNo.Name = "txtAracIcerikNo";
            this.txtAracIcerikNo.Size = new System.Drawing.Size(227, 33);
            this.txtAracIcerikNo.TabIndex = 3;
            this.txtAracIcerikNo.Text = "İçerik No";
            this.txtAracIcerikNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAracGirisiYap
            // 
            this.btnAracGirisiYap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracGirisiYap.Location = new System.Drawing.Point(747, 102);
            this.btnAracGirisiYap.Name = "btnAracGirisiYap";
            this.btnAracGirisiYap.Size = new System.Drawing.Size(145, 36);
            this.btnAracGirisiYap.TabIndex = 2;
            this.btnAracGirisiYap.Text = "Araç Girişi Yap";
            this.btnAracGirisiYap.UseVisualStyleBackColor = true;
            this.btnAracGirisiYap.Click += new System.EventHandler(this.btnAracGirisiYap_Click);
            // 
            // txtAracModelNo
            // 
            this.txtAracModelNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracModelNo.Location = new System.Drawing.Point(243, 56);
            this.txtAracModelNo.Multiline = true;
            this.txtAracModelNo.Name = "txtAracModelNo";
            this.txtAracModelNo.Size = new System.Drawing.Size(227, 33);
            this.txtAracModelNo.TabIndex = 0;
            this.txtAracModelNo.Text = "Model No";
            this.txtAracModelNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(347, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 38);
            this.label6.TabIndex = 1;
            this.label6.Text = "YENİ ARAÇ GİRİŞİ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.txtKampanyaID);
            this.groupBox2.Controls.Add(this.btnAracCıkısıYap);
            this.groupBox2.Controls.Add(this.txtAracParkID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(956, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 228);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // txtKampanyaID
            // 
            this.txtKampanyaID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKampanyaID.Location = new System.Drawing.Point(91, 108);
            this.txtKampanyaID.Multiline = true;
            this.txtKampanyaID.Name = "txtKampanyaID";
            this.txtKampanyaID.Size = new System.Drawing.Size(145, 33);
            this.txtKampanyaID.TabIndex = 3;
            this.txtKampanyaID.Text = "KampanyaID";
            this.txtKampanyaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAracCıkısıYap
            // 
            this.btnAracCıkısıYap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracCıkısıYap.Location = new System.Drawing.Point(91, 176);
            this.btnAracCıkısıYap.Name = "btnAracCıkısıYap";
            this.btnAracCıkısıYap.Size = new System.Drawing.Size(145, 33);
            this.btnAracCıkısıYap.TabIndex = 2;
            this.btnAracCıkısıYap.Text = "Araç Çıkışı Yap";
            this.btnAracCıkısıYap.UseVisualStyleBackColor = true;
            this.btnAracCıkısıYap.Click += new System.EventHandler(this.btnAracCıkısıYap_Click);
            // 
            // txtAracParkID
            // 
            this.txtAracParkID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracParkID.Location = new System.Drawing.Point(51, 56);
            this.txtAracParkID.Multiline = true;
            this.txtAracParkID.Name = "txtAracParkID";
            this.txtAracParkID.Size = new System.Drawing.Size(219, 33);
            this.txtAracParkID.TabIndex = 0;
            this.txtAracParkID.Text = "Araç Park ID";
            this.txtAracParkID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARAÇ ÇIKIŞI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnParkAlanlariGoster);
            this.groupBox1.Controls.Add(this.btnParkEdilmisAraclar);
            this.groupBox1.Controls.Add(this.btnGecmisAracKaydiGoster);
            this.groupBox1.Location = new System.Drawing.Point(1, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnParkAlanlariGoster
            // 
            this.btnParkAlanlariGoster.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParkAlanlariGoster.Location = new System.Drawing.Point(696, 22);
            this.btnParkAlanlariGoster.Name = "btnParkAlanlariGoster";
            this.btnParkAlanlariGoster.Size = new System.Drawing.Size(219, 36);
            this.btnParkAlanlariGoster.TabIndex = 4;
            this.btnParkAlanlariGoster.Text = "Park Alanlarını Göster";
            this.btnParkAlanlariGoster.UseVisualStyleBackColor = true;
            this.btnParkAlanlariGoster.Click += new System.EventHandler(this.btnParkAlanlariGoster_Click);
            // 
            // btnParkEdilmisAraclar
            // 
            this.btnParkEdilmisAraclar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParkEdilmisAraclar.Location = new System.Drawing.Point(35, 22);
            this.btnParkEdilmisAraclar.Name = "btnParkEdilmisAraclar";
            this.btnParkEdilmisAraclar.Size = new System.Drawing.Size(219, 36);
            this.btnParkEdilmisAraclar.TabIndex = 3;
            this.btnParkEdilmisAraclar.Text = "Park Edilmiş Araçları Göster";
            this.btnParkEdilmisAraclar.UseVisualStyleBackColor = true;
            this.btnParkEdilmisAraclar.Click += new System.EventHandler(this.btnParkEdilmisAraclar_Click);
            // 
            // btnGecmisAracKaydiGoster
            // 
            this.btnGecmisAracKaydiGoster.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisAracKaydiGoster.Location = new System.Drawing.Point(354, 22);
            this.btnGecmisAracKaydiGoster.Name = "btnGecmisAracKaydiGoster";
            this.btnGecmisAracKaydiGoster.Size = new System.Drawing.Size(219, 36);
            this.btnGecmisAracKaydiGoster.TabIndex = 2;
            this.btnGecmisAracKaydiGoster.Text = "Geçmiş Araç Kaydı Göster";
            this.btnGecmisAracKaydiGoster.UseVisualStyleBackColor = true;
            this.btnGecmisAracKaydiGoster.Click += new System.EventHandler(this.btnGecmisAracKaydiGoster_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 333);
            this.dataGridView1.TabIndex = 4;
            // 
            // dbOtoparkYonetimSistemiDataSet2
            // 
            this.dbOtoparkYonetimSistemiDataSet2.DataSetName = "dbOtoparkYonetimSistemiDataSet2";
            this.dbOtoparkYonetimSistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbOtoparkYonetimSistemiDataSet2BindingSource
            // 
            this.dbOtoparkYonetimSistemiDataSet2BindingSource.DataSource = this.dbOtoparkYonetimSistemiDataSet2;
            this.dbOtoparkYonetimSistemiDataSet2BindingSource.Position = 0;
            // 
            // spAracParkBilgileriGetirBindingSource
            // 
            this.spAracParkBilgileriGetirBindingSource.DataMember = "spAracParkBilgileriGetir";
            this.spAracParkBilgileriGetirBindingSource.DataSource = this.dbOtoparkYonetimSistemiDataSet2BindingSource;
            // 
            // spAracParkBilgileriGetirTableAdapter
            // 
            this.spAracParkBilgileriGetirTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Araç Park Bilgileri";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAracParkBilgileriGetirBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.TextBox txtAracIcerikNo;
        private System.Windows.Forms.Button btnAracGirisiYap;
        private System.Windows.Forms.TextBox txtAracModelNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParkAlaniNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAracCıkısıYap;
        private System.Windows.Forms.TextBox txtAracParkID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGecmisAracKaydiGoster;
        private System.Windows.Forms.Button btnParkEdilmisAraclar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbOtoparkYonetimSistemiDataSet2BindingSource;
        private dbOtoparkYonetimSistemiDataSet2 dbOtoparkYonetimSistemiDataSet2;
        private System.Windows.Forms.BindingSource spAracParkBilgileriGetirBindingSource;
        private dbOtoparkYonetimSistemiDataSet2TableAdapters.spAracParkBilgileriGetirTableAdapter spAracParkBilgileriGetirTableAdapter;
        private System.Windows.Forms.Button btnParkAlanlariGoster;
        private System.Windows.Forms.DateTimePicker dtpParkTarihi;
        private System.Windows.Forms.DateTimePicker dtpParkSaati;
        private System.Windows.Forms.TextBox txtKampanyaID;
    }
}