using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volumeandsurfaceareacalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ShapeSelect.Text == "Sphere")
                {
                    double radius = double.Parse(textBox1.Text);
                    double V = 1.3333 * 3.14159265359 * (radius * radius * radius);
                    textBox2.ResetText();
                    textBox2.AppendText(V.ToString());
                    double A = 4 * 3.14159265359 * (radius * radius);
                    textBox3.ResetText();
                    textBox3.AppendText(A.ToString());
                }
                if (ShapeSelect.Text == "Cone")
                {
                    double radius = double.Parse(textBox1.Text);
                    double H = double.Parse(textBox4.Text);
                    double V = 3.14159265359 * (radius * radius) * (H / 3);
                    textBox2.ResetText();
                    textBox2.AppendText(V.ToString());
                    double A = 3.14159265359 * radius * (radius + Math.Sqrt((H * H) + (radius * radius)));
                    textBox3.ResetText();
                    textBox3.AppendText(A.ToString());
                }
                if (ShapeSelect.Text == "Cylinder")
                {
                    double radius = double.Parse(textBox1.Text);
                    double H = double.Parse(textBox4.Text);
                    double V = 3.14159265359 * (radius * radius) * H;
                    textBox2.ResetText();
                    textBox2.AppendText(V.ToString());
                    double A = (2 * (3.14159265359 * (radius * radius))) + ((3.14159265359 * radius * 2) * H);
                    textBox3.ResetText();
                    textBox3.AppendText(A.ToString());
                }
                if (ShapeSelect.Text == "Cube")
                {
                    double H = double.Parse(textBox4.Text);
                    double V = H * H * H;
                    textBox2.ResetText();
                    textBox2.AppendText(V.ToString());
                    double A = H * H * 6;
                    textBox3.ResetText();
                    textBox3.AppendText(A.ToString());
                }
                if (ShapeSelect.Text == "Cuboid")
                {
                    double H = double.Parse(textBox4.Text);
                    double W = double.Parse(textBox5.Text);
                    double L = double.Parse(textBox6.Text);
                    double V = H * W * L;
                    textBox2.ResetText();
                    textBox2.AppendText(V.ToString());
                    double A = (H * W * 2) + (W * L * 2) + (L * H * 2);
                    textBox3.ResetText();
                    textBox3.AppendText(A.ToString());
                }
            }
            catch
            {
                textBox2.Text = "Error";
                textBox3.Text = "Error";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShapeSelect.Text == "Sphere") 
            {
                textBox1.ReadOnly = false;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
            if (ShapeSelect.Text == "Cone") 
            {
                textBox1.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
            if (ShapeSelect.Text == "Cylinder") 
            {
                textBox1.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
            if (ShapeSelect.Text == "Cube") 
            {
                textBox1.ReadOnly = true;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
            }
            if (ShapeSelect.Text == "Cuboid") 
            {
                textBox1.ReadOnly = true;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
            }
        }
    }
}
