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
    public partial class Quiz_Interesant : Form
    {
        int corect;
        int nr = 1;
        int score;
        int procent;
        int total;



        public Quiz_Interesant()
        {
            InitializeComponent();
            intrebare(nr);
            total = 5;
        }

        private void Check(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == corect)
            {
                score++;
            }
            if (nr == total)
            {
                procent = (int)Math.Round((double)(score * 100) / total);
                MessageBox.Show(
                    "Sfarsit!" + Environment.NewLine +
                    "Ai obtinut: " + score + " raspunsuri corecte" + Environment.NewLine +
                    "Scorul tau total este: " + procent + "%" + Environment.NewLine +
                    "Apasa OK pentru a juca din nou"
                    );
                score = 0;
                nr = 0;
                intrebare(nr);
            }
                nr++;
                intrebare(nr);
        }

        private void intrebare(int n)
        {
            switch (n)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.q1;
                    l1.Text = "Care este cea mai populara aplicatie de social media pentru partajarea de imagini și videoclipuri scurte?";
                    b1.Text = "Twitter";
                    b2.Text = "Instagram";
                    b3.Text = "Youtube";
                    b4.Text = "TikTok";
                    corect = 2;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.How_to_use_social_media_to_grow_your_business;
                    l1.Text = "Care este termenul folosit pentru acțiunea de a distribui conținutul altora pe propriul profil de social media?";
                    b1.Text = "Share";
                    b2.Text = "Post";
                    b3.Text = "Like";
                    b4.Text = "Follow";
                    corect = 1;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.q3;
                    l1.Text = "Care dintre următoarele nu este un exemplu de rețea socială?";
                    b1.Text = "Youtube";
                    b2.Text = "Snapchat";
                    b3.Text = "Google";
                    b4.Text = "Facebook";
                    corect = 3;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Why_Should_Your_Business_Use_Social_Media;
                    l1.Text = "Care este o problemă comună asociată cu utilizarea excesivă a rețelelor de socializare?";
                    b1.Text = "Reducerea conectivității cu alții";
                    b2.Text = "Creșterea nivelului de informare";
                    b3.Text = "Îmbunătățirea stării de sănătate mentală";
                    b4.Text = "Dezvoltarea unor abilități sociale îmbunătățite";
                    corect = 1;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.q2;
                    l1.Text = "Care este rețeaua de socializare orientată profesional, utilizată pentru networking și căutare de job-uri?";
                    b1.Text = "Facebook";
                    b2.Text = "Instagram";
                    b3.Text = "LinkedIn";
                    b4.Text = "Snapchat";
                    corect = 3;
                    break;
            }
        }
    }
}
