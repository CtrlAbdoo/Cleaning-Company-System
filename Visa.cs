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
    public partial class Visa : Form
    {
        public Visa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisaVerifection f1 = new VisaVerifection();
            this.Hide();
            f1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void Visa_Load(object sender, EventArgs e)
        {

        }
    }
}
