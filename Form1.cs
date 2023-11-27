using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="1"&& textBox2.Text=="1")
            {
                Form1 f1 = new Form1();
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong National Number or Password");
            }

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            forget_my_password f2 = new forget_my_password();
            this.Hide();
            f2.Show();
        }
    }
}
