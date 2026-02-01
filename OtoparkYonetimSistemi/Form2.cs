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
    public partial class Form2 : Form
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDb"]
            .ConnectionString;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            string markaAdi = txtEklemeMarkAdi.Text.Trim();
            txtEklemeMarkAdi.Clear();

            if (string.IsNullOrEmpty(markaAdi))
            {
                MessageBox.Show("Lütfen marka adı giriniz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracMarkasiEkle", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarkaAd", markaAdi);

                    SqlParameter sonucParam = new SqlParameter("@Sonuc", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(sonucParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)cmd.Parameters["@Sonuc"].Value;

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Marka başarıyla eklendi.");
                    }
                    else if (sonuc == -1)
                    {
                        MessageBox.Show("Bu marka zaten mevcut.");
                    }
                    else
                    {
                        MessageBox.Show("Bilinmeyen bir hata oluştu.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracMarkalariGetir", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            string ModelAd = txtModelAdi.Text;
            int MarkaID = Convert.ToInt32(txtMarkaID.Text);
            int UretimYili = Convert.ToInt32(txtUretimYili.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spYeniAracModeli", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AracModelAd", ModelAd);
                    cmd.Parameters.AddWithValue("@AracMarkaNo", MarkaID);
                    cmd.Parameters.AddWithValue("@AracUretimYili", UretimYili);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Müşteri üyelik kaydı başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnModeliGuncelle_Click(object sender, EventArgs e)
        {
            int ModelID = Convert.ToInt32(txtModelID2.Text);
            string ModelAd = txtModelAdı2.Text;
            int MarkaID = Convert.ToInt32(txtMarkaID2.Text);
            int UretimYili = Convert.ToInt32(txtUretimYili2.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracModeliGuncelleme", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ModelID", ModelID);
                    cmd.Parameters.AddWithValue("@AracModelAd", ModelAd);
                    cmd.Parameters.AddWithValue("@AracUretimYili", UretimYili);
                    cmd.Parameters.AddWithValue("@AracMarkaNo", MarkaID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Araç model bilgisi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Araç Model ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnAracModelListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracModelleriGetir", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnAracIcerikBilgileri_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracIcerikBilgiListele", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    conn.Open();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
