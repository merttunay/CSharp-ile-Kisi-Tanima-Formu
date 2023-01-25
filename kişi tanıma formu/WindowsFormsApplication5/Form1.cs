using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }
        string askerlik;
        string harf;
        string meddur;
        int boy;
        int kilo;
        int  indeks;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtad.Text == "" || txtsoyad.Text == "")
            {
                MessageBox.Show("Lütfen Ad-Soyad Bilgilerini Boş Bırakmayınız!!!");
            }
            else if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen Boy/Kilo Bilgilerini Boş Bırakmayınız!!!");
            }
            else
            {

                boy = Convert.ToInt16(textBox1.Text);
                kilo = Convert.ToInt16(textBox2.Text);
                indeks = (boy * boy) / kilo;
                textBox3.Text = Convert.ToString(indeks);
                listBox1.Items.Clear();
                listBox1.Items.Add(txtad.Text + " " + txtsoyad.Text);
                listBox1.Items.Add("doğum tarihi: " + comboBox1.SelectedItem + "/" + comboBox2.SelectedItem + "/" + comboBox3.SelectedItem);
                if (rdbayan.Checked == true)
                    listBox1.Items.Add("Cinsiyet : Bayan");
                if (rderkek.Checked == true)
                    listBox1.Items.Add("Cinsiyet : Erkek");
                listBox1.Items.Add("Askerlik " + askerlik);
                if (rdvar.Checked == true)
                { listBox1.Items.Add("Ehliyeti Var"); listBox1.Items.Add("Sınıfı: " + harf); }

                if (rdyok.Checked == true)
                    listBox1.Items.Add("Ehliyeti Yok");
                
                listBox1.Items.Add("Hobiler");
                if (checkBox6.Checked == true)
                    listBox1.Items.Add(checkBox6.Text);
                if (checkBox7.Checked == true)
                    listBox1.Items.Add(checkBox7.Text);
                if (checkBox8.Checked == true)
                    listBox1.Items.Add(checkBox8.Text);
                if (checkBox9.Checked == true)
                    listBox1.Items.Add(checkBox9.Text);
                if (checkBox10.Checked == true)
                    listBox1.Items.Add(checkBox10.Text);
                if (checkBox11.Checked == true)
                    listBox1.Items.Add(checkBox11.Text);
                if (checkBox12.Checked == true)
                    listBox1.Items.Add(checkBox12.Text);
                if (checkBox13.Checked == true)
                    listBox1.Items.Add(checkBox13.Text);
                listBox1.Items.Add("Yabancı Diller");
                if (checkBox1.Checked == true)
                    listBox1.Items.Add(checkBox1.Text);
                if (checkBox2.Checked == true)
                    listBox1.Items.Add(checkBox2.Text);
                if (checkBox3.Checked == true)
                    listBox1.Items.Add(checkBox3.Text);
                if (checkBox4.Checked == true)
                    listBox1.Items.Add(checkBox4.Text);
                if (checkBox5.Checked == true)
                    listBox1.Items.Add(checkBox5.Text);
                listBox1.Items.Add("Boyu: " + textBox1.Text + " Kilosu: " + textBox2.Text + " BKI: " + textBox3.Text);
                listBox1.Items.Add("Medeni hali: " + meddur);
                if (txtcocuk.Text != "")
                {
                    listBox1.Items.Add("Çocuk Sayısı: " + txtcocuk.Text);
                }
                else
                {
                    listBox1.Items.Add("Çocuk Sayısı: " + 0);
                }
                
            }
        }

        private void rdbayan_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = false;

        }
        private void rderkek_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox11.Visible = false;

            for (int i = 1970; i <= 2020; i++)
            {
                comboBox3.Items.Add(i);
            }

            textBox3.Enabled = false;


        }
        private void rdvar_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
        }
        private void rdyok_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }
        private void rdevli_CheckedChanged(object sender, EventArgs e)
        {
            groupBox11.Visible = true;
            meddur = "evli";
        }
        private void rdbekar_CheckedChanged(object sender, EventArgs e)
        {
            groupBox11.Visible = false;
            txtcocuk.Clear();
            meddur = "bekar";
        }
        private void rddul_CheckedChanged(object sender, EventArgs e)
        {
            groupBox11.Visible = true ;
            meddur = "dul";
        }
        private void rdyaptı_CheckedChanged(object sender, EventArgs e)
        {
            askerlik = "yaptı";
        }
        private void rdyapmadı_CheckedChanged(object sender, EventArgs e)
        {
            askerlik = "yapmadı";
        }
        private void rdmuaf_CheckedChanged(object sender, EventArgs e)
        {
            askerlik = "muaf";
        }
        private void rda_CheckedChanged(object sender, EventArgs e)
        {
            harf = "A";
        }
        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            harf = "B";
        }
        private void rdc_CheckedChanged(object sender, EventArgs e)
        {
            harf = "C";
        }
        private void rdd_CheckedChanged(object sender, EventArgs e)
        {
            harf = "D";
        }
        private void rde_CheckedChanged(object sender, EventArgs e)
        {
            harf = "E";
        }
        private void rdf_CheckedChanged(object sender, EventArgs e)
        {
            harf = "F";
        }


        
    }
}
