using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;

            string diller = "", mezuniyeti = "";

            for (int i = 0; i < Türkçe.CheckedItems.Count; i++)
            {
                diller += " ," + Türkçe.CheckedItems[i];
            }

            diller = diller.Substring(2);
            label6.Text = diller;

            if (radioButton1.Checked)
            {
                mezuniyeti = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                mezuniyeti = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                mezuniyeti = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                mezuniyeti = radioButton4.Text;
            }
            label8.Text = mezuniyeti;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                if (Türkçe.Items.Contains(textBox2.Text) == false)
                {
                    Türkçe.Items.Add(textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Belirtilen dil zaten listede vardır.");
                }
                textBox2.Text = "";
            }
        }

        private void Türkçe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)                                                                                     
        {
            while(Türkçe.CheckedIndices.Count > 0)
            {
                Türkçe.SetItemChecked(Türkçe.CheckedIndices[0],(false));
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = Türkçe.Items.Count - 1; i >= 0; i--)
            {
                if (Türkçe.GetItemChecked(i))
                {
                    Türkçe.Items.Remove(Türkçe.Items[i]);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
