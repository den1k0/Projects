namespace namesearch
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
            string[] malenames = File.ReadAllLines("C:\\Users\\roman\\Desktop\\malenames.txt");
            string[] femalenames = File.ReadAllLines("C:\\Users\\roman\\Desktop\\femalenames.txt");
            string searchelement = textBox1.Text;
            bool exists = Array.Exists(malenames, element => element == searchelement);
            if (exists)
            {
                label2.Text = "The name was popular amongst male names.";
            }
            else
            {
                bool exists2 = Array.Exists(femalenames, element => element == searchelement);
                if (exists2)
                {
                    label2.Text = "The name was popular amongst female names.";
                }
                else 
                {
                    label2.Text = "The name was not popular amongst female \n nor male names.";
                }
            }
        }
    }
}