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
    public partial class Form4_2 : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;


        public Form4_2()
        {
            InitializeComponent();
        }

        private void btnCezaUygula_Click(object sender, EventArgs e)
        {
            int MusteriID = Convert.ToInt32(txtMusteriID.Text);
            int CezaTutari = Convert.ToInt32(txtCezaTutari.Text);
            string CezaSebebi = txtCezaSebebi.Text;
            string CezaYaptirim = txtUygulananYaptirim.Text;
            DateTime CezaBitisTarihi = dtpCezaBitisTarihi.Value.Date;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spYeniCezaKaydi", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MusteriNo", MusteriID);
                    cmd.Parameters.AddWithValue("@CezaTutari", CezaTutari);
                    cmd.Parameters.AddWithValue("@CezaSebebi", CezaSebebi);
                    cmd.Parameters.AddWithValue("@AldigiYaptirim", CezaYaptirim);
                    cmd.Parameters.AddWithValue("@CezaBitisTarihi", CezaBitisTarihi);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Ceza kaydı oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Müşteri ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnGuncelCezalar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spAktifCezalar", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnGecmisCezalar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("spPasifCezalar", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnOdenmeDurumuDegistir_Click(object sender, EventArgs e)
        {
            int CezaID = Convert.ToInt32(txtCezaID.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spOdenmeDurumuDegistir", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CezaID", CezaID);

                    SqlParameter SonucOUTPUT = new SqlParameter("@Sonuc", SqlDbType.Int);
                    SonucOUTPUT.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(SonucOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)SonucOUTPUT.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Ceza ödenme durumu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Ceza ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
