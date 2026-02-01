using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OtoparkYonetimSistemi // github.com/erensungu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAracBilgiAyar_Click(object sender, EventArgs e)
        {
            Form2 aracBilgiAyarForm = new Form2();
            aracBilgiAyarForm.Show();
        }

        private void btnAracParkBilgi_Click(object sender, EventArgs e)
        {
            Form3 aracParkBilgisi = new Form3();
            aracParkBilgisi.Show();
        }

        private void btnMusteriBilgi_Click(object sender, EventArgs e)
        {
            Form4 musteriBilgisi = new Form4();
            musteriBilgisi.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 ucretBilgisi = new Form5();
            ucretBilgisi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 personelBilgisi = new Form6();
            personelBilgisi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 finansalAjanda = new Form7();
            finansalAjanda.Show();

        }
    }
}
