using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0; int pocet = 0;
            foreach (string s in textBox1.Lines)
            {
                try
                {
                    int cislo;
                    if (int.TryParse(s, out cislo))
                    {
                        if (cislo < 0)
                        {

                            soucet += cislo;
                            pocet++;
                        }
                    }
                    else
                    {
                        throw new FormatException("Jedno z cisel nelze prelozit, asi to neni cislo bro");
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                double prumer = soucet / pocet;
                if (double.IsInfinity(prumer))
                {
                    throw new OverflowException();
                }
                MessageBox.Show("prumer bro: " + prumer);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("deleno nulou? brooo...");
            }
            catch (OverflowException)
            {
                MessageBox.Show("no tak to preteklo no");
            }
        }
    }
}
