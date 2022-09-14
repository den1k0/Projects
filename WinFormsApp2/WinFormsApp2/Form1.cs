namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zodiac Signs");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "i AM Cool";
        }
    }
}