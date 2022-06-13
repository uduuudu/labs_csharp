using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;
namespace SquareView
{
    public partial class set_size : Form
    {
        public set_size()
        {
            InitializeComponent();
        }
        public string getColor()
        {
            return COLOR.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (COLOR.Text == "" || XC.Text == "" || YC.Text == "" || YV.Text == "" || XV.Text == "")
            {
                MessageBox.Show("Некорректный ввод");
            }
            else
            {
                string color_ = COLOR.Text;
                Point center = new Point(Convert.ToDouble(XC.Text), Convert.ToDouble(YC.Text));
                Point vertex = new Point(Convert.ToDouble(XV.Text), Convert.ToDouble(YV.Text));
                Line smdg = new Line(center, vertex);

                Square square = new Square(color_, center, smdg);
                Form1 form = new Form1(square);
                this.Hide();
                form.ShowDialog();
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void COLOR_TextChanged(object sender, EventArgs e)
        {

        }

        private void YV_TextChanged(object sender, EventArgs e)
        {

        }

        private void XV_TextChanged(object sender, EventArgs e)
        {

        }

        private void YC_TextChanged(object sender, EventArgs e)
        {

        }

        private void XC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
