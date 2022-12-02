using System.Xml.Linq;

namespace empclass
{
    public partial class Form1 : Form
    {
        ProductionWorker productionWorker = new ProductionWorker();
        public Form1()
        {
            InitializeComponent();
        }
        public class Employee
        {
            public string? EmployeeName { get; set; }
            public int EmployeeNumber { get; set; }
        }

        public class ProductionWorker : Employee
        {
            public float HourlyPayRate { get; set; }
            public Shift Shift { get; set; }
        }
        public enum Shift
        {
            Day = 1,
            Night = 2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productionWorker.EmployeeName = textBox1.Text;
            productionWorker.EmployeeNumber = Convert.ToInt32(textBox2.Text);
            productionWorker.HourlyPayRate = Convert.ToInt32(textBox3.Text);
            productionWorker.Shift = (Shift)Enum.Parse(typeof(Shift), textBox4.Text);
            MessageBox.Show("Name - " + productionWorker.EmployeeName + ", Number - " + productionWorker.EmployeeNumber + ", Hourly pay rate - " + productionWorker.HourlyPayRate + ", Shift - " + productionWorker.Shift);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}