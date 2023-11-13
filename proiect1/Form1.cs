using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace proiect1
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(400, 400);
        Graphics g_bg, g, g_temp;
        Color culoare;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Image img;
        private void button1_Click(object sender, EventArgs e)
        {
            Image image = new Bitmap(400, 400);
            Graphics img = Graphics.FromImage(image);
            img.DrawImage(bmp, 0, 0, 400, 400);

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(.PNG)|.png|JPEG files (.jpeg)|.jpeg|All files (.)|.";
            sf.FileName = "Pictura";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                image.Save(sf.FileName, ImageFormat.Png);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect realizat de Radeanu Liviu Eduard, Grupa M525");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            culoare = cd.Color;
            MessageBox.Show(culoare.ToString());

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            triunghi triunghi=new triunghi();
            triunghi.deseneaza(Color.Red, e);

        }
    }
}
