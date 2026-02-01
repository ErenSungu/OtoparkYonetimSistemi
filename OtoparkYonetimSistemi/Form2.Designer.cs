namespace OtoparkYonetimSistemi
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.txtEklemeMarkAdi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbOtoparkYonetimSistemiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbOtoparkYonetimSistemiDataSet = new OtoparkYonetimSistemi.dbOtoparkYonetimSistemiDataSet();
            this.dbOtoparkYonetimSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUretimYili = new System.Windows.Forms.TextBox();
            this.txtMarkaID = new System.Windows.Forms.TextBox();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.txtModelID2 = new System.Windows.Forms.TextBox();
            this.txtUretimYili2 = new System.Windows.Forms.TextBox();
            this.txtMarkaID2 = new System.Windows.Forms.TextBox();
            this.btnModeliGuncelle = new System.Windows.Forms.Button();
            this.txtModelAdı2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAracModelListele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAracIcerikBilgileri = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkaEkle.Location = new System.Drawing.Point(195, 87);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(145, 36);
            this.btnMarkaEkle.TabIndex = 2;
            this.btnMarkaEkle.Text = "Marka Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // txtEklemeMarkAdi
            // 
            this.txtEklemeMarkAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEklemeMarkAdi.Location = new System.Drawing.Point(148, 48);
            this.txtEklemeMarkAdi.Multiline = true;
            this.txtEklemeMarkAdi.Name = "txtEklemeMarkAdi";
            this.txtEklemeMarkAdi.Size = new System.Drawing.Size(227, 33);
            this.txtEklemeMarkAdi.TabIndex = 0;
            this.txtEklemeMarkAdi.Text = "Marka Adı";
            this.txtEklemeMarkAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 239);
            this.dataGridView1.TabIndex = 3;
            // 
            // dbOtoparkYonetimSistemiDataSetBindingSource1
            // 
            this.dbOtoparkYonetimSistemiDataSetBindingSource1.DataSource = this.dbOtoparkYonetimSistemiDataSet;
            this.dbOtoparkYonetimSistemiDataSetBindingSource1.Position = 0;
            // 
            // dbOtoparkYonetimSistemiDataSet
            // 
            this.dbOtoparkYonetimSistemiDataSet.DataSetName = "dbOtoparkYonetimSistemiDataSet";
            this.dbOtoparkYonetimSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbOtoparkYonetimSistemiDataSetBindingSource
            // 
            this.dbOtoparkYonetimSistemiDataSetBindingSource.DataSource = this.dbOtoparkYonetimSistemiDataSet;
            this.dbOtoparkYonetimSistemiDataSetBindingSource.Position = 0;
            // 
            // txtUretimYili
            // 
            this.txtUretimYili.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUretimYili.Location = new System.Drawing.Point(665, 47);
            this.txtUretimYili.Multiline = true;
            this.txtUretimYili.Name = "txtUretimYili";
            this.txtUretimYili.Size = new System.Drawing.Size(227, 33);
            this.txtUretimYili.TabIndex = 4;
            this.txtUretimYili.Text = "Üretim Yılı";
            this.txtUretimYili.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarkaID
            // 
            this.txtMarkaID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaID.Location = new System.Drawing.Point(419, 47);
            this.txtMarkaID.Multiline = true;
            this.txtMarkaID.Name = "txtMarkaID";
            this.txtMarkaID.Size = new System.Drawing.Size(227, 33);
            this.txtMarkaID.TabIndex = 3;
            this.txtMarkaID.Text = "Marka ID";
            this.txtMarkaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModelEkle.Location = new System.Drawing.Point(457, 86);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(145, 36);
            this.btnModelEkle.TabIndex = 2;
            this.btnModelEkle.Text = "Model Ekle";
            this.btnModelEkle.UseVisualStyleBackColor = true;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelAdi.Location = new System.Drawing.Point(177, 49);
            this.txtModelAdi.Multiline = true;
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(227, 33);
            this.txtModelAdi.TabIndex = 0;
            this.txtModelAdi.Text = "Model Adı";
            this.txtModelAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModelID2
            // 
            this.txtModelID2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelID2.Location = new System.Drawing.Point(32, 46);
            this.txtModelID2.Multiline = true;
            this.txtModelID2.Name = "txtModelID2";
            this.txtModelID2.Size = new System.Drawing.Size(227, 33);
            this.txtModelID2.TabIndex = 8;
            this.txtModelID2.Text = "Model ID";
            this.txtModelID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUretimYili2
            // 
            this.txtUretimYili2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUretimYili2.Location = new System.Drawing.Point(770, 46);
            this.txtUretimYili2.Multiline = true;
            this.txtUretimYili2.Name = "txtUretimYili2";
            this.txtUretimYili2.Size = new System.Drawing.Size(227, 33);
            this.txtUretimYili2.TabIndex = 4;
            this.txtUretimYili2.Text = "Üretim Yılı";
            this.txtUretimYili2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarkaID2
            // 
            this.txtMarkaID2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarkaID2.Location = new System.Drawing.Point(525, 46);
            this.txtMarkaID2.Multiline = true;
            this.txtMarkaID2.Name = "txtMarkaID2";
            this.txtMarkaID2.Size = new System.Drawing.Size(227, 33);
            this.txtMarkaID2.TabIndex = 3;
            this.txtMarkaID2.Text = "Marka ID";
            this.txtMarkaID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModeliGuncelle
            // 
            this.btnModeliGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModeliGuncelle.Location = new System.Drawing.Point(452, 85);
            this.btnModeliGuncelle.Name = "btnModeliGuncelle";
            this.btnModeliGuncelle.Size = new System.Drawing.Size(145, 36);
            this.btnModeliGuncelle.TabIndex = 2;
            this.btnModeliGuncelle.Text = "Modeli Güncelle";
            this.btnModeliGuncelle.UseVisualStyleBackColor = true;
            this.btnModeliGuncelle.Click += new System.EventHandler(this.btnModeliGuncelle_Click);
            // 
            // txtModelAdı2
            // 
            this.txtModelAdı2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelAdı2.Location = new System.Drawing.Point(277, 46);
            this.txtModelAdı2.Multiline = true;
            this.txtModelAdı2.Name = "txtModelAdı2";
            this.txtModelAdı2.Size = new System.Drawing.Size(227, 33);
            this.txtModelAdı2.TabIndex = 0;
            this.txtModelAdı2.Text = "Model Adı";
            this.txtModelAdı2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(761, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Araç Marka Bilgilerini Göster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAracModelListele
            // 
            this.btnAracModelListele.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracModelListele.Location = new System.Drawing.Point(761, 74);
            this.btnAracModelListele.Name = "btnAracModelListele";
            this.btnAracModelListele.Size = new System.Drawing.Size(239, 36);
            this.btnAracModelListele.TabIndex = 9;
            this.btnAracModelListele.Text = "Araç Model Bilgilerini Göster";
            this.btnAracModelListele.UseVisualStyleBackColor = true;
            this.btnAracModelListele.Click += new System.EventHandler(this.btnAracModelListele_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(402, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Araç Modeli Ekleme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtModelAdi);
            this.panel1.Controls.Add(this.btnModelEkle);
            this.panel1.Controls.Add(this.txtUretimYili);
            this.panel1.Controls.Add(this.txtMarkaID);
            this.panel1.Location = new System.Drawing.Point(1, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 141);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnModeliGuncelle);
            this.panel3.Controls.Add(this.txtUretimYili2);
            this.panel3.Controls.Add(this.txtModelID2);
            this.panel3.Controls.Add(this.txtMarkaID2);
            this.panel3.Controls.Add(this.txtModelAdı2);
            this.panel3.Location = new System.Drawing.Point(1, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1025, 134);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(369, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Araç Modeli Güncelleme";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.btnAracIcerikBilgileri);
            this.panel4.Controls.Add(this.btnMarkaEkle);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtEklemeMarkAdi);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btnAracModelListele);
            this.panel4.Location = new System.Drawing.Point(1, 507);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 139);
            this.panel4.TabIndex = 13;
            // 
            // btnAracIcerikBilgileri
            // 
            this.btnAracIcerikBilgileri.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracIcerikBilgileri.Location = new System.Drawing.Point(513, 74);
            this.btnAracIcerikBilgileri.Name = "btnAracIcerikBilgileri";
            this.btnAracIcerikBilgileri.Size = new System.Drawing.Size(239, 36);
            this.btnAracIcerikBilgileri.TabIndex = 12;
            this.btnAracIcerikBilgileri.Text = "Araç İçerik Bilgilerini Göster";
            this.btnAracIcerikBilgileri.UseVisualStyleBackColor = true;
            this.btnAracIcerikBilgileri.Click += new System.EventHandler(this.btnAracIcerikBilgileri_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(120, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Araç Markası Ekleme";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1025, 642);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Araç Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbOtoparkYonetimSistemiDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.TextBox txtEklemeMarkAdi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbOtoparkYonetimSistemiDataSetBindingSource;
        private dbOtoparkYonetimSistemiDataSet dbOtoparkYonetimSistemiDataSet;
        private System.Windows.Forms.Button btnModelEkle;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.TextBox txtUretimYili;
        private System.Windows.Forms.TextBox txtMarkaID;
        private System.Windows.Forms.TextBox txtModelID2;
        private System.Windows.Forms.TextBox txtUretimYili2;
        private System.Windows.Forms.TextBox txtMarkaID2;
        private System.Windows.Forms.Button btnModeliGuncelle;
        private System.Windows.Forms.TextBox txtModelAdı2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAracModelListele;
        private System.Windows.Forms.BindingSource dbOtoparkYonetimSistemiDataSetBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAracIcerikBilgileri;
    }
}