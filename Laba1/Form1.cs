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
    public partial class Form1 : Form
    {
        Square s;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Square sq)
        {
            InitializeComponent();
            s = sq;
            update();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {

            Point smd = s.semidg.toVector();

            X1.Text = (s.center.x + smd.x).ToString();
            Y1.Text = (s.center.y + smd.y).ToString();

            X2.Text = (s.center.x - smd.x).ToString();
            Y2.Text = (s.center.y - smd.y).ToString();

            X3.Text = (s.center.x + smd.y).ToString();
            Y3.Text = (s.center.y - smd.y).ToString();

            X4.Text = (s.center.x - smd.y).ToString();
            Y4.Text = (s.center.y + smd.x).ToString();

            COLOR.Text = s.color;

        }



       

        private void button3_Click(object sender, EventArgs e)
        {
            set sl = new set();
            sl.showElems(4);
            if (sl.ShowDialog() == DialogResult.OK)
            {
                s.turn(Convert.ToInt32(sl.getAngle()));

                update();
            }

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            set s0 = new set();
            s0.showElems(1);
            if (s0.ShowDialog() == DialogResult.OK)
            {

                int r = s.reSize(int.Parse(s0.getF()));
                update();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            set sl = new set();
            sl.showElems(0);
            if (sl.ShowDialog() == DialogResult.OK)
            {

                s.color = sl.getColor();
                update();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            set sl = new set();
            sl.showElems(2);
            if (sl.ShowDialog() == DialogResult.OK)
            {
                s.stretching(Convert.ToInt32(sl.getFactor_str()));

                update();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            set sl = new set();
            sl.showElems(3);
            if (sl.ShowDialog() == DialogResult.OK)
            {
                s.compressing(Convert.ToInt32(sl.getFactor_compr()));

                update();
            }
        }
    }
}
