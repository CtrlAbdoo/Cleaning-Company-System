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
               panel1.Visible = false;
               panel2.Visible = true;

            
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
            Home f1 = new Home();
            this.Hide();
            f1.Show();
        }

        private void forget_my_password_Load(object sender, EventArgs e)
        {

        }

       
    }
}
