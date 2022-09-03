namespace DataBaseliPersonelKimlik
{
    partial class Form1
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cb_Personel = new System.Windows.Forms.ComboBox();
            this.lbl_File = new System.Windows.Forms.Label();
            this.lbl_FileTrue = new System.Windows.Forms.Label();
            this.tb_Adi = new System.Windows.Forms.TextBox();
            this.lbl_PersonelAd = new System.Windows.Forms.Label();
            this.tb_Soyadi = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.lbl_TC = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.lbl_Adres = new System.Windows.Forms.Label();
            this.tb_Sehir = new System.Windows.Forms.TextBox();
            this.lbl_Sehir = new System.Windows.Forms.Label();
            this.tb_Departman = new System.Windows.Forms.TextBox();
            this.lbl_Departman = new System.Windows.Forms.Label();
            this.cb_Kadin = new System.Windows.Forms.CheckBox();
            this.cb_Erkek = new System.Windows.Forms.CheckBox();
            this.lbl_Varmi = new System.Windows.Forms.Label();
            this.mtb_TC = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 415);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(359, 26);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cb_Personel
            // 
            this.cb_Personel.FormattingEnabled = true;
            this.cb_Personel.Location = new System.Drawing.Point(377, 12);
            this.cb_Personel.Name = "cb_Personel";
            this.cb_Personel.Size = new System.Drawing.Size(139, 21);
            this.cb_Personel.TabIndex = 1;
            this.cb_Personel.SelectedIndexChanged += new System.EventHandler(this.cb_Personel_SelectedIndexChanged);
            // 
            // lbl_File
            // 
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(374, 428);
            this.lbl_File.Name = "lbl_File";
            this.lbl_File.Size = new System.Drawing.Size(69, 13);
            this.lbl_File.TabIndex = 2;
            this.lbl_File.Text = "Dosya Varmı:";
            // 
            // lbl_FileTrue
            // 
            this.lbl_FileTrue.AutoSize = true;
            this.lbl_FileTrue.Location = new System.Drawing.Point(492, 428);
            this.lbl_FileTrue.Name = "lbl_FileTrue";
            this.lbl_FileTrue.Size = new System.Drawing.Size(24, 13);
            this.lbl_FileTrue.TabIndex = 3;
            this.lbl_FileTrue.Text = "test";
            // 
            // tb_Adi
            // 
            this.tb_Adi.Location = new System.Drawing.Point(255, 18);
            this.tb_Adi.Name = "tb_Adi";
            this.tb_Adi.Size = new System.Drawing.Size(74, 20);
            this.tb_Adi.TabIndex = 4;
            // 
            // lbl_PersonelAd
            // 
            this.lbl_PersonelAd.AutoSize = true;
            this.lbl_PersonelAd.Location = new System.Drawing.Point(9, 18);
            this.lbl_PersonelAd.Name = "lbl_PersonelAd";
            this.lbl_PersonelAd.Size = new System.Drawing.Size(74, 13);
            this.lbl_PersonelAd.TabIndex = 5;
            this.lbl_PersonelAd.Text = "Personelin Adı";
            // 
            // tb_Soyadi
            // 
            this.tb_Soyadi.Location = new System.Drawing.Point(255, 50);
            this.tb_Soyadi.Name = "tb_Soyadi";
            this.tb_Soyadi.Size = new System.Drawing.Size(74, 20);
            this.tb_Soyadi.TabIndex = 4;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(9, 51);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(91, 13);
            this.lbl_Soyad.TabIndex = 5;
            this.lbl_Soyad.Text = "Personelin Soyadı";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(9, 84);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(101, 13);
            this.lbl_Tel.TabIndex = 5;
            this.lbl_Tel.Text = "Personelin Telefonu";
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(9, 117);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(97, 13);
            this.lbl_Cinsiyet.TabIndex = 5;
            this.lbl_Cinsiyet.Text = "Personelin Cinsiyeti";
            // 
            // lbl_TC
            // 
            this.lbl_TC.AutoSize = true;
            this.lbl_TC.Location = new System.Drawing.Point(9, 150);
            this.lbl_TC.Name = "lbl_TC";
            this.lbl_TC.Size = new System.Drawing.Size(133, 13);
            this.lbl_TC.TabIndex = 5;
            this.lbl_TC.Text = "Personelin Kimlik Numarası";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(255, 175);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(74, 20);
            this.tb_Adres.TabIndex = 4;
            // 
            // lbl_Adres
            // 
            this.lbl_Adres.AutoSize = true;
            this.lbl_Adres.Location = new System.Drawing.Point(9, 183);
            this.lbl_Adres.Name = "lbl_Adres";
            this.lbl_Adres.Size = new System.Drawing.Size(88, 13);
            this.lbl_Adres.TabIndex = 5;
            this.lbl_Adres.Text = "Personelin Adresi";
            // 
            // tb_Sehir
            // 
            this.tb_Sehir.Location = new System.Drawing.Point(255, 207);
            this.tb_Sehir.Name = "tb_Sehir";
            this.tb_Sehir.Size = new System.Drawing.Size(74, 20);
            this.tb_Sehir.TabIndex = 4;
            // 
            // lbl_Sehir
            // 
            this.lbl_Sehir.AutoSize = true;
            this.lbl_Sehir.Location = new System.Drawing.Point(9, 216);
            this.lbl_Sehir.Name = "lbl_Sehir";
            this.lbl_Sehir.Size = new System.Drawing.Size(83, 13);
            this.lbl_Sehir.TabIndex = 5;
            this.lbl_Sehir.Text = "Personelin Şehri";
            // 
            // tb_Departman
            // 
            this.tb_Departman.Location = new System.Drawing.Point(255, 239);
            this.tb_Departman.Name = "tb_Departman";
            this.tb_Departman.Size = new System.Drawing.Size(74, 20);
            this.tb_Departman.TabIndex = 4;
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Location = new System.Drawing.Point(9, 249);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(113, 13);
            this.lbl_Departman.TabIndex = 5;
            this.lbl_Departman.Text = "Personelin Departmanı";
            // 
            // cb_Kadin
            // 
            this.cb_Kadin.AutoSize = true;
            this.cb_Kadin.Location = new System.Drawing.Point(216, 114);
            this.cb_Kadin.Name = "cb_Kadin";
            this.cb_Kadin.Size = new System.Drawing.Size(53, 17);
            this.cb_Kadin.TabIndex = 6;
            this.cb_Kadin.Text = "Kadın";
            this.cb_Kadin.UseVisualStyleBackColor = true;
            this.cb_Kadin.CheckedChanged += new System.EventHandler(this.cb_Kadin_CheckedChanged);
            // 
            // cb_Erkek
            // 
            this.cb_Erkek.AutoSize = true;
            this.cb_Erkek.Location = new System.Drawing.Point(275, 114);
            this.cb_Erkek.Name = "cb_Erkek";
            this.cb_Erkek.Size = new System.Drawing.Size(54, 17);
            this.cb_Erkek.TabIndex = 7;
            this.cb_Erkek.Text = "Erkek";
            this.cb_Erkek.UseVisualStyleBackColor = true;
            this.cb_Erkek.CheckedChanged += new System.EventHandler(this.cb_Erkek_CheckedChanged);
            // 
            // lbl_Varmi
            // 
            this.lbl_Varmi.AutoSize = true;
            this.lbl_Varmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Varmi.Location = new System.Drawing.Point(125, 312);
            this.lbl_Varmi.Name = "lbl_Varmi";
            this.lbl_Varmi.Size = new System.Drawing.Size(274, 51);
            this.lbl_Varmi.TabIndex = 8;
            this.lbl_Varmi.Text = "kişi zaten var";
            this.lbl_Varmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Varmi.Visible = false;
            // 
            // mtb_TC
            // 
            this.mtb_TC.Location = new System.Drawing.Point(255, 143);
            this.mtb_TC.Mask = "99999999999";
            this.mtb_TC.Name = "mtb_TC";
            this.mtb_TC.Size = new System.Drawing.Size(74, 20);
            this.mtb_TC.TabIndex = 9;
            // 
            // mtb_Telefon
            // 
            this.mtb_Telefon.Location = new System.Drawing.Point(255, 82);
            this.mtb_Telefon.Mask = "(999) 000-0000";
            this.mtb_Telefon.Name = "mtb_Telefon";
            this.mtb_Telefon.Size = new System.Drawing.Size(74, 20);
            this.mtb_Telefon.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.lbl_Varmi);
            this.Controls.Add(this.mtb_Telefon);
            this.Controls.Add(this.mtb_TC);
            this.Controls.Add(this.cb_Erkek);
            this.Controls.Add(this.cb_Kadin);
            this.Controls.Add(this.lbl_Departman);
            this.Controls.Add(this.tb_Departman);
            this.Controls.Add(this.lbl_Sehir);
            this.Controls.Add(this.tb_Sehir);
            this.Controls.Add(this.lbl_Adres);
            this.Controls.Add(this.tb_Adres);
            this.Controls.Add(this.lbl_TC);
            this.Controls.Add(this.lbl_Cinsiyet);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.tb_Soyadi);
            this.Controls.Add(this.lbl_PersonelAd);
            this.Controls.Add(this.tb_Adi);
            this.Controls.Add(this.lbl_FileTrue);
            this.Controls.Add(this.lbl_File);
            this.Controls.Add(this.cb_Personel);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cb_Personel;
        private System.Windows.Forms.Label lbl_File;
        private System.Windows.Forms.Label lbl_FileTrue;
        private System.Windows.Forms.TextBox tb_Adi;
        private System.Windows.Forms.Label lbl_PersonelAd;
        private System.Windows.Forms.TextBox tb_Soyadi;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Label lbl_TC;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.Label lbl_Adres;
        private System.Windows.Forms.TextBox tb_Sehir;
        private System.Windows.Forms.Label lbl_Sehir;
        private System.Windows.Forms.TextBox tb_Departman;
        private System.Windows.Forms.Label lbl_Departman;
        private System.Windows.Forms.CheckBox cb_Kadin;
        private System.Windows.Forms.CheckBox cb_Erkek;
        private System.Windows.Forms.Label lbl_Varmi;
        private System.Windows.Forms.MaskedTextBox mtb_TC;
        private System.Windows.Forms.MaskedTextBox mtb_Telefon;
    }
}

