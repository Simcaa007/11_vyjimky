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

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucin = 1;
            int cislo = 0;
            try
            {
                using (StreamReader sr = new StreamReader("..\\..\\cisla.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            if (int.TryParse(sr.ReadLine(), out cislo))
                            {
                                checked
                                {
                                    soucin *= cislo;
                                }
                            }
                        }
                        catch (OverflowException)
                        {
                            MessageBox.Show("Došlo k přetečení!!", "Problem bejby...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show($"soucin je: {soucin}");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor nebyl naleznut!", "Problem bejby...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
