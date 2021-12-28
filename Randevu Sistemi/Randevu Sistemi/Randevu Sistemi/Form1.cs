using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Bildirimler & Tanımlamalar

        Form2 frm2 = new Form2();

        public string ad;
        public string soyad;
        public int güvenlikKodu;
        string metinselGüvenlikKodu;
        string yenilenenMetinselGüvenlikKodu;


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Upper;
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
            txtGüvenlikKodu.MaxLength = 4;


            Random rnd_rastgeleGüvenlikKodu = new Random();

            int sayisalGüvenlikKodu;

            int[] diziGüvenlikKodu = new int[4];

            int artim = 0;

            for (int i = 1; i <= 4; i++)
            {
                sayisalGüvenlikKodu = rnd_rastgeleGüvenlikKodu.Next(1, 10);
                diziGüvenlikKodu[artim] = sayisalGüvenlikKodu;
                ++artim;
            }

            metinselGüvenlikKodu = diziGüvenlikKodu[0].ToString() + diziGüvenlikKodu[1].ToString() + diziGüvenlikKodu[2].ToString() + diziGüvenlikKodu[3].ToString();



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics grp = e.Graphics;
            grp.SmoothingMode = SmoothingMode.AntiAlias;
            grp.FillRectangle(new HatchBrush(HatchStyle.Cross, Color.WhiteSmoke, Color.CornflowerBlue), new Rectangle(147, 180, 97, 33));

            Font drawFont = new Font("Comic Sans MS", 20, FontStyle.Bold, GraphicsUnit.Point);

            SolidBrush drawBrush = new SolidBrush(Color.White);

            grp.DrawString(metinselGüvenlikKodu.ToString(), drawFont, drawBrush, 156, 177);

            grp.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();
        }

        private void btnGüvenlikKoduYenile_Click(object sender, EventArgs e)
        {
            
            txtGüvenlikKodu.Clear();

            Random rnd_rastgeleGüvenlikKodu = new Random();

            int sayisalGüvenlikKodu;

            int[] diziGüvenlikKodu = new int[4];

            int artim = 0;

            for (int i = 1; i <= 4; i++)
            {
                sayisalGüvenlikKodu = rnd_rastgeleGüvenlikKodu.Next(1, 10);
                diziGüvenlikKodu[artim] = sayisalGüvenlikKodu;
                ++artim;
            }
            yenilenenMetinselGüvenlikKodu = diziGüvenlikKodu[0].ToString() + diziGüvenlikKodu[1].ToString() + diziGüvenlikKodu[2].ToString() + diziGüvenlikKodu[3].ToString();

            Graphics grp = panel3.CreateGraphics();

            grp.Clear(Color.White);

            grp.SmoothingMode = SmoothingMode.AntiAlias;
            grp.FillRectangle(new HatchBrush(HatchStyle.DarkVertical, Color.DarkOrange, Color.Pink), new Rectangle(147, 180, 97, 33));

            Font drawFont = new Font("Comic Sans MS", 20, FontStyle.Bold, GraphicsUnit.Point);

            SolidBrush drawBrush = new SolidBrush(Color.White);

            grp.DrawString(yenilenenMetinselGüvenlikKodu.ToString(), drawFont, drawBrush, 156, 177);

            grp.Dispose();
            drawFont.Dispose();
            drawBrush.Dispose();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                ad = txtAd.Text;
                soyad = txtSoyad.Text;
                güvenlikKodu = Convert.ToUInt16(txtGüvenlikKodu.Text);

                DateTime simdikiTarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                DateTime dogumTarih = Convert.ToDateTime(mskTxtDogumTarihi.Text);
                DateTime kabulEdilmeyecekTarih = new DateTime(1899,12,31);

                if ((DateTime.Compare(dogumTarih, simdikiTarih) != 1) && (DateTime.Compare(dogumTarih, simdikiTarih) != 0)
                     && (DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) != -1) && (DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) != 0)
                     && (mskTxtDogumTarihi.Text.Length == 10)
                   )
                {
                    if ((mskTxtTCKimlikNo.Text.Length == 11) && (ad != "") && (soyad != ""))
                    {
                        if (((güvenlikKodu.ToString() == metinselGüvenlikKodu) || (güvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                        {
                            if (mskTxtTelefonNo.Text.Length == 15)
                            {
                                this.Visible = false;
                            
                                frm2.ShowDialog();
                              
                            }
                        }
                    }
                }

                #region T.C. Kimlik No Kontrolü

                if (mskTxtTCKimlikNo.Text == "")
                    errorProv_mskTxtTCKimlikNo.SetError(mskTxtTCKimlikNo, "T.C. Kimlik No boş bırakılamaz.");

                else if (mskTxtTCKimlikNo.Text.Length != 11)
                    errorProv_mskTxtTCKimlikNo.SetError(mskTxtTCKimlikNo, "T.C. Kimlik 11 karakter olmalıdır.");

                else
                    errorProv_mskTxtTCKimlikNo.Clear();

                #endregion

                #region Ad Kontrolü

                if (ad == "")
                    errorProv_txtAd.SetError(txtAd, "Ad alanı boş bırakılamaz.");

                else if (txtAd.TextLength == 30)
                    errorProv_txtAd.SetError(txtAd, "Ad alanına 30 karakterden fazlasını yazamazsınız.");

                else
                    errorProv_txtAd.Clear();


                #endregion

                #region Soyad Kontrolü

                if (soyad == "")
                    errorProv_txtSoyad.SetError(txtSoyad, "Soyad alanı boş bırakılamaz.");

                else if (txtAd.TextLength == 30)
                    errorProv_txtSoyad.SetError(txtSoyad, "Soyad alanına 20 karakterden fazlasını yazamazsınız.");

                else
                    errorProv_txtSoyad.Clear();

                #endregion

                #region Doğum Tarihi Kontrolü

                if (mskTxtDogumTarihi.Text.Length < 7)
                    errorProv_mskTxtDogumTarihi.SetError(mskTxtDogumTarihi, "Doğum tarihi alanını boş bırakamazsınız.");

                if ((mskTxtDogumTarihi.Text.Length == 7) || (mskTxtDogumTarihi.Text.Length == 8) || (mskTxtDogumTarihi.Text.Length == 9))
                    errorProv_mskTxtDogumTarihi.SetError(mskTxtDogumTarihi, "Doğum tarihi alanı 8 karakter olmalıdır.");

                if ((DateTime.Compare(dogumTarih, simdikiTarih) == 1) || (DateTime.Compare(dogumTarih, simdikiTarih) == 0))
                    errorProv_mskTxtDogumTarihi.SetError(mskTxtDogumTarihi, "Doğum tarihi alanına şimdiki tarih veya şimdiki tarih'ten büyük olan bir tarih yazılamaz.");

                if ((DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) == -1) || (DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) == 0))
                    errorProv_mskTxtDogumTarihi.SetError(mskTxtDogumTarihi, "Doğum tarihi alanına 31.12.1899 veya 31.12.1899 tarih'inden küçük bir tarih yazılamaz.");

                if ((DateTime.Compare(dogumTarih, simdikiTarih) != 1) && (DateTime.Compare(dogumTarih, simdikiTarih) != 0)
                     && (DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) != -1) && (DateTime.Compare(dogumTarih, kabulEdilmeyecekTarih) != 0)
                     && (mskTxtDogumTarihi.Text.Length == 10)
                   )
                    errorProv_mskTxtDogumTarihi.Clear();

                    #endregion

                #region Güvenlik Kodu Kontrolü

                    if (((güvenlikKodu.ToString() != metinselGüvenlikKodu) || (güvenlikKodu.ToString() != yenilenenMetinselGüvenlikKodu)))
                    errorProv_txtGüvenlikKodu.SetError(txtGüvenlikKodu, "Güvenlik Kodu'nu doğru giriniz.");

                if(((güvenlikKodu.ToString() == metinselGüvenlikKodu) || (güvenlikKodu.ToString() == yenilenenMetinselGüvenlikKodu)))
                    errorProv_txtGüvenlikKodu.Clear();

                #endregion

                #region Telefon No Kontrolü

                if (mskTxtTelefonNo.Text.Length != 15)
                    errorProv_mskTxtTelefonNo.SetError(mskTxtTelefonNo, "Telefon No alanı 10 karakterli olmalıdır.");

                if (mskTxtTelefonNo.Text.Length == 15)
                    errorProv_mskTxtTelefonNo.Clear();

                #endregion Telefon No Kontrolü





            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btnGirisYap_MouseMove(object sender, MouseEventArgs e)
        {
            btnGirisYap.BackColor = SystemColors.WindowFrame;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Red;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picBoxHastane2_Click(object sender, EventArgs e)
        {

        }
    }
}
