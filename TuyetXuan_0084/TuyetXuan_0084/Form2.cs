using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baquangluan
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 objForm01 = new Form3();
            objForm01.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm01 = new Form1();
            objForm01.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 objForm01 = new Form4();
            objForm01.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 objForm01 = new Form5();
            objForm01.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    }
}
