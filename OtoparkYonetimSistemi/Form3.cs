using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace OtoparkYonetimSistemi
{
    public partial class Form3 : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDb"]
            .ConnectionString;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnParkEdilmisAraclar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spAracParkBilgileriniGetir", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnAracGirisiYap_Click(object sender, EventArgs e)
        {
            string AracPlaka = txtAracPlaka.Text;
            int AracModelNo = Convert.ToInt32(txtAracModelNo.Text);
            int AracIcerikNo = Convert.ToInt32(txtAracIcerikNo.Text);
            int MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
            int ParkAlaniNo = Convert.ToInt32(txtParkAlaniNo.Text);
            DateTime ParkTarihi = dtpParkTarihi.Value.Date;
            TimeSpan ParkSaati = dtpParkSaati.Value.TimeOfDay;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracParkEkle", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AracPlaka", AracPlaka);
                    cmd.Parameters.AddWithValue("@AracModelNo", AracModelNo);
                    cmd.Parameters.AddWithValue("@AracIcerikNo", AracIcerikNo);
                    cmd.Parameters.AddWithValue("@MusteriNo", MusteriNo);
                    cmd.Parameters.AddWithValue("@ParkAlaniNo", ParkAlaniNo);
                    cmd.Parameters.AddWithValue("@ParkTarihi", ParkTarihi);
                    cmd.Parameters.AddWithValue("@ParkSaati", ParkSaati);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Araç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (sonuc == 2)
                    {
                        MessageBox.Show("Girdiğiniz park alanı dolu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Bu plakaya ait kayıt zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnParkAlanlariGoster_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spParkAlanlariDurumListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnAracCıkısıYap_Click(object sender, EventArgs e)
        {
            int AracParkID = Convert.ToInt32(txtAracParkID.Text);
            int KampanyaID = Convert.ToInt32(txtKampanyaID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spHesaplaAracParkUcreti", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AracParkID", AracParkID);
                    cmd.Parameters.AddWithValue("@Kampanya", KampanyaID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SqlParameter OdenenOUTPUT = new SqlParameter("@OdenenTutar", SqlDbType.Decimal);
                    OdenenOUTPUT.Precision = 10;
                    OdenenOUTPUT.Scale = 2;
                    SqlParameter KampanyaAdOUTPUT = new SqlParameter("@KampanyaAd", SqlDbType.NVarChar, 100);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    OdenenOUTPUT.Direction = ParameterDirection.Output;
                    KampanyaAdOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);
                    cmd.Parameters.Add(OdenenOUTPUT);
                    cmd.Parameters.Add(KampanyaAdOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Araç çıkışı yapıldı !" + Environment.NewLine + Environment.NewLine +
                        "Ödenen Tutar : " + Environment.NewLine + Environment.NewLine +
                        "Uygulanan Kampanya : ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Park alanında bu ID'ye sahip bir araç yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracCikisYap", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AracParkID", AracParkID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                }
            }
        }

        private void btnGecmisAracKaydiGoster_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spLogAracParkKaydiListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }
    }
}
