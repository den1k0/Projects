namespace bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kg = float.Parse(textBox1.Text);
            float m = float.Parse(textBox2.Text);
            float result = (kg / (m * m));
            textBox3.Text = "BMI: " + result.ToString("N2");
            if (result < 18.5)
            {
                textBox3.AppendText("\r\n" + "Status: underweight"); ;
            }
            if (result > 25)
            {
                textBox3.AppendText("\r\n" + "Status: overweight");
            }
            if (18.5 < result && result < 25)
            {
                textBox3.AppendText("\r\n"+ "Status: normal");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}