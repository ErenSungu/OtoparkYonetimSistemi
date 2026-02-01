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
    public partial class Form4_1 : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;


        public Form4_1()
        {
            InitializeComponent();
        }

        private void btnCevapOlustur_Click(object sender, EventArgs e)
        {
            string TalepCevabi = txtTalepCevabi.Text;
            int DestekID = Convert.ToInt32(txtDestekID.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDestekTalepCevapla", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DestekID", DestekID);
                    cmd.Parameters.AddWithValue("@TalepCevabi", TalepCevabi);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Destek talebi başarıyla yanıtlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Destek ID'ye ait kayıt bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnTalepDurumuDegistir_Click(object sender, EventArgs e)
        {
            int DestekID = Convert.ToInt32(txtDestekID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spTalepDurumuDegistir", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DestekID", DestekID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Destek talebi durumu başarıyla değişti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Destek ID'ye ait kayıt bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnDestekGoruntule_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spDestekTalepBilgileriniListele", conn))
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

        private void btnCevapDuzenle_Click(object sender, EventArgs e)
        {
            string TalepCevabi = txtTalepCevabi.Text;
            int DestekID = Convert.ToInt32(txtDestekID.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spTalepCevabiGuncelle", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DestekID", DestekID);
                    cmd.Parameters.AddWithValue("@YeniTalepCevabi", TalepCevabi);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Destek talebi başarıyla düzenlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Destek ID'ye ait kayıt bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_TalepIcerikleri_Click(object sender, EventArgs e)
        {
            int DestekID = Convert.ToInt32(txtDestekID.Text);


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spTalepMetniGetir", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DestekID", DestekID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    SqlParameter TalepMetni = new SqlParameter("@TalepMetni", SqlDbType.NVarChar, -1);
                    TalepMetni.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(TalepMetni);

                    SqlParameter TalepCevabi = new SqlParameter("@TalepCevabi", SqlDbType.NVarChar, -1);
                    TalepCevabi.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(TalepCevabi);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    string talepMetni = TalepMetni.Value.ToString();
                    string talepCevabi = TalepCevabi.Value.ToString();

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Talep Metni : " + talepMetni + Environment.NewLine + Environment.NewLine + "Cevap Metni : " + talepCevabi , "İletişim Geçmişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Destek ID'ye ait kayıt bulunmamaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
