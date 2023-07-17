using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baquangluan
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x + y;
            tbKETQUA.Text = tbKETQUA.Text+ x.ToString()+"+"+y.ToString()+"="+kq.ToString()+"\r\n";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSoX.Text);
            int y = int.Parse(tbSoY.Text);
            int kq = x * y;
            tbKETQUA.Text = tbKETQUA.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        
        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(tbKETQUA.Text);
            sw.Close();

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
