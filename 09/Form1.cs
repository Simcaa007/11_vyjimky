using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c1 = 0; int c2 = 0;
            try
            {
                if (int.TryParse(textBox1.Text, out c1))
                {
                }
                else
                {
                    throw new FormatException("prvni textbox neobsahuje cislo");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Focus();
            }

            try
            {
                if (int.TryParse(textBox2.Text, out c2))
                {
                }
                else
                {
                    throw new FormatException("druhy textbox neobsahuje cislo");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                textBox2.Focus();
            }

            try
            {
                int soucin = c1 * c2;
                MessageBox.Show($"soucin je {soucin}");
            }
            catch (OverflowException)
            {
                MessageBox.Show("pri nasobeni doslo k preteceni");
            }
            try
            {
                double deleni = c1 / c2;
                MessageBox.Show($"deleno je {deleni}");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("vazne chces delit nulou jo?");
            }
        }
    }
}
