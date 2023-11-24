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
    public partial class VisaVerifection : Form
    {
        public VisaVerifection()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text=="1111")
            {
                MessageBox.Show(" Process Done Successfully ");

            }
            else
            {
                MessageBox.Show(" Worng Verifecation Code ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visa f1 = new Visa();
            this.Hide();
            f1.Show();
        }

        private void VisaVerifection_Load(object sender, EventArgs e)
        {

        }
    }
}
