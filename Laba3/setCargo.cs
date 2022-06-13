using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipView
{
    public partial class setCargo : Form
    {
        public setCargo()
        {
            InitializeComponent();
        }

        public int getWeight()
        {
            return int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
