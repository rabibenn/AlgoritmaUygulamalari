using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double KDV = 0.18, OTV = 0.45;
            double hamfiyat = 0, kdvtutari = 0, otvtutari = 0;    
            hamfiyat = Convert.ToDouble(textBox1.Text);
            otvtutari = hamfiyat *  OTV;
            kdvtutari = (hamfiyat + otvtutari) * KDV; 
            double toplam = hamfiyat + otvtutari + kdvtutari;
            textBox2.Text = Convert.ToString(otvtutari);
            textBox3.Text = Convert.ToString(kdvtutari);
            textBox4.Text = Convert.ToString(toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
