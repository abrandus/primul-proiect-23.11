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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void c_Click(object sender, EventArgs e)
        {
            if (rb3.Checked) MessageBox.Show("Cred ca trebuie sa folosim schimbatorul de opinii...");
            else if (rb1.Checked && rb6.Checked && rb8.Checked) MessageBox.Show("Felicitari! Ai raspuns corect la 3/3 intrebari");
            else if (rb1.Checked && rb6.Checked || rb1.Checked && rb8.Checked || rb6.Checked && rb8.Checked) MessageBox.Show("Ai raspuns corect la 2/3 intrebari");
            else if (rb1.Checked || rb6.Checked || rb8.Checked) MessageBox.Show("Ai raspuns corect la 1/3 intrebari");
            else MessageBox.Show("Ai raspuns gresit la toate intrebarile");
            
                
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz_Interesant quiz_Interesant = new Quiz_Interesant();
            this.Hide();
            quiz_Interesant.ShowDialog();
            this.Show();
        }
    }
}
