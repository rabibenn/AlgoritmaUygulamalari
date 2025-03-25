using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, tahminsayisi = 0, puan = 1000;

        private void button1_Click(object sender, EventArgs e)
        {
            if(tahminsayisi <= 9)
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                if (sayi < tahmin)
                {
                    label5.Text = "Tuttuğum sayıdan büyük.";
                    tahminsayisi++;
                    label6.Text = Convert.ToString(tahminsayisi);
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                else if (sayi > tahmin)
                {
                    label5.Text = "Tuttuğum sayıdan küçük.";
                    tahminsayisi++;
                    label6.Text = Convert.ToString(tahminsayisi);
                    puan = puan - 100;
                    label7.Text = Convert.ToString(puan);
                }
                else
                {
                    label5.Text = "Tebrikler.";
                    label7.Text = Convert.ToString(puan);
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    button2.Enabled = true;
                    textBox1.Text = "";
                }

            }
            else
            {
                label5.Text = "Tahmin hakkınız bitti.";
                button1.Enabled = false;
                textBox1.Enabled = false;
                button2.Enabled = true;
                label7.Text = Convert.ToString(puan);
                textBox1.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            button2.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(100);
            label8.Text = Convert.ToString(sayi);
            label5.Text = "";
            label6.Text = "0";
            label7.Text = "1000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }
    }
}
