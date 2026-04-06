using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radek = 0;
            DateTime datum;
            try
            {
                if (int.TryParse(textBox2.Text, out radek))
                {
                    if (radek > textBox1.Lines.Length)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        if (DateTime.TryParse(textBox1.Lines[radek - 1],out datum))
                        {
                            if (datum > DateTime.Now)
                            {
                                throw new ArgumentOutOfRangeException("narozeni je v budoucnosti, tak to asi ne zeo");
                            }
                            else
                            {
                                int vek = DateTime.Now.Year - datum.Year;
                                MessageBox.Show($"let mu je tak {vek}");
                            }
                        }
                        else
                        {
                            throw new FormatException("datum je ve spatnem formatu");
                        }
                    }
                }
                else
                {
                    throw new FormatException("zadane cislo radku neni cislo");
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("V textbox neni tolik radku bro");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
