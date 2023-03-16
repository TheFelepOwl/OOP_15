using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Threading.Tasks;
using System.Windows;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_15
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Kirito"&& textBox2.Text=="Asuna07")
            {
                
                Form1 newForm = new Form1();
                

                newForm.Show();

                

            }

        }
    }
}
