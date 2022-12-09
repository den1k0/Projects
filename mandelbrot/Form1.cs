using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);
            Point currpoint = System.Windows.Forms.Cursor.Position;
            Point origin = new Point(0, 0);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            float x = float.Parse(textBox1.Text) - (float.Parse(textBox3.Text) / 2);
            float xpoint = x;
            float y = float.Parse(textBox2.Text) + (float.Parse(textBox3.Text) / 2);
            int resolution = 400;
            float step = float.Parse(textBox3.Text) / (resolution);
            int iterations = int.Parse(textBox4.Text);

            int widthpx = 0;
            int heightpx = 0;
            for (int i = 0; i < resolution; i++)
            {
                for (int j = 0; j < resolution; j++)
                {
                    Rectangle rect = new Rectangle(widthpx, heightpx, 1, 1);
                    float tempx = x;
                    float tempy = y;
                    for (int k = 0; k < iterations; k++)
                    {
                        float temp = 2 * tempx * tempy;
                        tempx = tempx * tempx;
                        tempy = (tempy * tempy) * -1;
                        tempx = tempx + tempy;
                        tempy = temp;
                        tempx = tempx + x;
                        tempy = tempy + y;
                    }
                    int comp = compare(tempx, tempy);
                    if (comp==1)
                    {
                        g.FillRectangle(blackBrush, rect);
                    }
                    else
                    {
                        g.FillRectangle(whiteBrush, rect);
                    }
                    widthpx += 1;
                    x += step;
                }
                widthpx = 0;
                heightpx += 1;
                x = xpoint;
                y -= step;
            }

            pictureBox1.Image = canvas;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height));
            pictureBox1.Image.Save("picture.jpg");
        }
        static int compare(float tempx, float tempy)
        {
            int comp = 0;
            if (tempx < 2 && tempy < 2)
            {
                if (tempx > -2 && tempy > -2)
                    comp = 1;
            }
            else
            {
                comp = 0;
            }
            return comp;
        }

    }
}