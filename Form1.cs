using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace OOP_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            
            InitializeComponent();
            button3.MouseMove += button3_MouseMove;
            button3.MouseLeave += button3_MouseLeave;

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            
            button3.Visible = false;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            float z_1 = float.Parse(textBox1.Text);
            float z_2 = float.Parse(textBox2.Text);
            float z_3 = float.Parse(textBox3.Text);

            float p_1 = float.Parse(textBox4.Text);
            float p_2 = float.Parse(textBox5.Text);
            float p_3 = float.Parse(textBox6.Text);

            List<float> list = new List<float> { z_1, z_2, z_3, p_1, p_2,p_3 };

           



            Form2 newForm = new Form2( list );
            newForm.Size = new Size(480, 589);
            
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }

    


}