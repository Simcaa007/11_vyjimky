using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _06
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
                using (StreamReader sr = new StreamReader("..\\..\\CelaCisla.txt"))
                {
                    int pocet = 0;
                    int soucet = 0;
                    while (!sr.EndOfStream)
                    {
                        int cislo;
                        try
                        {
                            if (int.TryParse(sr.ReadLine(), out cislo))
                            {
                                listBox1.Items.Add(cislo);
                                if (cislo % 7 == 0)
                                {
                                    soucet += cislo;
                                    pocet++;
                                }
                            }
                            else
                            {
                                throw new FormatException("Některé ze zapsanych cisel neni cislo.");
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
                        MessageBox.Show($"prumer cisel deliteltnych nulou je {prumer}");
                    }
                    catch (DivideByZeroException)
                    {
                        MessageBox.Show("Deleni nulou nelze jakoby bejby");
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Doslo k preteceni prej");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor nebyl naleznut.");
            }
        }
    }
}
