using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primul_proiect_23._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var newform = new Facebook();
            newform.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var newform = new TikTok();
            newform.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var newform = new Twitter();
            newform.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newform = new Youtube();
            newform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }
    }
}
