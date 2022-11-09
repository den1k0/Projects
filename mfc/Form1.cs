namespace mfc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = textBox1.Text;
            int[] charCount = new int[256];
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                charCount[str[i]]++;
            }
            int maxCount = -1;
            char character = ' ';
            for (int i = 0; i < length; i++)
            {
                if (maxCount < charCount[str[i]])
                {
                    maxCount = charCount[str[i]];
                    character = str[i];
                }
            }
            label2.Text = "Most Frequet Character: " + character;
            label3.Text = "It Occurs: " + maxCount + " times";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}