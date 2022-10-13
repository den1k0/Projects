using System.CodeDom;

namespace rng
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = Int16.Parse(textBox1.Text);
            if (label3.Text == "???")
            {
                Random rnd = new Random();
                Globals.randomnumber = rnd.Next(1, 100);
            }
            if (guess > Globals.randomnumber)
            {
                label3.Text = "Your guess is too high";
            }
            if (guess < Globals.randomnumber)
            {
                label3.Text = "Your guess is too low";
            }
            if (guess == Globals.randomnumber)
            {
                label3.Text = "You Guessed Correctly!";
                Random rnd = new Random();
                Globals.randomnumber = rnd.Next(1, 100);
                int guesses = Int16.Parse(label4.Text);
                guesses++;
                label4.Text = guesses.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    static class Globals
    {
        public static int randomnumber;
    }
}