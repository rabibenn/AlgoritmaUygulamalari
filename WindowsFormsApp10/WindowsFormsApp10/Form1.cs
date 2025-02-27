using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diller = "" ;
            
            if(checkBox1.Checked == true)
            {
                diller = diller + ", " + checkBox1.Text;
            }


            if (checkBox2.Checked == true)
            {
                diller = diller + ", " + checkBox2.Text;
            }


            if (checkBox3.Checked == true)
            {
                diller = diller + ", " + checkBox3.Text;
            }


            if (checkBox4.Checked == true)
            {
                diller = diller + ", " + checkBox4.Text;
            }

            diller =
            diller.Substring(1);
            label2.Text = diller;

        }
    }
}
