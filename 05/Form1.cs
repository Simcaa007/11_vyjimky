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

namespace _05
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
                using (StreamReader sr = new StreamReader("..\\..\\text.txt"))
                {
                    double prumernyVek = 1;
                    int soucet = 0; int pocet = 0;
                    FileInfo fi = new FileInfo("..\\..\\text.txt");
                    if (fi.Length == 0)
                    {
                        throw new Exception("Soubor je prazdny...");
                    }
                    else
                    {
                        while (!sr.EndOfStream)
                        {
                            DateTime datum;
                            if (DateTime.TryParse(sr.ReadLine(), out datum))
                            {
                                int vek = DateTime.Now.Year - datum.Year;
                                soucet += vek;
                                pocet++;
                            }
                            else
                            {
                                throw new FormatException("Nektery z radku neni datum!");
                            }
                        }
                        prumernyVek = soucet / pocet;
                        MessageBox.Show($"Prumerny vek zapsanych lidi v textu je {prumernyVek}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Soubor nebyl naleznut!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
