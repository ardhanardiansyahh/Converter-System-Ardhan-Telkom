using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasKampus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 2);
            textBox2.Text = Base;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 8);
            textBox2.Text = Base;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            string Base = Convert.ToString(number, 16);
            textBox2.Text = Base;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }
    }
}
