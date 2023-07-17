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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String txtUser = txtUsername.Text.ToString();
            String txtPass = txtpassword.Text.ToString();
            if (txtUser=="luan" && txtPass=="12345")
            {
                Form1 objForm01 = new Form1();
                objForm01.ShowDialog();
            }
        }
    }
}
