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
    public partial class Form6 : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;

        public Form6()
        {
            InitializeComponent();
        }

        private void btnPersonelKaydiYap_Click(object sender, EventArgs e)
        {
            string PersonelAd = txtPersonelAd.Text;
            string PersonelSoyad = txtPersonelSoyad.Text;
            string PersonelAdres = txtPersonelAdres.Text;
            string PersonelTelefonNo = txtPersonelTelNo.Text;
            int PersonelPozisyonNo = Convert.ToInt32(txtPozisyonNo.Text);
            int CalistigiKatNo = Convert.ToInt32(txtCalistigiKat.Text);
            int AlacagiMaas = Convert.ToInt32(txtAlacagiMaas.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spYeniPersonelKaydi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Ad", PersonelAd);
                    cmd.Parameters.AddWithValue("@Soyad", PersonelSoyad);
                    cmd.Parameters.AddWithValue("@Adres", PersonelAdres);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", PersonelTelefonNo);
                    cmd.Parameters.AddWithValue("@PozisyonNo", PersonelPozisyonNo);
                    cmd.Parameters.AddWithValue("@CalistigiKatNo", CalistigiKatNo);
                    cmd.Parameters.AddWithValue("@Maas", AlacagiMaas);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Personel kaydı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnCalisanListesi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spAktifPersonelBilgileriniListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnPozisyonlariListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spPozisyonlariListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnAyrilanListesi_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spPasifPersonelBilgileriniListele", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnPersonelCikisiYap_Click(object sender, EventArgs e)
        {
            int PersonelID = Convert.ToInt32(txtPersonelID2.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spPersonelCikisiYap", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Personel çıkışı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bu ID'ye sahip bir personel yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnPersonelBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            int PersonelID = Convert.ToInt32(txtPersonelID.Text);
            string PersonelAd = txtPersonelAd2.Text;
            string PersonelSoyad = txtPersonelSoyad2.Text;
            string PersonelAdres = txtPersonelAdres2.Text;
            string PersonelTelefonNo = txtPersonelTelNo2.Text;
            int PersonelPozisyonNo = Convert.ToInt32(txtPozisyonNo2.Text);
            int CalistigiKatNo = Convert.ToInt32(txtCalistigiKat2.Text);
            int AlacagiMaas = Convert.ToInt32(txtAlacagiMaas2.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spPersonelBilgisiGuncelle", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    cmd.Parameters.AddWithValue("@Ad", PersonelAd);
                    cmd.Parameters.AddWithValue("@Soyad", PersonelSoyad);
                    cmd.Parameters.AddWithValue("@Adres", PersonelAdres);
                    cmd.Parameters.AddWithValue("@TelefonNumarasi", PersonelTelefonNo);
                    cmd.Parameters.AddWithValue("@PozisyonNo", PersonelPozisyonNo);
                    cmd.Parameters.AddWithValue("@CalistigiKatNo", CalistigiKatNo);
                    cmd.Parameters.AddWithValue("@Maas", AlacagiMaas);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Personel bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Personel ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
