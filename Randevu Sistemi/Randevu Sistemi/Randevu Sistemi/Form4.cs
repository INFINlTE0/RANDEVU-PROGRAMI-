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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Form5 frm5 = new Form5();
        private void Form4_Load(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";


            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm3deSecilenTarih = frm3.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm3deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm3.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm3.monthCalendar_randevuTarihleri.SelectionStart;

          
        }

        private void picBoxGeri_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            this.Visible = false;

            frm3.Refresh();
            frm3.Visible = true;
        }

        private void picBoxBölüm_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            frm5.lblBransAdi1.Text = picBoxBölüm.Text;

            if (picBoxBölüm.Text == "Saç Professörü")
                frm5.lblBransAdi2.Text = ".";  
            else if (picBoxBölüm.Text == ".")
                frm5.lblBransAdi2.Text = ".";
            else if (picBoxBölüm.Text == ".")
                frm5.lblBransAdi2.Text = ".";
            else if (picBoxBölüm.Text == ".")
                frm5.lblBransAdi2.Text = ".";
            else if (picBoxBölüm.Text == "")
                frm5.lblBransAdi2.Text = ".";
            else
                frm5.lblBransAdi2.Text = picBoxBölüm.Text;


            frm5.picBoxSaatDokuz.Visible = true;
            frm5.lblSaatDokuz.Visible = true;
            frm5.picBoxSaatDokuzBucuk.Visible = true;
            frm5.lblSaatDokuzBucuk.Visible = true;
            frm5.picBoxSaatOn.Visible = true;
            frm5.lblSaatOn.Visible = true;
            frm5.picBoxSaatOnBucuk.Visible = true;
            frm5.lblSaatOnBucuk.Visible = true;

            frm5.picBoxSaatOnBir.Visible = true;
            frm5.lblSaatOnBir.Visible = true;
            frm5.picBoxSaatOnBirBucuk.Visible = true;
            frm5.lblSaatOnBirBucuk.Visible = true;


            frm5.picBoxSaatOnİki.Visible = true;
            frm5.lblSaatOnİki.Visible = true;
            frm5.picBoxSaatOnİkiOtuz.Visible = true;
            frm5.lblSaatOnİkiBucuk.Visible = true;

            frm5.picBoxSaatOnUc.Visible = true;
            frm5.lblSaatOnUc.Visible = true;
            frm5.picBoxSaatOnUcOtuz.Visible = true;
            frm5.lblSaatOnUcOtuz.Visible = true;

            frm5.picBoxSaatOnDört.Visible = true;
            frm5.lblSaatOnDört.Visible = true;
            frm5.picBoxSaatOnDörtOtuz.Visible = true;
            frm5.lblSaatOnDörtOtuz.Visible = true;

            frm5.picBoxSaatOnBes.Visible = true;
            frm5.lblSaatOnBes.Visible = true;
            frm5.picBoxSaatOnBesOtuz.Visible = true;
            frm5.lblSaatOnBesOtuz.Visible = true;

            frm5.picBoxSaatOnAltı.Visible = true;
            frm5.lblSaatOnAltı.Visible = true;

            frm5.picboxSaatOnYedi.Visible = true;
            frm5.lblSaatOnYedi.Visible = true;
            frm5.picboxSaatOnYediBuçuk.Visible = true;
            frm5.lblSaatOnYediBucuk.Visible = true;

            frm5.picboxSaatOnSekiz.Visible = true;
            frm5.lblSaatOnSekiz.Visible = true;
            frm5.picboxSaatOnSekizBuçuk.Visible = true;
            frm5.lblSaatOnSekizBucuk.Visible = true;

            frm5.picboxSaatOnDokuz.Visible = true;
            frm5.lblSaatOnDokuzBucuk.Visible = true;
            frm5.picboxSaatYirmi.Visible = true;
            frm5.lblSaatYirmi.Visible = true;

            frm5.picboxSaatYirmiBuçuk.Visible = true;
            frm5.lblSaatYirmiBucuk.Visible = true;
            frm5.picboxSaatYirmiBir.Visible = true;
            frm5.lblSaatYirmiBir.Visible = true;

            frm5.picboxSaatYirmiBirBuçuk.Visible = true;
            frm5.lblSaatYirmiBirBucuk.Visible = true;
            frm5.picboxSaatYirmiİki.Visible = true;
            frm5.lblSaatYirmiİki.Visible = true;

            frm5.picboxSaatYirmiİkiBuçuk.Visible = true;
            frm5.lblSaatYirmiİkiBucuk.Visible = true;
            frm5.picboxSaatYirmiÜç.Visible = true;
            frm5.lblSaatYirmiÜc.Visible = true;

            frm5.picboxSaatYirmiÜçBuçuk.Visible = true;
            frm5.lblSaatYirmiÜcBucuk.Visible = true;
            frm5.picboxSaatYirmiDört.Visible = true;
            frm5.lblSaatYirmiDört.Visible = true;



            this.Refresh();
            frm3.Refresh();

            this.Visible = false;

            frm5.ShowDialog();

        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            Form3 frm3 = (Form3)Application.OpenForms["Form3"];

            this.Refresh();
            frm3.Refresh();

            this.Visible = false;

            Form frm8 = new Form8();

            frm8.ShowDialog();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();
        }
        private void btnRandevularım_MouseMove(object sender, MouseEventArgs e)
        {
            btnRandevularım.BackColor = SystemColors.WindowFrame;
        }

        private void btnRandevularım_MouseLeave(object sender, EventArgs e)
        {
            btnRandevularım.BackColor = Color.Red;
        }

        private void btnCikis_MouseMove(object sender, MouseEventArgs e)
        {
            btnCikis.BackColor = SystemColors.WindowFrame;
       
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Red;
        }

    }
}
