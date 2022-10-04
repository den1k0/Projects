namespace factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int16.Parse(textBox1.Text);
            if (num > 0)
            {
                int fact = 1;
                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
                label2.Text = fact.ToString();
            }
        }
    }
}