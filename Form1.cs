using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Learn_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ENTER ABVOE NUMBER";
            label1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);

            int mul = a * b;

            textBox3.Text = Convert.ToString(mul);
            label1.Text = "";
            label1.Visible = true;
            for(int i=0;i<= b; i++)
            {
                label1.Text += a + "\tX\t" + i + "\t=\t" + a * i + "\n";
            }
            
        }
    }
}
