using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public string metinselOnayKodu;

        SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");

        Form7 frm7 = new Form7();


        private void picBoxKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandevuyuAl_Click(object sender, EventArgs e)
        {

            #region Form Bilgileri

            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            Form5 frm5 = (Form5)Application.OpenForms["Form5"];

            frm7.lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";

            frm7.lblBransAdi.Text = frm5.lblBransAdi1.Text.ToUpper();
            frm7.lblTarih.Text = frm5.monthCalendar_randevuTarihleri.SelectionStart.ToLongDateString();
            frm7.lblSaat.Text = lblSaat.Text;

            #endregion

            #region Onay Kodu Oluşturma

            Random rnd = new Random();

            int sayisalOnayKodu;

            string[] dizionayKodu = new string[7]; // 7 karakterli onay kodu.

            int diziIndexArtim = 0;

            for (int i = 1; i<=7; i++)
            {
                sayisalOnayKodu = rnd.Next(0, 9);
                dizionayKodu[diziIndexArtim] = sayisalOnayKodu.ToString();
                ++diziIndexArtim;
            }

            metinselOnayKodu = dizionayKodu[0] + dizionayKodu[1] + dizionayKodu[2] + dizionayKodu[3] + dizionayKodu[4] + dizionayKodu[5]+ dizionayKodu[6];


            #endregion

            #region Randevu Onayı Bilgileri

            frm7.lblRandevuAlmaZamani.Text = DateTime.Now.ToString();
            frm7.lblSube.Text = frm5.lblBransAdi1.Text.ToUpper() + ".";
            frm7.lblRandevuTarihi.Text = frm5.monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString();
            frm7.lblRandevuSaati.Text = lblSaat.Text;
            frm7.lblHastaTCKimlikNo.Text = frm1.mskTxtTCKimlikNo.Text;
            frm7.lblHastaAd.Text = frm1.txtAd.Text.ToUpper();
            frm7.lblHastaSoyad.Text = frm1.txtSoyad.Text.ToUpper();
            frm7.lblOnayKodu1.Text = metinselOnayKodu;
            frm7.lblOnayKodu2.Text = metinselOnayKodu;

            #endregion

            #region Veritabanı İşlemleri

            sqlConn.Open();

            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;

            sqlComm.CommandTimeout = 60;
    
            sqlComm.CommandText = @"INSERT INTO TB_HastaneRandevuSistemi(HastaTCKimlikNo,HastaAd,HastaSoyad,HastaDogumTarihi,HastaCepTelefonNo,Poliklinik,RandevuTarihi,RandevuSaati,RandevuAlmaZamani,OnayKodu) VALUES(@HastaTCKimlikNo,@HastaAd,@HastaSoyad,@HastaDogumTarihi,@HastaCepTelefonNo,@Poliklinik,@RandevuTarihi,@RandevuSaati,@RandevuAlmaZamani,@OnayKodu)";

            sqlComm.Parameters.AddWithValue("@HastaTCKimlikNo", frm1.mskTxtTCKimlikNo.Text);
            sqlComm.Parameters.AddWithValue("@HastaAd", frm1.txtAd.Text);
            sqlComm.Parameters.AddWithValue("@HastaSoyad", frm1.txtSoyad.Text);
            sqlComm.Parameters.AddWithValue("@HastaDogumTarihi", frm1.mskTxtDogumTarihi.Text);
            sqlComm.Parameters.AddWithValue("@HastaCepTelefonNo", frm1.mskTxtTelefonNo.Text);
            sqlComm.Parameters.AddWithValue("@Poliklinik", frm5.lblBransAdi1.Text);
            sqlComm.Parameters.AddWithValue("@RandevuTarihi", lblTarih.Text);
            sqlComm.Parameters.AddWithValue("@RandevuSaati", lblSaat.Text);
            sqlComm.Parameters.AddWithValue("@RandevuAlmaZamani", DateTime.Now.ToString());
            sqlComm.Parameters.AddWithValue("@OnayKodu", metinselOnayKodu);

            sqlComm.ExecuteNonQuery();
            sqlComm.Dispose();
            sqlConn.Dispose();
            sqlConn.Close();


            #endregion

            frm3.Refresh();

            frm5.Visible = false;
         
            this.Visible = false;

            frm7.ShowDialog();



        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void lblSaat_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
