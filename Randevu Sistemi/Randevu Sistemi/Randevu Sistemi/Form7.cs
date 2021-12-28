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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnRandevularım_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Form8 frm8 = new Form8();
            frm8.ShowDialog();
      
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

            Application.Restart();

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRandevularım_MouseLeave(object sender, EventArgs e)
        {
            btnRandevularım.BackColor = Color.Red;
        }

        private void btnRandevularım_MouseMove(object sender, MouseEventArgs e)
        {
            btnRandevularım.BackColor = SystemColors.WindowFrame;
        }

        private void btnCikis_MouseLeave(object sender, EventArgs e)
        {
            btnCikis.BackColor = Color.Red;
        }

        private void btnCikis_MouseMove(object sender, MouseEventArgs e)
        {
            btnCikis.BackColor = SystemColors.WindowFrame;
        }

        private void lblRandevuAlmaZamani_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
