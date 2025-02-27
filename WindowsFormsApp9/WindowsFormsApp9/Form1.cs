using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                label1.Text = "Alo 171'i arayarak sigarayı bırakmanıza yardımcı olmalarına müsaade edebilirsiniz.";
            }

            else if (checkBox1.Checked == false)
            {
                label1.Text = "Hem kendi hem de toplum sağlığını korduğunuz için teşekkür ederiz.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
