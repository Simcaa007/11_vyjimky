using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;int b = 0;int c = 0;
            try
            {
                if (int.TryParse(textBox1.Text, out a))
                {

                }
                else
                {
                    throw new FormatException("no takze prvni cislo je v haji");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Focus();
            }

            try
            {
                if (int.TryParse(textBox2.Text, out b))
                {

                }
                else
                {
                    throw new FormatException("no takze druhe cislo je v haji");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Focus();
            }

            try
            {
                if (int.TryParse(textBox3.Text, out c))
                {

                }
                else
                {
                    throw new FormatException("no takze treti cislo je v haji");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Focus();
            }

            if (b != 0)
            {
                double d = (b * b) - (4 * a * c);

                if (d > 0)
                {
                    double x1 = (-a * Math.Sqrt(d))
                }
            }
            else
            {

            }
        }
    }
}
