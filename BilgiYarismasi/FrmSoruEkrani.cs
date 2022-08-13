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

namespace BilgiYarismasi
{
    public partial class FrmSoruEkrani : Form
    {
        public FrmSoruEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=RABIA-AYDEMIR;Initial Catalog=BilgiYarismasi;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Gray;
            btnB.BackColor = Color.Gray;
            btnC.BackColor = Color.Gray;
            btnD.BackColor = Color.Gray;
            btnBasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnBasla.Text = "SONRAKİ";
            sayac++;
            lblSoru.Text = sayac.ToString();
            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from tblSoru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtSoruEkrani.Text = (oku["soru"].ToString());
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    lblDogru.Text = (oku["cevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from tblSoru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtSoruEkrani.Text = (oku["soru"].ToString());
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    lblDogru.Text = (oku["cevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from tblSoru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtSoruEkrani.Text = (oku["soru"].ToString());
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    lblDogru.Text = (oku["cevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from tblSoru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtSoruEkrani.Text = (oku["soru"].ToString());
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    lblDogru.Text = (oku["cevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 5)
            { 
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from tblSoru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    txtSoruEkrani.Text = (oku["soru"].ToString());
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    lblDogru.Text = (oku["cevap"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                btnBasla.Text = "OYUN BİTTİ";
                btnBasla.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
            }
        }

        private void FrmSoruEkrani_Load(object sender, EventArgs e)
        {
            lblSoru.Text = sayac.ToString();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == lblDogru.Text)
            {
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            {
                btnA.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lblDogru.Text)
            {
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                btnB.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lblDogru.Text)
            {
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                btnC.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lblDogru.Text)
            {
                puan += 10;
                lblPuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                btnD.BackColor = Color.Red;
            }
            btnBasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
    }
}
