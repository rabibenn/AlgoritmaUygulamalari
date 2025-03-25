using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> sayilar = new List <int>();
            List<int> tahmin = new List<int>();

            for (int i = 1; i <= 49; i++)
            {
                sayilar.Add(i);
            }
            for (int x = 0; x <= 6; x++)
            {
                int index = rnd.Next(0,sayilar.Count);
                tahmin.Add(sayilar[index]);
                sayilar.RemoveAt(index);
            }

            tahmin.Sort();
            label1.Text = tahmin[0].ToString();
            label2.Text = tahmin[1].ToString();
            label3.Text = tahmin[2].ToString();
            label4.Text = tahmin[3].ToString();
            label5.Text = tahmin[4].ToString(); 
            label6.Text = tahmin[5].ToString();



            //int randomsayi = rnd.Next(1,50);
            //label1.Text = Convert.ToString(randomsayi);
            //int randomsayi2 = rnd.Next(1, 50);
            //label2.Text = Convert.ToString(randomsayi2);
            //int randomsayi3 = rnd.Next(1, 50);
            //label3.Text = Convert.ToString(randomsayi3);
            //int randomsayi4 = rnd.Next(1, 50);
            //label4.Text = Convert.ToString(randomsayi4);
            //int randomsayi5 = rnd.Next(1, 50);
            //label5.Text = Convert.ToString(randomsayi5);
            //int randomsayi6 = rnd.Next(1, 50);
            //label6.Text = Convert.ToString(randomsayi6);

            //label1.Text = randomsayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[] renkler = new Color[8] {Color.Red, Color.Blue , Color.Green, Color.Purple, Color.Yellow, Color.Pink, Color.White, Color.Orange};

            Random rnd = new Random();
            int dizi = rnd.Next(0, 8);
            this.BackColor = renkler[dizi];
        }
    }
}
