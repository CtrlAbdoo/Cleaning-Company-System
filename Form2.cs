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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            
            if (textBox2.Text == "1" || textBox3.Text=="1")
            {
                
                this.Hide();
                f3.Show();
                f2.Close();
            }
            else
            {
                MessageBox.Show("No Documents Found ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
