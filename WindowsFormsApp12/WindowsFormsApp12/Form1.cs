using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcNo = "", adSoyad = "", cinsiyet = "", mezuniyet = "", diller = "", uzmanlik = "";

            tcNo = textBox1.Text;
            adSoyad = textBox2.Text;

            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet=radioButton2.Text;
            }



            if (radioButton3.Checked == true)
            {
                mezuniyet = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                mezuniyet = radioButton4.Text;
            }
            else if (radioButton5.Checked == true)
            {
                mezuniyet = radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                mezuniyet = radioButton6.Text;   
            }




            if (checkBox1.Checked == true)
            {
                diller = diller + ", " + checkBox1.Text;
            }
            else if (checkBox2.Checked == true)
            {
                diller = diller + ", " + checkBox2.Text;
            }
            else if (checkBox3.Checked == true)
            {
                diller = diller + ", " + checkBox3.Text;
            }
            else if (checkBox4.Checked == true)
            {
                diller = diller + ", " + checkBox4.Text;
            }
            else if (checkBox5.Checked == true)
            {
                diller = diller + ", " + checkBox5.Text;
            }
            else if (checkBox6.Checked == true)
            {
                diller = diller + ", " + checkBox6.Text;
            }
            diller = diller.Substring(2);


            if (checkBox7.Checked == true)
            {
                uzmanlik = uzmanlik + ", " + checkBox7.Text;
            }
            else if (checkBox8.Checked == true)
            {
                uzmanlik = uzmanlik + ", " + checkBox8.Text;
            }
            else if (checkBox9.Checked == true)
            {
                uzmanlik = uzmanlik + ", " + checkBox9.Text;
            }
            else if (checkBox10.Checked == true)
            {
                uzmanlik = uzmanlik + ", " +  checkBox10.Text;
            }
            else if (checkBox11.Checked == true)
            {
                uzmanlik = uzmanlik + ", " + checkBox11.Text;
            }
            else if (checkBox12.Checked == true)
            {
                uzmanlik = uzmanlik + ", " + checkBox12.Text;
            }
            uzmanlik = uzmanlik.Substring(2);


            listBox1.Items.Add("TC Kimlik No: " + tcNo +  " | " + "Adı Soyadı: " +  adSoyad + " | " + "Cinsiyeti: " + cinsiyet + " | " + "Mezuniyeti: " + mezuniyet + " | " + "Bildiği Yabancı Diller: " + diller + " | " +  "Uzmanlık Alanları: " + uzmanlik);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
