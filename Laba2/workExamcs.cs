using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamModel;
namespace ExamView
{
    public partial class workExamcs : Form
    {
        public workExamcs()
        {
            InitializeComponent();
        }
        public Exam ee;

        private void Создать1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Заполните все поля прежде чем продолжить!!!");
            else
            {
                if (radioButton1.Checked)
                {
                    string s = textBox1.Text;
                    try
                    {
                        int cs = int.Parse(textBox2.Text);
                        int ch = int.Parse(textBox3.Text);
                        ee = new Exam(s, cs, ch);
                        button1.Enabled = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неккоректный ввод!");
                    }


                }
                else
                {
                    string s = textBox1.Text;
                    try
                    {
                        int cs = int.Parse(textBox2.Text);
                        int ch = int.Parse(textBox3.Text);
                        int p = int.Parse(textBox4.Text);
                        ee = new Exam_inh(s, cs, ch, p);
                        button1.Enabled = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Неккоректный ввод!");
                    }

                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ee.print());
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label5.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = false;
            label5.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(ee.print());
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label5.Visible = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox4.Visible = false;
            label5.Visible = false;
        }
    }
    
}

