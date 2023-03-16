using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_15
{
    public partial class Form2 : Form
    {
        public Form2(List<float> list)
        {
            InitializeComponent();

            float a = list[0] * list[3];
            float b = list[1] * list[4];
            float c = list[2] * list[5];  
            float res=a + b + c;

            textBox1.Text = a.ToString("0.00");
            textBox2.Text = b.ToString("0.00");
            textBox3.Text = c.ToString("0.00");

            textBox4.Text = res.ToString("0.00");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
