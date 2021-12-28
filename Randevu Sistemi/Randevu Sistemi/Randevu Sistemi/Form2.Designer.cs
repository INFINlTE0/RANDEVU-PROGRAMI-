namespace Randevu_Sistemi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGirisAciklamaBaslik = new System.Windows.Forms.Label();
            this.lblGirisAciklama3 = new System.Windows.Forms.Label();
            this.lblGirisAciklama2 = new System.Windows.Forms.Label();
            this.monthCalendar_randevuTarihleri = new System.Windows.Forms.MonthCalendar();
            this.btnRandevularım = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblHosgeldinizAciklama = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::Randevu_Sistemi.Properties.Resources.Screenshot_81;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.monthCalendar_randevuTarihleri);
            this.panel1.Location = new System.Drawing.Point(27, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 319);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Randevu_Sistemi.Properties.Resources.Screenshot_8;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblGirisAciklamaBaslik);
            this.panel2.Controls.Add(this.lblGirisAciklama3);
            this.panel2.Controls.Add(this.lblGirisAciklama2);
            this.panel2.Location = new System.Drawing.Point(45, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 218);
            this.panel2.TabIndex = 22;
            // 
            // lblGirisAciklamaBaslik
            // 
            this.lblGirisAciklamaBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGirisAciklamaBaslik.AutoSize = true;
            this.lblGirisAciklamaBaslik.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisAciklamaBaslik.ForeColor = System.Drawing.Color.Crimson;
            this.lblGirisAciklamaBaslik.Location = new System.Drawing.Point(82, 64);
            this.lblGirisAciklamaBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisAciklamaBaslik.Name = "lblGirisAciklamaBaslik";
            this.lblGirisAciklamaBaslik.Size = new System.Drawing.Size(302, 24);
            this.lblGirisAciklamaBaslik.TabIndex = 20;
            this.lblGirisAciklamaBaslik.Text = "Randevu sistemine hoşgeldiniz.";
            // 
            // lblGirisAciklama3
            // 
            this.lblGirisAciklama3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGirisAciklama3.AutoSize = true;
            this.lblGirisAciklama3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGirisAciklama3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblGirisAciklama3.Location = new System.Drawing.Point(7, 144);
            this.lblGirisAciklama3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisAciklama3.Name = "lblGirisAciklama3";
            this.lblGirisAciklama3.Size = new System.Drawing.Size(457, 19);
            this.lblGirisAciklama3.TabIndex = 23;
            this.lblGirisAciklama3.Text = "Lütfen takvimden almak istediğiniz randevu tarihini seçiniz.";
            // 
            // lblGirisAciklama2
            // 
            this.lblGirisAciklama2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGirisAciklama2.AutoSize = true;
            this.lblGirisAciklama2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisAciklama2.ForeColor = System.Drawing.Color.Black;
            this.lblGirisAciklama2.Location = new System.Drawing.Point(8, 104);
            this.lblGirisAciklama2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisAciklama2.Name = "lblGirisAciklama2";
            this.lblGirisAciklama2.Size = new System.Drawing.Size(453, 16);
            this.lblGirisAciklama2.TabIndex = 22;
            this.lblGirisAciklama2.Text = "Daha Önce Aldığınız Randevulara \"Randevularım\" button\'undan ulaşabilirsiniz.";
            // 
            // monthCalendar_randevuTarihleri
            // 
            this.monthCalendar_randevuTarihleri.BackColor = System.Drawing.Color.SlateGray;
            this.monthCalendar_randevuTarihleri.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar_randevuTarihleri.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthCalendar_randevuTarihleri.ForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.Location = new System.Drawing.Point(574, 44);
            this.monthCalendar_randevuTarihleri.MaxSelectionCount = 1;
            this.monthCalendar_randevuTarihleri.Name = "monthCalendar_randevuTarihleri";
            this.monthCalendar_randevuTarihleri.TabIndex = 21;
            this.monthCalendar_randevuTarihleri.TitleBackColor = System.Drawing.Color.Red;
            this.monthCalendar_randevuTarihleri.TitleForeColor = System.Drawing.Color.White;
            this.monthCalendar_randevuTarihleri.TrailingForeColor = System.Drawing.SystemColors.WindowFrame;
            this.monthCalendar_randevuTarihleri.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_randevuTarihleri_DateSelected);
            // 
            // btnRandevularım
            // 
            this.btnRandevularım.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRandevularım.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRandevularım.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandevularım.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevularım.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevularım.ForeColor = System.Drawing.Color.White;
            this.btnRandevularım.Location = new System.Drawing.Point(694, 425);
            this.btnRandevularım.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRandevularım.Name = "btnRandevularım";
            this.btnRandevularım.Size = new System.Drawing.Size(101, 31);
            this.btnRandevularım.TabIndex = 25;
            this.btnRandevularım.Text = "Randevularım";
            this.btnRandevularım.UseVisualStyleBackColor = false;
            this.btnRandevularım.Click += new System.EventHandler(this.btnRandevularım_Click);
            this.btnRandevularım.MouseLeave += new System.EventHandler(this.btnRandevularım_MouseLeave);
            this.btnRandevularım.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRandevularım_MouseMove);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(838, 425);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(66, 31);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            this.btnCikis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCikis_MouseMove);
            // 
            // lblHosgeldinizAciklama
            // 
            this.lblHosgeldinizAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHosgeldinizAciklama.AutoSize = true;
            this.lblHosgeldinizAciklama.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldinizAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblHosgeldinizAciklama.Location = new System.Drawing.Point(629, 48);
            this.lblHosgeldinizAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHosgeldinizAciklama.Name = "lblHosgeldinizAciklama";
            this.lblHosgeldinizAciklama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHosgeldinizAciklama.Size = new System.Drawing.Size(182, 17);
            this.lblHosgeldinizAciklama.TabIndex = 23;
            this.lblHosgeldinizAciklama.Text = "RANDEVU TARİHİ SEÇME";
            this.lblHosgeldinizAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Randevu_Sistemi.Properties.Resources.Screenshot_8;
            this.ClientSize = new System.Drawing.Size(1009, 495);
            this.Controls.Add(this.btnRandevularım);
            this.Controls.Add(this.lblHosgeldinizAciklama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Randevu Tarihi Seçme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MonthCalendar monthCalendar_randevuTarihleri;
        public System.Windows.Forms.Button btnRandevularım;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblGirisAciklamaBaslik;
        public System.Windows.Forms.Label lblGirisAciklama3;
        public System.Windows.Forms.Label lblGirisAciklama2;
        public System.Windows.Forms.Label lblHosgeldinizAciklama;
    }
}