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
    public partial class Form2 : Form
    {
        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNumber1 = int.Parse(txt1.Text);
            int iNumber2 = int.Parse(txt1.Text);
            int iNumber3 = int.Parse(txt1.Text);
            int iNumber4 = int.Parse(txt1.Text);

            // Konversi

            int iConverted = iNumber1 * 8 + iNumber2 * 4 + iNumber3 * 2 + iNumber4  * 1;

            MessageBox.Show("Decimal: " + iConverted);
            // Konversi bilangan ke Binary ke hexa

            int aNumber1 = int.Parse(txt1.Text);
            int aNumber2 = int.Parse(txt2.Text);
            int aNumber3 = int.Parse(txt3.Text);
            int aNumber4 = int.Parse(txt4.Text);

            string Base = Convert.ToString(aNumber1 + aNumber2 + aNumber3 + aNumber4, 16);

            MessageBox.Show("Hexa: " + Base);
        }
    }
}
