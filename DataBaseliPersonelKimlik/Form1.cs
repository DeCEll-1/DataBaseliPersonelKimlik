using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseliPersonelKimlik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(@"C:\Personeller/null.per");
            if (!fi.Exists) { fi.Create(); }

            cb_Erkek.Checked = true;
            DirectoryInfo di = new DirectoryInfo(@"C:\Personeller");

            if (!di.Exists)
            {
                di.Create();
            }
            lbl_FileTrue.Text = Convert.ToString(di.Exists);
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo item in files)
            {
                cb_Personel.Items.Add(item.Name);
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Personeller");
            FileInfo fi = new FileInfo(@"C:\Personeller/" + tb_Adi.Text + ".per");
            if (!fi.Exists)
            {
                di.Create();
                StreamWriter sw = new StreamWriter(@"C:\Personeller/" + tb_Adi.Text + ".per");
                lbl_Varmi.Visible = true;
                sw.WriteLine(tb_Adi.Text);
                sw.WriteLine(tb_Soyadi.Text);
                sw.WriteLine(mtb_Telefon.Text);
                if (cb_Erkek.Checked)
                {
                    sw.WriteLine("Erkek");
                }
                else
                {
                    sw.WriteLine("Kadın");
                }
                sw.WriteLine(mtb_TC.Text);
                sw.WriteLine(tb_Adres.Text);
                sw.WriteLine(tb_Sehir.Text);
                sw.WriteLine(tb_Departman.Text);
                sw.Close();
                lbl_Varmi.Text = "Kişi Oluşturuldu";
                lbl_Varmi.Visible = true;
                int w = Form.ActiveForm.Size.Width;
                int h = Form.ActiveForm.Size.Height;
                lbl_Varmi.Size = new Size(((h / 2) - lbl_Varmi.Size.Height), ((w / 2) - lbl_Varmi.Size.Width));
            }
            else
            {
                lbl_Varmi.Text = "Kişi Zaten Var";
                int w = Form.ActiveForm.Size.Width;
                int h = Form.ActiveForm.Size.Height;
                lbl_Varmi.Size = new Size(((h / 2) - lbl_Varmi.Size.Height), ((w / 2) - lbl_Varmi.Size.Width));
                lbl_Varmi.Visible = true;
            }
        }

        #region checkboxes
        private void cb_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Erkek.Checked)
            {
                cb_Kadin.Checked = false;
            }
        }

        private void cb_Kadin_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Kadin.Checked)
            {
                cb_Erkek.Checked = false;
            }
        }
        #endregion

        private void cb_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Personeller");
            FileInfo[] files = di.GetFiles();
            foreach (FileInfo item in files)
            {
                if (cb_Personel.Text == item.Name)
                {
                    StreamReader sr = new StreamReader(@"C:\Personeller/" + item.Name);
                    tb_Adi.Text = sr.ReadLine();
                    tb_Soyadi.Text = sr.ReadLine();
                    mtb_Telefon.Text = sr.ReadLine();

                    if (sr.ReadLine() == "Erkek")
                    {
                        cb_Erkek.Checked = true;
                    }
                    else
                    {
                        cb_Kadin.Checked = true;
                    }

                    mtb_TC.Text = sr.ReadLine();
                    tb_Adres.Text = sr.ReadLine();
                    tb_Sehir.Text = sr.ReadLine();
                    tb_Departman.Text = sr.ReadLine();
                }
            }
        }
    }
}
