using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = 0; double mocnina = 1; int n = 0;
                if (double.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out n))
                {
                    for (int i = n; i > 0; i--)
                    {
                        mocnina *= a;
                        if (double.IsInfinity(mocnina))
                        {
                            throw new ArithmeticException("ajaj preteklo to");
                        }
                    }
                    if (n < 0)
                    {
                        mocnina = 1 / mocnina;
                    }
                }
                else
                {
                    throw new FormatException();
                }
                MessageBox.Show($"mocnina {a} na {n} je {mocnina}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Jedno z cisel a nebo n neni cislo.");
            }

            catch (ArithmeticException)
            {
                MessageBox.Show("Doslo k preteceni!!");
            }
        }
    }
}
