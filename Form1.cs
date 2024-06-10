using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_bangcuuchuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbsketqua.Items.Clear();
            int cc = Convert.ToInt32(txtSo.Text);
            for (int i = 1; i <= 10; i++)
            {
                //lbsketqua.Items.Add(txtSo.Text + " x " + i.ToString() + "=" + Convert.ToString(cc+1)
                lbsketqua.Items.Add(string.Format("{0}x{1}={2}", txtSo.Text, i.ToString(), Convert.ToString(cc*i)));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
