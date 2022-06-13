using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareView
{
    public partial class set : Form
    {
        public set()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void showElems(int choice)
        {
            switch (choice)
            {
                case 0:
                    {
                        textBox2.Visible = true;
                        label2.Visible = true;
                        break;
                    }
                case 1:
                    {
                        textBox1.Visible = true;
                        label1.Visible = true;
                        break;
                    }
                case 2:
                    {
                        f_str.Visible = true;
                        label4.Visible = true;
                        break;
                    }
                case 3:
                    {
                        f_compr.Visible = true;
                        label4.Visible = true;
                        break;
                    }
                case 4:
                    {
                        label5.Visible = true;
                        angle.Visible = true;
                        break;
                    }


            }


        }

        public string getF()
        {
            return textBox1.Text;
        }
        public string getColor()
        {
            return textBox2.Text;
        }
        public string getAngle()
        {
            return angle.Text;
        }
        public string getFactor_str()
        {
            return f_str.Text;
        }
        public string getFactor_compr()
        {
            return f_compr.Text;
        }
    }
}
