using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            int[] pole = new int[textBox1.Lines.Length]; int i = 0;
            foreach (string s in textBox1.Lines)
            {
                try
                {
                    if (int.TryParse(s, out c))
                    {
                        pole[i] = c;
                        i++;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                    if (c > int.MaxValue || c < int.MinValue)
                    {
                        throw new OverflowException();
                    }
                }
                catch (FormatException)
                {
                    pole[i] = 0; i++;
                }
                catch (OverflowException)
                {
                    if (c > int.MaxValue)
                    {
                        pole[i] = int.MaxValue;
                    }
                    else if (c < int.MinValue)
                    {
                        pole[i] = int.MinValue;
                    }
                }
            }

            foreach (int p in pole)
            {
                listBox1.Items.Add(p);
            }
        }
    }
}
