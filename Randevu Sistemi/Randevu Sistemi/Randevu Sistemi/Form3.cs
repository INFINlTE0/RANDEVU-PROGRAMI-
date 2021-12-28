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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string secilenTarih;

        Form4 frm4 = new Form4();


        private void Form3_Load(object sender, EventArgs e)
        {

            Hakan.Text = "HAKAN YALÇINKAYA";   
            Form1 frm1 = (Form1)Application.OpenForms["Form1"];
            Form2 frm2 = (Form2)Application.OpenForms["Form2"];

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";

            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

            DateTime frm2deSecilenTarih = frm2.monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm2deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm2deSecilenTarih.ToLongDateString();

            if (DateTime.Compare(frm2.monthCalendar_randevuTarihleri.SelectionRange.Start, DateTime.Today.Date) == 1)
                monthCalendar_randevuTarihleri.SelectionStart = frm2.monthCalendar_randevuTarihleri.SelectionStart;
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Visible = false;

            Form frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void monthCalendar_randevuTarihleri_DateChanged(object sender, DateRangeEventArgs e)
        {
            secilenTarih = e.Start.ToShortDateString();

            DateTime frm3deSecilenTarih = monthCalendar_randevuTarihleri.SelectionStart.Date;

            lblTarih1.Text = frm3deSecilenTarih.ToLongDateString();
            lblTarih2.Text = frm3deSecilenTarih.ToLongDateString();
        }

        private void picBoxBeyinveSinirCerrahisi_Click(object sender, EventArgs e)
        {
           
                frm4.picBoxBölüm.Text = "HAKAN YALÇINKAYA";
             
                frm4.lblBolumİsmi.Text = Hakan.Text;
            /*BURADA HATA YAPTIN DOLULUK ORANINA ÇÖZÜM BUL*/
                frm4.lblBos.Text =Çalışan1.Text;
                frm4.lblDolu.Text = Çalışan1.Text;

                this.Refresh();

                this.Visible = false;

                frm4.ShowDialog();
           
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
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
            btnRandevularım.BackColor = Color.Red;
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
            btnCikis.BackColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
