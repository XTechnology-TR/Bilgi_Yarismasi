using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnB.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                button1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                button6.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnC.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                button1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                button6.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnD.Text;

            if (label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                button1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                button6.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label6.Text = btnA.Text;

            if(label4.Text == label6.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                button1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlıs.Text = yanlis.ToString();
                button6.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button6.Visible = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            soruno++;
            lblSoruNo.Text = soruno.ToString();

            if(soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1930";
                btnC.Text = "1923";
                btnD.Text = "1963";
                label4.Text = "1923";
            }

            if(soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege Bölgemizde bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }

            if(soruno == 3)
            {
                richTextBox1.Text = "Cherub Serisi hangi yazara aittir?";
                btnA.Text = "Sir Arthur Conan Doyle";
                btnB.Text = "Erkan İşeri";
                btnC.Text = "Robin Sharma";
                btnD.Text = "Robert Muchamore";
                label4.Text = "Robert Muchamore";
                btnSonraki.Text = "Sonuçlar";
            }

            if(soruno == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru:" + " " + dogru + "\n" + "Yanlış:" + " " + yanlis);
            }
        }
    }
}
