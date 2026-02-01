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
    public partial class Form4 : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnMusteriBilgileriniKaydet_Click(object sender, EventArgs e)
        {
            string MusteriAd = txtMusteriAd.Text;
            string MusteriSoyad = txtMusteriSoyad.Text;
            string MusteriAdres = txtMusteriAdres.Text;
            string MusteriTelefonNo = txtMusteriTelNo.Text;
            DateTime MusteriUyelikTarihi = dtpMusteriUyelikTarihi.Value.Date;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spYeniMusteriKaydi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Ad", MusteriAd);
                    cmd.Parameters.AddWithValue("@Soyad", MusteriSoyad);
                    cmd.Parameters.AddWithValue("@Adres", MusteriAdres);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", MusteriTelefonNo);
                    cmd.Parameters.AddWithValue("@MusteriUyelikTarihi", MusteriUyelikTarihi);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri üyelik kaydı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnMusteriListesiniGoruntule_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spMusteriBilgileriniListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnMusteriKayitDurumu_Click(object sender, EventArgs e)
        {
            int MusteriID = Convert.ToInt32(txtMusteriID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spUyelikDurumuDegistir", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MusteriID", MusteriID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Üyelik durumu başarıyla değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye sahip bir müşteri yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnUyelikBilgisiGuncelle_Click(object sender, EventArgs e)
        {
            int MusteriID = Convert.ToInt32(txtGMusteriID.Text);
            string MusteriAd = txtGAd.Text;
            string MusteriSoyad = txtGSoyad.Text;
            string MusteriAdres = txtGAdres.Text;
            string MusteriTelNo = txtGTelNo.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spMusteriBilgisiGuncelleme", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
                    cmd.Parameters.AddWithValue("@Ad", MusteriAd);
                    cmd.Parameters.AddWithValue("@Soyad", MusteriSoyad);
                    cmd.Parameters.AddWithValue("@Adres", MusteriAdres);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", MusteriTelNo);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Müşteri ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDestekTalepSekmesi_Click(object sender, EventArgs e)
        {
            Form4_1 destekTalepSekmesi = new Form4_1();
            destekTalepSekmesi.Show();
        }

        private void btnMusteriCezaSekmesi_Click(object sender, EventArgs e)
        {
            Form4_2 cezaSekmesi = new Form4_2();
            cezaSekmesi.Show();
        }
    }
}
