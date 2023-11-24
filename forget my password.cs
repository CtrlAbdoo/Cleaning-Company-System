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
    public partial class forget_my_password : Form
    {
        public forget_my_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="1")
            {
                MessageBox.Show("Worng National Number");

            }
            else
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "1111")
            {
                forget_my_password f1 = new forget_my_password();
                NewPassword f2 = new NewPassword();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Worng Number");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void forget_my_password_Load(object sender, EventArgs e)
        {

        }
    }
}
