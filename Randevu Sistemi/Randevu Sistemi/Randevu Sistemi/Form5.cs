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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        Form6 frm6 = new Form6();

        private void Form5_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";


            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm4deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm4deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm4.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm4.monthCalendar_randevuTarihleri.SelectionStart;


            SqlConnection sqlConn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Application.StartupPath + "\\DBHastaneRandevuSistemiOtomasyonu.mdf; Integrated Security = True;");

            sqlConn.Open();


            #region Polikliniklerin Saat Ayarlamaları

            #region Beyin ve Sinir Cerrahisi Saat Ayarlamaları

            if (frm4.lblBolumİsmi.Text == "Beyin ve Sinir\nCerrahisi")
            {
                #region Saat 9 İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:00' ", sqlConn);

                int saatDokuzSonucBeyinveSinirCerrahisi = (int)sqlCommSaatDokuzBeyinveSinirCerrahisi.ExecuteScalar();

                if (saatDokuzSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatDokuz.Visible = false;
                    lblSaatDokuz.Visible = false;
                }
                else
                {
                    picBoxSaatDokuz.Visible = true;
                    lblSaatDokuz.Visible = true;
                }

                #endregion

                #region Saat 9Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatDokuzBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '09:30' ", sqlConn);

                int saatDokuzBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatDokuzBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (saatDokuzBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatDokuzBucuk.Visible = false;
                    lblSaatDokuzBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatDokuzBucuk.Visible = true;
                    lblSaatDokuzBucuk.Visible = true;
                }

                #endregion

                #region Saat 10 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:00' ", sqlConn);

                int SaatOnSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOn.Visible = false;
                    lblSaatOn.Visible = false;
                }
                else
                {
                    picBoxSaatOn.Visible = true;
                    lblSaatOn.Visible = true;
                }

                #endregion

                #region Saat 10Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '10:30' ", sqlConn);

                int SaatOnBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBucuk.Visible = false;
                    lblSaatOnBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBucuk.Visible = true;
                    lblSaatOnBucuk.Visible = true;
                }

                #endregion

                #region Saat 11 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:00' ", sqlConn);

                int SaatOnBirSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBirBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBirSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBir.Visible = false;
                    lblSaatOnBir.Visible = false;
                }
                else
                {
                    picBoxSaatOnBir.Visible = true;
                    lblSaatOnBir.Visible = true;
                }

                #endregion

                #region Saat 11Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBirBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '11:30' ", sqlConn);

                int SaatOnBirBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBirBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBirBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBirBucuk.Visible = false;
                    lblSaatOnBirBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnBirBucuk.Visible = true;
                    lblSaatOnBirBucuk.Visible = true;
                }

                #endregion

                #region Saat 12 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:00' ", sqlConn);

                int SaatOnİkiSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnİkiBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnİkiSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnİki.Visible = false;
                    lblSaatOnİki.Visible = false;
                }
                else
                {
                    picBoxSaatOnİki.Visible = true;
                    lblSaatOnİki.Visible = true;
                }

                #endregion

                #region Saat 12Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnİkiBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '12:30' ", sqlConn);

                int SaatOnİkiBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnİkiBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnİkiBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnİkiOtuz.Visible = false;
                    lblSaatOnİkiBucuk.Visible = false;
                }
                else
                {
                    picBoxSaatOnİkiOtuz.Visible = true;
                    lblSaatOnİkiBucuk.Visible = true;
                }

                #endregion

                #region Saat 13 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:00' ", sqlConn);

                int SaatOnUcSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnUcBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnUcSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnUc.Visible = false;
                    lblSaatOnUc.Visible = false;
                }
                else
                {
                    picBoxSaatOnUc.Visible = true;
                    lblSaatOnUc.Visible = true;
                }

                #endregion

                #region Saat 13Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnUcBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '13:30' ", sqlConn);

                int SaatOnUcBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnUcBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnUcBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnUcOtuz.Visible = false;
                    lblSaatOnUcOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnUcOtuz.Visible = true;
                    lblSaatOnUcOtuz.Visible = true;
                }

                #endregion

                #region Saat 14 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:00' ", sqlConn);

                int SaatOnDörtSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDörtBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnDörtSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnDört.Visible = false;
                    lblSaatOnDört.Visible = false;
                }
                else
                {
                    picBoxSaatOnDört.Visible = true;
                    lblSaatOnDört.Visible = true;
                }


                #endregion

                #region Saat 14Bucuk İçin Ayarlamalar

                SqlCommand sqlCommSaatOnDörtBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '14:30' ", sqlConn);

                int SaatOnDörtBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDörtBucukBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnDörtBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnDörtOtuz.Visible = false;
                    lblSaatOnDörtOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnDörtOtuz.Visible = true;
                    lblSaatOnDörtOtuz.Visible = true;
                }

                #endregion

                #region Saat 15 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:00' ", sqlConn);

                int SaatOnBesSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBesBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBesSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBes.Visible = false;
                    lblSaatOnBes.Visible = false;
                }
                else
                {
                    picBoxSaatOnBes.Visible = true;
                    lblSaatOnBes.Visible = true;
                }

                #endregion

                #region Saat 15Otuz İçin Ayarlamalar

                SqlCommand sqlCommSaatOnBesOtuzBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '15:30' ", sqlConn);

                int SaatOnBesOtuzSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnBesOtuzBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnBesOtuzSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnBesOtuz.Visible = false;
                    lblSaatOnBesOtuz.Visible = false;
                }
                else
                {
                    picBoxSaatOnBesOtuz.Visible = true;
                    lblSaatOnBesOtuz.Visible = true;
                }

                #endregion

                #region Saat 16 İçin Ayarlamalar

                SqlCommand sqlCommSaatOnAltıBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '16:00' ", sqlConn);

                int SaatOnAltıSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnAltıBeyinveSinirCerrahisi.ExecuteScalar();

                if (SaatOnAltıSonucBeyinveSinirCerrahisi >= 1)
                {
                    picBoxSaatOnAltı.Visible = false;
                    lblSaatOnAltı.Visible = false;
                }
                else
                {
                    picBoxSaatOnAltı.Visible = true;
                    lblSaatOnAltı.Visible = true;
                }

                #endregion


                #region Saat 17 bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatOnYediBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '17:00' ", sqlConn);

                int SaatOnYediSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnYediBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnYediSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnYedi.Visible = false;
                    lblSaatOnYedi.Visible = false;
                }
                else
                {
                    picboxSaatOnYedi.Visible = true;
                    lblSaatOnYedi.Visible = true;
                }
                #endregion

                #region Saat 17 bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatOnYediBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '17:30' ", sqlConn);

                int SaatOnYediBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnYediBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnYediBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnYediBuçuk.Visible = false;
                    lblSaatOnYediBucuk.Visible = false;
                }
                else
                {
                    picboxSaatOnYediBuçuk.Visible = true;
                    lblSaatOnYediBucuk.Visible = true;
                }
                #endregion

                #region Saat 18 İçin Ayarlamalar
                SqlCommand sqlCommSaatOnSekizBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '18:00' ", sqlConn);

                int SaatOnSekizSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnSekizBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnSekizSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnSekiz.Visible = false;
                    lblSaatOnSekiz.Visible = false;
                }
                else
                {
                    picboxSaatOnSekiz.Visible = true;
                    lblSaatOnSekiz.Visible = true;
                }
                #endregion

                #region Saat 18Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatOnSekizBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '18:30' ", sqlConn);

                int SaatOnSekizBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnSekizBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnSekizBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnSekizBuçuk.Visible = false;
                    lblSaatOnSekizBucuk.Visible = false;
                }
                else
                {
                    picboxSaatOnSekizBuçuk.Visible = true;
                    lblSaatOnSekizBucuk.Visible = true;
                }
                #endregion


                #region Saat 19 İçin Ayarlamalar
                SqlCommand sqlCommSaatOnDokuzBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '19:00' ", sqlConn);

                int SaatOnDokuzSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDokuzBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnDokuzSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnDokuz.Visible = false;
                    lblSaatOnDokuz.Visible = false;
                }
                else
                {
                    picboxSaatOnDokuz.Visible = true;
                    lblSaatOnDokuz.Visible = true;
                }
                #endregion

                #region Saat 19Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatOnDokuzBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '19:30' ", sqlConn);

                int SaatOnDokuzBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatOnDokuzBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatOnDokuzBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatOnDokuzBuçuk.Visible = false;
                    lblSaatOnDokuzBucuk.Visible = false;
                }
                else
                {
                    picboxSaatOnDokuzBuçuk.Visible = true;
                    lblSaatOnDokuzBucuk.Visible = true;
                }
                #endregion

                #region Saat 20 İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '20:00' ", sqlConn);

                int SaatYirmiSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmi.Visible = false;
                    lblSaatYirmi.Visible = false;
                }
                else
                {
                    picboxSaatYirmi.Visible = true;
                    lblSaatYirmi.Visible = true;
                }
                #endregion

                #region Saat 20Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '20:30' ", sqlConn);

                int SaatYirmiBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiBuçuk.Visible = false;
                    lblSaatYirmiBucuk.Visible = false;
                }
                else
                {
                    picboxSaatYirmiBuçuk.Visible = true;
                    lblSaatYirmiBucuk.Visible = true;
                }
                #endregion

                #region Saat 21 İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiBirBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '21:00' ", sqlConn);

                int SaatYirmiBirSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiBirBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiBirSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiBir.Visible = false;
                    lblSaatYirmiBir.Visible = false;
                }
                else
                {
                    picboxSaatYirmiBir.Visible = true;
                    lblSaatYirmiBir.Visible = true;
                }
                #endregion


                #region Saat 21Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiBirBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '21:30' ", sqlConn);

                int SaatYirmiBirBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiBirBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiBirBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiBirBuçuk.Visible = false;
                    lblSaatYirmiBirBucuk.Visible = false;
                }
                else
                {
                    picboxSaatYirmiBirBuçuk.Visible = true;
                    lblSaatYirmiBirBucuk.Visible = true;
                }
                #endregion


                #region Saat 22 İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiİkiBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '22:00' ", sqlConn);

                int SaatYirmiİkiSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiİkiBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiİkiSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiİki.Visible = false;
                    lblSaatYirmiİki.Visible = false;
                }
                else
                {
                    picboxSaatYirmiİki.Visible = true;
                    lblSaatYirmiİki.Visible = true;
                }
                #endregion


                #region Saat 22Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiİkiBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '22:30' ", sqlConn);

                int SaatYirmiİkiBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiİkiBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiİkiBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiİkiBuçuk.Visible = false;
                    lblSaatYirmiİkiBucuk.Visible = false;
                }
                else
                {
                    picboxSaatYirmiİkiBuçuk.Visible = true;
                    lblSaatYirmiİkiBucuk.Visible = true;
                }
                #endregion


                #region Saat 23 İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiÜçBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '23:00' ", sqlConn);

                int SaatYirmiÜçSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiÜçBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiÜçSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiÜç.Visible = false;
                    lblSaatYirmiÜc.Visible = false;
                }
                else
                {
                    picboxSaatYirmiÜç.Visible = true;
                    lblSaatYirmiÜc.Visible = true;
                }
                #endregion


                #region Saat 23Bucuk İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiÜçBucukBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '23:30' ", sqlConn);

                int SaatYirmiÜçBucukSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiÜçBucukBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiÜçBucukSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiÜçBuçuk.Visible = false;
                    lblSaatYirmiÜcBucuk.Visible = false;
                }
                else
                {
                    picboxSaatYirmiÜçBuçuk.Visible = true;
                    lblSaatYirmiÜcBucuk.Visible = true;
                }
                #endregion


                #region Saat 24 İçin Ayarlamalar
                SqlCommand sqlCommSaatYirmiDörtBeyinveSinirCerrahisi = new SqlCommand("SELECT COUNT(RandevuSaati) FROM TB_HastaneRandevuSistemi WHERE Poliklinik = 'Beyin ve Sinir Cerrahisi' AND RandevuTarihi = '" + monthCalendar_randevuTarihleri.SelectionStart.ToShortDateString() + "' AND RandevuSaati = '00:00' ", sqlConn);

                int SaatYirmiDörtSonucBeyinveSinirCerrahisi = (int)sqlCommSaatYirmiDörtBeyinveSinirCerrahisi.ExecuteScalar();
                if (SaatYirmiDörtSonucBeyinveSinirCerrahisi >= 1)
                {
                    picboxSaatYirmiDört.Visible = false;
                    lblSaatYirmiDört.Visible = false;
                }
                else
                {
                    picboxSaatYirmiDört.Visible = true;
                    lblSaatYirmiDört.Visible = true;
                }
                #endregion



                 }

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




            #endregion


        }

        private void picBoxGeri_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            this.Visible = false;

            frm3.Refresh();
            frm4.Refresh();
            frm4.Visible = true;
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form frm8 = new Form8();

            frm8.ShowDialog();
        }


        #region PicBox'ların Saat Ayarlamaları

        private void picBoxSaatDokuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion


            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatDokuz.Text;

            frm6.ShowDialog();


        }

        private void picBoxSaatDokuzBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatDokuzBucuk.Text;



            frm6.ShowDialog();

        }

        private void picBoxSaatOn_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOn.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatSaatOnBir_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBir.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBirBucuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBirBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnİki_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnİki.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnİkiOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnİkiBucuk.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnUc_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnUc.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnUcOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnUcOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnDört_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDört.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnDörtOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDörtOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBes_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBes.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnBesOtuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            #endregion

            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnBesOtuz.Text;

            frm6.ShowDialog();
        }

        private void picBoxSaatOnAltı_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnAltı.Text;

            frm6.ShowDialog();
        }



        #endregion


        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();

        }

        private void btnRandevularım_MouseLeave(object sender, EventArgs e)
        {
            btnRandevularım.BackColor = Color.Orange;
        }

        private void btnRandevularım_MouseMove(object sender, MouseEventArgs e)
        {
            btnRandevularım.BackColor = SystemColors.WindowFrame;
        }

        private void btnCikis_MouseMove(object sender, MouseEventArgs e)
        {
            btnCikis.BackColor = SystemColors.WindowFrame;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Orange;
        }

        private void picboxSaatOnYedi_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnYedi.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatOnYediBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnYediBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatOnSekiz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnSekiz.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatOnSekizBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnSekizBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatOnDokuz_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDokuz.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatOnDokuzBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatOnDokuzBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmi_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmi.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiBir_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiBir.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiBirBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiBirBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiİki_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiİki.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiİkiBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiİkiBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiÜç_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiÜc.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiÜçBuçuk_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiÜcBucuk.Text;

            frm6.ShowDialog();
        }

        private void picboxSaatYirmiDört_Click(object sender, EventArgs e)
        {
            Form4 frm4 = (Form4)Application.OpenForms["Form4"];

            #region Form6 Bölümlerin Metin Ayarlamaları

            if (lblBransAdi1.Text == "Kulak-Burun-Boğaz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Kulak-Burun-Boğaz Hast.";
                frm6.lblBransAdi2.Text = "Kulak-Burun-Boğaz Hast.";

                frm6.lblBransAdi2.Location = new Point(400, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Plastik ve Estetik Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Plastik ve Estetik Cerrah.";
                frm6.lblBransAdi2.Text = "Plastik ve Estetik Cerrahisi";

                frm6.lblBransAdi2.Location = new Point(405, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kadın Hastalıkları ve Doğum")
            {
                frm6.lblBransAdi1.Text = "Kadın Hast. ve Doğum";
                frm6.lblBransAdi2.Text = "Kadın Hast. ve Doğum";

                frm6.lblBransAdi1.Location = new Point(61, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(420, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Endokronoloji ve Metabolizma")
            {
                frm6.lblBransAdi1.Text = "Endokronoloji ve Metab.";
                frm6.lblBransAdi2.Text = "Endokronoloji ve Metab.";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Fiziksel Tıp ve Rehabilitasyon")
            {
                frm6.lblBransAdi1.Text = "Fiziksel Tıp ve Rehabilit.";
                frm6.lblBransAdi2.Text = "Fiziksel Tıp ve Rehabilit.";

                frm6.lblBransAdi2.Location = new Point(412, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Beyin ve Sinir Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Beyin ve Sinir Cerrah.";
                frm6.lblBransAdi2.Text = "Beyin ve Sinir Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(65, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(415, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kardiyoloji")
            {
                frm6.lblBransAdi1.Text = "Kardiyoloji";
                frm6.lblBransAdi2.Text = "Kardiyoloji";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nöroloji")
            {
                frm6.lblBransAdi1.Text = "Nöroloji";
                frm6.lblBransAdi2.Text = "Nöroloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Psikiyatri")
            {
                frm6.lblBransAdi1.Text = "Psikiyatri";
                frm6.lblBransAdi2.Text = "Psikiyatri";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "İç Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "İç Hastalıkları";
                frm6.lblBransAdi2.Text = "İç Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(125, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göz Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göz Hastalıkları";
                frm6.lblBransAdi2.Text = "Göz Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(119, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(465, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Göğüs Hastalıkları")
            {
                frm6.lblBransAdi1.Text = "Göğüs Hastalıkları";
                frm6.lblBransAdi2.Text = "Göğüs Hastalıkları";

                frm6.lblBransAdi1.Location = new Point(90, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(458, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Kalp ve Damar Cerrahisi")
            {
                frm6.lblBransAdi1.Text = "Kalp ve Damar Cerrahisi";
                frm6.lblBransAdi2.Text = "Kalp ve Damar Cerrahisi";

                frm6.lblBransAdi1.Location = new Point(29, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(410, frm6.lblBransAdi2.Location.Y);
            }


            else if (lblBransAdi1.Text == "Gastroenteroloji")
            {
                frm6.lblBransAdi1.Text = "Gastroenteroloji";
                frm6.lblBransAdi2.Text = "Gastroenteroloji";

                frm6.lblBransAdi1.Location = new Point(110, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(455, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Dermatoloji")
            {
                frm6.lblBransAdi1.Text = "Dermatoloji";
                frm6.lblBransAdi2.Text = "Dermatoloji";

                frm6.lblBransAdi1.Location = new Point(135, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Ortopedi ve Travma")
            {
                frm6.lblBransAdi1.Text = "Ortopedi ve Travma";
                frm6.lblBransAdi2.Text = "Ortopedi ve Travma";

                frm6.lblBransAdi1.Location = new Point(70, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(460, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Nefroloji")
            {
                frm6.lblBransAdi1.Text = "Nefroloji";
                frm6.lblBransAdi2.Text = "Nefroloji";

                frm6.lblBransAdi1.Location = new Point(185, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Hematoloji")
            {
                frm6.lblBransAdi1.Text = "Hematoloji";
                frm6.lblBransAdi2.Text = "Hematoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Romatoloji")
            {
                frm6.lblBransAdi1.Text = "Romatoloji";
                frm6.lblBransAdi2.Text = "Romatoloji";

                frm6.lblBransAdi1.Location = new Point(155, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }

            else if (lblBransAdi1.Text == "Üroloji")
            {
                frm6.lblBransAdi1.Text = "Üroloji";
                frm6.lblBransAdi2.Text = "Üroloji";

                frm6.lblBransAdi1.Location = new Point(193, frm6.lblBransAdi1.Location.Y);
                frm6.lblBransAdi2.Location = new Point(480, frm6.lblBransAdi2.Location.Y);
            }


            #endregion



            DateTime frm4deSecilenTarih = frm4.monthCalendar_randevuTarihleri.SelectionStart.Date;
            frm6.lblTarih.Text = frm4deSecilenTarih.ToShortDateString();

            frm6.lblSaat.Text = lblSaatYirmiDört.Text;

            frm6.ShowDialog();
        }

      private void lblSaatOnUc_Click(object sender, EventArgs e)
        {

        }
      
    }
    }
    
    
    
    
    
    
    
    

    
    
    
    
    
    
