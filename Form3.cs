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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "75 LE";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked==true)
                MessageBox.Show(" Process Done Successfully ");
            else if (radioButton4.Checked==true)
            {
                this.Hide();
                Visa f1 = new Visa();
                f1.Show();
            }
            else
                MessageBox.Show("Choose payment Method");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
                       
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "100 LE";
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                MessageBox.Show(" Process Done Successfully ");
            else if (radioButton4.Checked == true)
            {
                this.Hide();
                Visa f1 = new Visa();
                f1.Show();
            }
            else
                MessageBox.Show("Choose payment Method");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
