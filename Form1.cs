using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleEXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ouch!", "Clicked Me", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                label1.Text = "Test Success";
                textBox1.Text = "Ouch!";
            }
            else
            {
                label1.Text = "Test Canceled";
                textBox1.Text = "";
            }

        }
    }
}
