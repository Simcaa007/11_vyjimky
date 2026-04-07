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
            long c = 0;
            long[] pole = new long[textBox1.Lines.Length]; int i = 0;
            foreach (string s in textBox1.Lines)
            {
                try
                {
                    c = Convert.ToInt64(s);
                    pole[i] = c;
                    i++;

                    if (c > int.MaxValue)
                    {
                        throw new OverflowException("vetsi");
                    }
                    else if (c < int.MinValue)
                    {
                        throw new OverflowException("mensi");
                    }
                }
                catch (FormatException)
                {
                    pole[i] = 0; i++;
                }
                catch (OverflowException ex)
                {
                    if (ex.Message == "vetsi")
                    {
                        pole[i] = int.MaxValue;
                    }
                    else
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
