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
    public partial class Form5 : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;

        public Form5()
        {
            InitializeComponent();
        }

        private void btnTarifeListesiniGoruntule_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spFiyatTarifesiListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void btnKampanyalariGoruntule_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spKampanyalariListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void btnUcretGuncelle_Click(object sender, EventArgs e)
        {
            int UcretID = Convert.ToInt32(txtUcretID.Text);
            decimal YeniUcret = Convert.ToDecimal(txtYeniUcret.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUcretTarifesiGuncelleme", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UcretID", UcretID);
                    cmd.Parameters.AddWithValue("@YeniUcret", YeniUcret);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Ücret tarifesi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Ücret ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnKampanyaOlustur_Click(object sender, EventArgs e)
        {
            string KampanyaAd = txtKampanyaAd.Text;
            string KampanyaAciklama = txtKampanyaAciklama.Text;
            decimal IndirimOrani = Convert.ToDecimal(txtIndirimOrani.Text);
            DateTime KampanyaBaslangic = dtpKampanyaBaslangıc.Value.Date;
            DateTime KampanyaBitis = dtpKampanyaBitis.Value.Date;
            int UcretID = Convert.ToInt32(txtUcretID2.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spYeniKampanyaEkle", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KampanyaAd", KampanyaAd);
                    cmd.Parameters.AddWithValue("@Aciklama", KampanyaAciklama);
                    cmd.Parameters.AddWithValue("@IndirimYuzdesi", IndirimOrani);
                    cmd.Parameters.AddWithValue("@KampanyaBaslangic", KampanyaBaslangic);
                    cmd.Parameters.AddWithValue("@KampanyaBitis", KampanyaBitis);
                    cmd.Parameters.AddWithValue("@UcretID", UcretID);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yeni kampanya başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnKampanyaDurumu_Click(object sender, EventArgs e)
        {
            int KampanyaID = Convert.ToInt32(txtKampanyaID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spKampanyaDurumuDegistir", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KampanyaID", KampanyaID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kampanya durumu başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Kampanya ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }    
}
