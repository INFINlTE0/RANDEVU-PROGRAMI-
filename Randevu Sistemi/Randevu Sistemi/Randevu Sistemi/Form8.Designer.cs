namespace Randevu_Sistemi
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picBoxRandevuListem = new System.Windows.Forms.PictureBox();
            this.lblHosgeldinizAciklama = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.hastaTCKimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaCepTelefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuAlmaZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RandevuTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandevuSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poliklinik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnayKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İslem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picBoxKayitliRandevuYok = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRandevuListem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKayitliRandevuYok)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRandevuListem
            // 
            this.picBoxRandevuListem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxRandevuListem.BackgroundImage")));
            this.picBoxRandevuListem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxRandevuListem.Location = new System.Drawing.Point(2, 92);
            this.picBoxRandevuListem.Name = "picBoxRandevuListem";
            this.picBoxRandevuListem.Size = new System.Drawing.Size(997, 38);
            this.picBoxRandevuListem.TabIndex = 60;
            this.picBoxRandevuListem.TabStop = false;
            // 
            // lblHosgeldinizAciklama
            // 
            this.lblHosgeldinizAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHosgeldinizAciklama.AutoSize = true;
            this.lblHosgeldinizAciklama.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldinizAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblHosgeldinizAciklama.Location = new System.Drawing.Point(127, 108);
            this.lblHosgeldinizAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHosgeldinizAciklama.Name = "lblHosgeldinizAciklama";
            this.lblHosgeldinizAciklama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHosgeldinizAciklama.Size = new System.Drawing.Size(10, 15);
            this.lblHosgeldinizAciklama.TabIndex = 57;
            this.lblHosgeldinizAciklama.Text = ".";
            this.lblHosgeldinizAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCikis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(957, 55);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(66, 31);
            this.btnCikis.TabIndex = 58;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            this.btnCikis.MouseLeave += new System.EventHandler(this.btnCikis_MouseLeave);
            this.btnCikis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCikis_MouseMove);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnasayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnasayfa.BackColor = System.Drawing.Color.Red;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnasayfa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.ForeColor = System.Drawing.Color.White;
            this.btnAnasayfa.Location = new System.Drawing.Point(852, 55);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(101, 31);
            this.btnAnasayfa.TabIndex = 59;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            this.btnAnasayfa.MouseLeave += new System.EventHandler(this.btnAnasayfa_MouseLeave);
            this.btnAnasayfa.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAnasayfa_MouseMove);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Black;
            this.lblAciklama.Location = new System.Drawing.Point(66, 144);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(880, 17);
            this.lblAciklama.TabIndex = 127;
            this.lblAciklama.Text = "Daha önce almış olduğunuz randevular aşağıda listelenmiştir. İleri tarhihteki ran" +
    "devularınızı iptal etmek için \"İptal Et\" button\'una tıklayınız.";
            // 
            // hastaTCKimlikNoDataGridViewTextBoxColumn
            // 
            this.hastaTCKimlikNoDataGridViewTextBoxColumn.DataPropertyName = "HastaTCKimlikNo";
            this.hastaTCKimlikNoDataGridViewTextBoxColumn.HeaderText = "HastaTCKimlikNo";
            this.hastaTCKimlikNoDataGridViewTextBoxColumn.Name = "hastaTCKimlikNoDataGridViewTextBoxColumn";
            // 
            // hastaAdDataGridViewTextBoxColumn
            // 
            this.hastaAdDataGridViewTextBoxColumn.DataPropertyName = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.HeaderText = "HastaAd";
            this.hastaAdDataGridViewTextBoxColumn.Name = "hastaAdDataGridViewTextBoxColumn";
            // 
            // hastaSoyadDataGridViewTextBoxColumn
            // 
            this.hastaSoyadDataGridViewTextBoxColumn.DataPropertyName = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.HeaderText = "HastaSoyad";
            this.hastaSoyadDataGridViewTextBoxColumn.Name = "hastaSoyadDataGridViewTextBoxColumn";
            // 
            // hastaDogumTarihiDataGridViewTextBoxColumn
            // 
            this.hastaDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "HastaDogumTarihi";
            this.hastaDogumTarihiDataGridViewTextBoxColumn.HeaderText = "HastaDogumTarihi";
            this.hastaDogumTarihiDataGridViewTextBoxColumn.Name = "hastaDogumTarihiDataGridViewTextBoxColumn";
            // 
            // hastaCepTelefonNoDataGridViewTextBoxColumn
            // 
            this.hastaCepTelefonNoDataGridViewTextBoxColumn.DataPropertyName = "HastaCepTelefonNo";
            this.hastaCepTelefonNoDataGridViewTextBoxColumn.HeaderText = "HastaCepTelefonNo";
            this.hastaCepTelefonNoDataGridViewTextBoxColumn.Name = "hastaCepTelefonNoDataGridViewTextBoxColumn";
            // 
            // randevuAlmaZamaniDataGridViewTextBoxColumn
            // 
            this.randevuAlmaZamaniDataGridViewTextBoxColumn.DataPropertyName = "RandevuAlmaZamani";
            this.randevuAlmaZamaniDataGridViewTextBoxColumn.HeaderText = "RandevuAlmaZamani";
            this.randevuAlmaZamaniDataGridViewTextBoxColumn.Name = "randevuAlmaZamaniDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RandevuTarihi,
            this.RandevuSaati,
            this.Poliklinik,
            this.OnayKodu,
            this.İslem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.Location = new System.Drawing.Point(2, 238);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 66;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(997, 354);
            this.dataGridView1.TabIndex = 129;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // RandevuTarihi
            // 
            this.RandevuTarihi.HeaderText = "Randevu Tarihi";
            this.RandevuTarihi.Name = "RandevuTarihi";
            this.RandevuTarihi.ReadOnly = true;
            this.RandevuTarihi.Width = 200;
            // 
            // RandevuSaati
            // 
            this.RandevuSaati.HeaderText = "Randevu Saati";
            this.RandevuSaati.Name = "RandevuSaati";
            this.RandevuSaati.ReadOnly = true;
            this.RandevuSaati.Width = 230;
            // 
            // Poliklinik
            // 
            this.Poliklinik.HeaderText = "Poliklinik";
            this.Poliklinik.Name = "Poliklinik";
            this.Poliklinik.ReadOnly = true;
            this.Poliklinik.Width = 245;
            // 
            // OnayKodu
            // 
            this.OnayKodu.HeaderText = "Onay Kodu";
            this.OnayKodu.Name = "OnayKodu";
            this.OnayKodu.ReadOnly = true;
            this.OnayKodu.Width = 265;
            // 
            // İslem
            // 
            this.İslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İslem.HeaderText = "İşlem";
            this.İslem.Name = "İslem";
            this.İslem.ReadOnly = true;
            this.İslem.Text = "İptal Et";
            this.İslem.UseColumnTextForButtonValue = true;
            this.İslem.Width = 56;
            // 
            // picBoxKayitliRandevuYok
            // 
            this.picBoxKayitliRandevuYok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxKayitliRandevuYok.BackgroundImage")));
            this.picBoxKayitliRandevuYok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxKayitliRandevuYok.Location = new System.Drawing.Point(2, 185);
            this.picBoxKayitliRandevuYok.Name = "picBoxKayitliRandevuYok";
            this.picBoxKayitliRandevuYok.Size = new System.Drawing.Size(997, 47);
            this.picBoxKayitliRandevuYok.TabIndex = 130;
            this.picBoxKayitliRandevuYok.TabStop = false;
            this.picBoxKayitliRandevuYok.Visible = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1048, 616);
            this.Controls.Add(this.picBoxKayitliRandevuYok);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.picBoxRandevuListem);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblHosgeldinizAciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form8_FormClosed);
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRandevuListem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKayitliRandevuYok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblHosgeldinizAciklama;
        public System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Button btnAnasayfa;
        public System.Windows.Forms.PictureBox picBoxRandevuListem;
        public System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTCKimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaCepTelefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuAlmaZamaniDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandevuSaati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poliklinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnayKodu;
        private System.Windows.Forms.DataGridViewButtonColumn İslem;
        public System.Windows.Forms.PictureBox picBoxKayitliRandevuYok;
    }
}