using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;

namespace driverslicenseexam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] realanswers = { "b","d","a","a","c","a","b","a","c","d","b","c","d","a","d","c","c","b","d","a" };
            string[] answers = File.ReadAllLines("C:\\Users\\roman\\Desktop\\answers.txt");
            int realelement = 0;
            int correctanswers = 0;
            label8.Text = "";
            foreach (string element in answers)
            {
                if (element == realanswers[realelement])
                {
                    correctanswers += 1;
                }
                else
                {
                    label8.Text += realelement + 1 + " ";
                }
                realelement += 1;
            }
            if (correctanswers > 14)
            {
                label4.Text = "Yes";
            }
            else
            {
                label4.Text = "No";
            }
            label2.Text = correctanswers.ToString();
            int incorrectanswers = 20 - correctanswers;
            label6.Text = incorrectanswers.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}