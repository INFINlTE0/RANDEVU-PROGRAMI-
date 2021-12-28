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

namespace Randevu_Sistemi
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        #region Bildirimler & Tanımlamalar

        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        Form2 frm2 = (Form2)Application.OpenForms["Form2"];
        Form3 frm3 = (Form3)Application.OpenForms["Form3"];
        Form4 frm4 = (Form4)Application.OpenForms["Form4"];
        Form5 frm5 = (Form5)Application.OpenForms["Form5"];
        Form6 frm6 = (Form6)Application.OpenForms["Form6"];
        Form7 frm7 = (Form7)Application.OpenForms["Form7"];

        SqlDataReader sqlDtRdr;

        #endregion

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView1.Enabled = true;

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";

            #region Koşullu Bir Şekilde Veritabanına Veri Ekleme

            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");
            sqlConn.Open();

            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandTimeout = 60;
            sqlComm.CommandText = @"SELECT RandevuTarihi,RandevuSaati,Poliklinik,OnayKodu FROM TB_HastaneRandevuSistemi WHERE HastaTCKimlikNo = '" + frm1.mskTxtTCKimlikNo.Text + "' AND HastaAd = '" + frm1.txtAd.Text + "' AND HastaSoyad = '" + frm1.txtSoyad.Text + "' AND HastaDogumTarihi = '" + frm1.mskTxtDogumTarihi.Text + "' ";

            sqlDtRdr = sqlComm.ExecuteReader();

            while (sqlDtRdr.Read())
            {
                if (string.Compare(sqlDtRdr["RandevuTarihi"].ToString(), DateTime.Now.ToShortDateString()) != -1)
                {
                    dataGridView1.Rows.Add(sqlDtRdr["RandevuTarihi"], sqlDtRdr["RandevuSaati"], sqlDtRdr["Poliklinik"], sqlDtRdr["OnayKodu"]);
                }
                    
            }

            sqlConn.Close();
            sqlConn.Dispose();
            sqlComm.Dispose();

            #endregion


            #region DataGridView'deki Satırların Stil Ayarlamaları ve İslem Column'un Cells'lerinin Stil Ayarları

            foreach (DataGridViewRow satir in dataGridView1.Rows)
            {
                satir.Cells[4].Style.BackColor = Color.Orange;
                satir.Cells[4].Style.Font = new Font("Arial", 9, FontStyle.Bold);
                satir.Cells[4].Style.ForeColor = Color.White;

                satir.Height = 27;

            }


            #endregion


            #region Veritabanında Hiç Veri Yoksa

            SqlConnection sqlConnHicRandevuYoksa = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");
            sqlConnHicRandevuYoksa.Open();

            SqlCommand sqlCommHicRandevuYoksa = new SqlCommand();
            sqlCommHicRandevuYoksa.Connection = sqlConnHicRandevuYoksa;
            sqlCommHicRandevuYoksa.CommandTimeout = 60;
            sqlCommHicRandevuYoksa.CommandText = @"SELECT COUNT(*) FROM  TB_HastaneRandevuSistemi WHERE HastaTCKimlikNo = '" + frm1.mskTxtTCKimlikNo.Text + "' AND HastaAd = '" + frm1.txtAd.Text + "' AND HastaSoyad = '" + frm1.txtSoyad.Text + "' AND HastaDogumTarihi = '" + frm1.mskTxtDogumTarihi.Text + "'  ";

            int toplamRandevuSayisi = (int)sqlCommHicRandevuYoksa.ExecuteScalar();


            #endregion

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");
            sqlConn.Open();

            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandTimeout = 60;

            sqlComm.CommandText = @"DELETE FROM TB_HastaneRandevuSistemi WHERE OnayKodu = '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "' ";


            if (e.ColumnIndex == 4)
            {
                sqlComm.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                frm3.Refresh();

                sqlConn.Close();
                sqlConn.Dispose();
                sqlComm.Dispose();



            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
        {
            btnAnasayfa.BackColor = Color.Red;
        }

        private void btnAnasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            btnAnasayfa.BackColor = SystemColors.WindowFrame;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Red;
        }

        private void btnCikis_MouseMove(object sender, MouseEventArgs e)
        {
            btnCikis.BackColor = SystemColors.WindowFrame;
        }


    }
}