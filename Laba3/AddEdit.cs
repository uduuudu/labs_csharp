using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using csharp3;
namespace ShipView
{
    public partial class AddEdit : Form
    {
        Tanker t = new Tanker();
        public AddEdit(IShip s)
        {
            InitializeComponent();
            t = s as Tanker;
            textBox1.Text = t.name;
            textBox2.Text = t.loadСapacity.ToString();
            textBox3.Text = t.displacement.ToString();
            textBox4.Text = t.typeOfCargo;
            textBox5.Text = t.yearStartOperation.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveInfo();
        }

        private void SaveInfo()
        {
            t.name = textBox1.Text;
            t.loadСapacity = int.Parse(textBox2.Text);
            t.displacement = int.Parse(textBox3.Text);
            t.typeOfCargo = textBox4.Text;
            t.yearStartOperation = int.Parse(textBox5.Text);
            this.DialogResult = DialogResult.OK;
        }

    }
}
