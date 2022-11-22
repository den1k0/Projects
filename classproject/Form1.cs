namespace classproject
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet obj = new Pet(textBox1.Text, textBox2.Text, Convert.ToInt16(textBox3.Text));
            label4.Text = "Stats: " + obj.type + "'s name is " + obj.name + " and it is \n" + obj.age + " years old.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Pet
    {
        public string name;
        public string type;
        public int age;

        public Pet(string Name, string Type, int Age)
        {
            name = Name;
            type = Type;
            age = Age;
        }

    }
}