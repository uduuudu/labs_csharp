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
    public partial class ShipWork : Form
    {
        public ShipWork()
        {
            InitializeComponent();
        }
        public List<IShip> ships = new List<IShip>();

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Tanker t = ships[listBox1.SelectedIndex] as Tanker;
                MessageBox.Show(t.upSails());

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Tanker t = ships[listBox1.SelectedIndex] as Tanker;
                MessageBox.Show(t.throwAnchor());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Tanker t = ships[listBox1.SelectedIndex] as Tanker;
                MessageBox.Show(t.showInfo());

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Tanker t = ships[listBox1.SelectedIndex] as Tanker;
                setCargo scg = new setCargo();
                if (scg.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(t.transportCargo(scg.getWeight()));
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Tanker t = ships[listBox1.SelectedIndex] as Tanker;
                MessageBox.Show(t.repair());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int current = listBox1.SelectedIndex;
                ships.RemoveAt(current);
                listBox1.Items.RemoveAt(current);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IShip ship = new Tanker();
            AddEdit add = new AddEdit(ship);
            if (add.ShowDialog() == DialogResult.OK)
            {
                ships.Add(ship);
                listBox1.Items.Add(ship);
            }
        }
    }
}
