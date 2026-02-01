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
    public partial class Form7 : Form
    {

        string connectionString = ConfigurationManager
            .ConnectionStrings["OtoparkDB"]
            .ConnectionString;


        public Form7()
        {
            InitializeComponent();
        }

        private void btnPersonelGideriHesapla_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spToplamMaasHesapla", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter maasOUTPUT = new SqlParameter("@ToplamMaas", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(maasOUTPUT);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int toplamMaas = (int)maasOUTPUT.Value;

                    MessageBox.Show("Toplam Personel Gideri : " + toplamMaas.ToString() + " TL" , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnPersonelZamYap_Click(object sender, EventArgs e)
        {
            decimal TopluZamOrani = Convert.ToDecimal(txtTopluZamOrani.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spTopluZamYap", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ZamOrani", TopluZamOrani);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Toplu Zam Uygulandı !" + Environment.NewLine + Environment.NewLine +
                        "Yapılan Zam Oranı : %" + TopluZamOrani, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBireyselZam_Click(object sender, EventArgs e)
        {
            int PersonelID = Convert.ToInt32(txtPersonelID.Text);
            decimal BireyselZamOrani = Convert.ToDecimal(txtBireyselZamOrani.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spBireyselZamYap", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonelID", PersonelID);
                    cmd.Parameters.AddWithValue("@ZamOrani", BireyselZamOrani);

                    SqlParameter Sonuc = new SqlParameter("@Sonuc", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Sonuc);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    int sonuc = (int)Sonuc.Value;
                    if (sonuc == 1)
                    {
                        MessageBox.Show
                        ("Bireysel Zam Uygulandı !" + Environment.NewLine + Environment.NewLine +
                            "Personel ID : " + PersonelID + Environment.NewLine + Environment.NewLine +
                            "Yapılan Zam Oranı : %" + BireyselZamOrani, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz Personel ID'sine sahip bir kayıt yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
        }

        private void btnParkGeliriHesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpParkGelirBas.Value.Date;
            DateTime bitisTarihi = dtpParkGelirSon.Value.Date;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spAracParkGeliriHesapla", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                    SqlParameter Sonuc = new SqlParameter("@Sonuc", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Sonuc);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    Decimal sonucH = (Decimal)Sonuc.Value;

                    MessageBox.Show
                    ("Park Geliri Hesaplandı !" + Environment.NewLine + Environment.NewLine +
                        "Baslangıç - Bitiş Tarihleri : " + baslangicTarihi + " - " + bitisTarihi + Environment.NewLine + Environment.NewLine +
                        "Elde Edilen Park Geliri : " + sonucH, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                }
            }
        }

        private void btnCezaGeliriHesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpCezaGelirBas.Value.Date;
            DateTime bitisTarihi = dtpCezaGelirSon.Value.Date;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spMusteriCezaGeliriHesapla", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                    SqlParameter Sonuc = new SqlParameter("@Sonuc", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Sonuc);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    Decimal sonucH = (Decimal)Sonuc.Value;

                    MessageBox.Show
                    ("Ceza Geliri Hesaplandı !" + Environment.NewLine + Environment.NewLine +
                        "Baslangıç - Bitiş Tarihleri : " + baslangicTarihi + " - " + bitisTarihi + Environment.NewLine + Environment.NewLine +
                        "Elde Edilen Ceza Geliri : " + sonucH, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                }
            }
        }

        private void btnOdenmeyenCezalar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("spMusteriCezaOdenmeyenHesapla", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter Sonuc = new SqlParameter("@Sonuc", SqlDbType.Decimal)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(Sonuc);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    Decimal sonucH = (Decimal)Sonuc.Value;

                    MessageBox.Show
                    ("Ödenmeyen Cezalar Hesaplandı !" + Environment.NewLine + Environment.NewLine +
                        "Ödenmeyen Cezaların Toplam Tutarı : " + sonucH, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );

                }
            }
        }
    }
}
