namespace rps
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winner(1, random.Next(1, 4));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            winner(2, random.Next(1, 4));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            winner(3, random.Next(1, 4));
        }
        public void winner(int player, int ai)
        {
            if (player == ai)
            {
                label4.Text = "Tie";
            }
            else if (player == 1 && ai == 2)
            {
                label4.Text = "You Lost";
            }
            else if (player == 1 && ai == 3)
            {
                label4.Text = "You Won";
            }
            else if (player == 2 && ai == 1)
            {
                label4.Text = "You Won";
            }
            else if (player == 2 && ai == 3)
            {
                label4.Text = "You Lost";
            }
            else if (player == 3 && ai == 1)
            {
                label4.Text = "You Lost";
            }
            else if (player == 3 && ai == 2)
            {
                label4.Text = "You Won";
            }
            if (ai == 1)
            {
                label2.Text = "Rock";
            }
            else if (ai == 2)
            {
                label2.Text = "Paper";
            }
            else if (ai == 3)
            {
                label2.Text = "Scissors";
            }
        }
    }
}