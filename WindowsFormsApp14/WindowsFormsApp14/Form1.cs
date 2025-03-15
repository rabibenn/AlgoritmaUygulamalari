using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("Opel");
            //comboBox1.Items.Add("Renault");
            //comboBox1.Items.Add("BMW");
            string[] marka = { "Opel", "Renault", "BMW" };
            comboBox1.Items.AddRange(marka);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Opel")
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                string[] opelmodels = { "Corsa", "Crossland", "Grandland" };
                comboBox2.Items.AddRange(opelmodels);
            }
            else if (comboBox1.Text == "Renault")
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                string[] renaultmodels = { "Taliant", "Clio", "Captur" };
                comboBox2.Items.AddRange(renaultmodels);

            }
            else if (comboBox1.Text == "BMW")
            {
                comboBox3.Items.Clear();
                comboBox2.Items.Clear();
                string[] bmwmodels = { "ix", "i7", "i4" };
                comboBox2.Items.AddRange(bmwmodels);

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Corsa")
            {
                comboBox3.Items.Clear();
                string[] corsaversion = { "Edition", "Elegance", "Ultimate" };
                comboBox3.Items.AddRange(corsaversion);
            }
            else if (comboBox2.Text == "Crossland")
            {
                comboBox3.Items.Clear();
                string[] crosslandversion = { "Essential", "Edition", "Elegance" };
                comboBox3.Items.AddRange(crosslandversion);
            }
            else if (comboBox2.Text == "Grandland")
            {

                comboBox3.Items.Clear();
                string[] grandlandversion = { "Elegance", "Ultimate" };
                comboBox3.Items.AddRange(grandlandversion);

            }
            else if (comboBox2.Text == "Taliant")
            {
                comboBox3.Items.Clear();
                string[] taliantversion = { "Joy", "Touch" };
                comboBox3.Items.AddRange(taliantversion);
            }
            else if (comboBox2.Text == "Clio")
            {
                comboBox3.Items.Clear();
                string[] clioversion = { "Joy", "Touch", "Icon" };
                comboBox3.Items.AddRange(clioversion);
            }
            else if (comboBox2.Text == "Captur")
            {
                comboBox3.Items.Clear();
                string[] capturversion = { "Touch", "Icon", "r.s. line" };
                comboBox3.Items.AddRange(capturversion);
            }
            else if (comboBox2.Text == "ix")
            {
                comboBox3.Items.Clear();
                string[] ixVersiyon = { "First Edition Essence", "First Edition Sport" };
                comboBox3.Items.AddRange(ixVersiyon);
            }
            else if (comboBox2.Text == "i7")
            {
                comboBox3.Items.Clear();
                string[] i7version = { "Pure Excellence", "M Excellence" };
                comboBox3.Items.AddRange(i7version);
            }
            else if (comboBox2.Text == "i4")
            {
                comboBox3.Items.Clear();
                string[] i4version = { "eDrive40-M Sport", "M50" };
                comboBox3.Items.AddRange(i4version);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Marka:" + comboBox1.Text + " | " + "Model: " + comboBox2.Text + " | " + "Versiyon: " + comboBox3.Text);
        }
    }
}
