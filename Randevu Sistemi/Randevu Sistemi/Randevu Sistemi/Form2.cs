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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string secilenTarih;

        private void Form2_Load(object sender, EventArgs e)
        {

            Form1 frm1 = (Form1)Application.OpenForms["Form1"]; //Açık olan Form üzerinden bilgi almak istiyorsak böyle yapmak zorundayız. //

            lblHosgeldinizAciklama.Text = "Sn.  " + frm1.ad + " " + frm1.soyad + ", e-randevu sistemine hoşgeldiniz.";

            monthCalendar_randevuTarihleri.MinDate = DateTime.Now;
            monthCalendar_randevuTarihleri.MaxDate = new DateTime(2021, 12, 31);

       

        }

        private void monthCalendar_randevuTarihleri_DateSelected(object sender, DateRangeEventArgs e)
        {
            Form3 frm3 = new Form3();

            if ((DateTime.Compare(e.Start.Date, DateTime.Today.Date) == 1) || (DateTime.Compare(e.Start.Date, DateTime.Today.Date) == 0))
            {
                secilenTarih = e.Start.ToShortDateString();

                this.Refresh();
                this.Visible = false;

                frm3.ShowDialog();
          
            }

        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.Visible = false;
            Form frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
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
