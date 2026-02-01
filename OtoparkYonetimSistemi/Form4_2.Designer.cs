namespace OtoparkYonetimSistemi
{
    partial class Form4_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCezaUygula = new System.Windows.Forms.Button();
            this.dtpCezaBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUygulananYaptirim = new System.Windows.Forms.TextBox();
            this.txtCezaSebebi = new System.Windows.Forms.TextBox();
            this.txtCezaTutari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCezaID = new System.Windows.Forms.TextBox();
            this.btnOdenmeDurumuDegistir = new System.Windows.Forms.Button();
            this.btnGecmisCezalar = new System.Windows.Forms.Button();
            this.btnGuncelCezalar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.txtMusteriID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCezaUygula);
            this.panel1.Controls.Add(this.dtpCezaBitisTarihi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUygulananYaptirim);
            this.panel1.Controls.Add(this.txtCezaSebebi);
            this.panel1.Controls.Add(this.txtCezaTutari);
            this.panel1.Location = new System.Drawing.Point(-4, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 284);
            this.panel1.TabIndex = 15;
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMusteriID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriID.Location = new System.Drawing.Point(679, 62);
            this.txtMusteriID.Multiline = true;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(266, 33);
            this.txtMusteriID.TabIndex = 22;
            this.txtMusteriID.Text = "Müşteri ID";
            this.txtMusteriID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(725, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ceza Bitiş Tarihi";
            // 
            // btnCezaUygula
            // 
            this.btnCezaUygula.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCezaUygula.Location = new System.Drawing.Point(679, 226);
            this.btnCezaUygula.Name = "btnCezaUygula";
            this.btnCezaUygula.Size = new System.Drawing.Size(266, 33);
            this.btnCezaUygula.TabIndex = 20;
            this.btnCezaUygula.Text = "Ceza Kaydı Yap";
            this.btnCezaUygula.UseVisualStyleBackColor = true;
            this.btnCezaUygula.Click += new System.EventHandler(this.btnCezaUygula_Click);
            // 
            // dtpCezaBitisTarihi
            // 
            this.dtpCezaBitisTarihi.Location = new System.Drawing.Point(679, 192);
            this.dtpCezaBitisTarihi.Name = "dtpCezaBitisTarihi";
            this.dtpCezaBitisTarihi.Size = new System.Drawing.Size(266, 22);
            this.dtpCezaBitisTarihi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "Uygulanan Yaptırım";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ceza Sebebi";
            // 
            // txtUygulananYaptirim
            // 
            this.txtUygulananYaptirim.BackColor = System.Drawing.Color.White;
            this.txtUygulananYaptirim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUygulananYaptirim.Location = new System.Drawing.Point(45, 188);
            this.txtUygulananYaptirim.Multiline = true;
            this.txtUygulananYaptirim.Name = "txtUygulananYaptirim";
            this.txtUygulananYaptirim.Size = new System.Drawing.Size(482, 71);
            this.txtUygulananYaptirim.TabIndex = 16;
            // 
            // txtCezaSebebi
            // 
            this.txtCezaSebebi.BackColor = System.Drawing.Color.White;
            this.txtCezaSebebi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCezaSebebi.Location = new System.Drawing.Point(45, 62);
            this.txtCezaSebebi.Multiline = true;
            this.txtCezaSebebi.Name = "txtCezaSebebi";
            this.txtCezaSebebi.Size = new System.Drawing.Size(482, 71);
            this.txtCezaSebebi.TabIndex = 14;
            // 
            // txtCezaTutari
            // 
            this.txtCezaTutari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCezaTutari.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCezaTutari.Location = new System.Drawing.Point(679, 118);
            this.txtCezaTutari.Multiline = true;
            this.txtCezaTutari.Name = "txtCezaTutari";
            this.txtCezaTutari.Size = new System.Drawing.Size(266, 33);
            this.txtCezaTutari.TabIndex = 1;
            this.txtCezaTutari.Text = "Ceza Tutarı";
            this.txtCezaTutari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 245);
            this.dataGridView1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.txtCezaID);
            this.panel2.Controls.Add(this.btnOdenmeDurumuDegistir);
            this.panel2.Controls.Add(this.btnGecmisCezalar);
            this.panel2.Controls.Add(this.btnGuncelCezalar);
            this.panel2.Location = new System.Drawing.Point(-4, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 101);
            this.panel2.TabIndex = 16;
            // 
            // txtCezaID
            // 
            this.txtCezaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCezaID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCezaID.Location = new System.Drawing.Point(92, 10);
            this.txtCezaID.Multiline = true;
            this.txtCezaID.Name = "txtCezaID";
            this.txtCezaID.Size = new System.Drawing.Size(266, 33);
            this.txtCezaID.TabIndex = 25;
            this.txtCezaID.Text = "Ceza ID";
            this.txtCezaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOdenmeDurumuDegistir
            // 
            this.btnOdenmeDurumuDegistir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdenmeDurumuDegistir.Location = new System.Drawing.Point(92, 49);
            this.btnOdenmeDurumuDegistir.Name = "btnOdenmeDurumuDegistir";
            this.btnOdenmeDurumuDegistir.Size = new System.Drawing.Size(266, 33);
            this.btnOdenmeDurumuDegistir.TabIndex = 24;
            this.btnOdenmeDurumuDegistir.Text = "Ödenme Durumunu Değiştir";
            this.btnOdenmeDurumuDegistir.UseVisualStyleBackColor = true;
            this.btnOdenmeDurumuDegistir.Click += new System.EventHandler(this.btnOdenmeDurumuDegistir_Click);
            // 
            // btnGecmisCezalar
            // 
            this.btnGecmisCezalar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisCezalar.Location = new System.Drawing.Point(679, 49);
            this.btnGecmisCezalar.Name = "btnGecmisCezalar";
            this.btnGecmisCezalar.Size = new System.Drawing.Size(266, 33);
            this.btnGecmisCezalar.TabIndex = 23;
            this.btnGecmisCezalar.Text = "Geçmiş Ceza Kayıtlarını Listele";
            this.btnGecmisCezalar.UseVisualStyleBackColor = true;
            this.btnGecmisCezalar.Click += new System.EventHandler(this.btnGecmisCezalar_Click);
            // 
            // btnGuncelCezalar
            // 
            this.btnGuncelCezalar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelCezalar.Location = new System.Drawing.Point(679, 8);
            this.btnGuncelCezalar.Name = "btnGuncelCezalar";
            this.btnGuncelCezalar.Size = new System.Drawing.Size(266, 33);
            this.btnGuncelCezalar.TabIndex = 22;
            this.btnGuncelCezalar.Text = "Güncel Ceza Kayıtlarını Listele";
            this.btnGuncelCezalar.UseVisualStyleBackColor = true;
            this.btnGuncelCezalar.Click += new System.EventHandler(this.btnGuncelCezalar_Click);
            // 
            // Form4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4_2";
            this.ShowIcon = false;
            this.Text = "Müşteri Ceza Bilgileri Sayfası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCezaTutari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCezaSebebi;
        private System.Windows.Forms.TextBox txtUygulananYaptirim;
        private System.Windows.Forms.DateTimePicker dtpCezaBitisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCezaUygula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGecmisCezalar;
        private System.Windows.Forms.Button btnGuncelCezalar;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Button btnOdenmeDurumuDegistir;
        private System.Windows.Forms.TextBox txtCezaID;
    }
}