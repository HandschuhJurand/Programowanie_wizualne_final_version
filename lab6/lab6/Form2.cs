using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form2 : Form
    {
        private int x;
        private int y;
        private int dydelfy;
        private int krokodyle;
        private int szopy;
        private int czas;
        private int liczba_pol;
        private Form1 parentForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = form1;

        }
        //DODAC WARUNKI CZY WSZYSTKO ZMIESCI SIE NA PLANSZY dwa pola: liczba wszystkoch pol, liczba dostepnych (max - minumum z do wyboru)
        private void textBox_x_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_x.Text, out int xTemp))
            {
                if (xTemp > 2 && xTemp < 11)
                {
                    x = xTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawny X (3-10)!");
                    textBox_x.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_x.Text))
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                textBox_x.Text = "";
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {

        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox_y_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_y.Text, out int yTemp))
            {
                if (yTemp > 2 && yTemp < 11)
                {
                    y = yTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawny Y (3-10)!");
                    textBox_y.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_x.Text))
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                textBox_y.Text = "";
            }
        }

        private void textBox_dydelfy_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_dydelfy.Text, out int dydelfyTemp))
            {
                if (dydelfyTemp > 0 && dydelfyTemp < 7)
                {
                    dydelfy = dydelfyTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawną liczbę dydelfów X (1-6)!");
                    textBox_dydelfy.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_x.Text))
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                textBox_dydelfy.Text = "";
            }
        }

        private void textBox_krokodyle_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_krokodyle.Text, out int krokodyleTemp))
            {
                if (krokodyleTemp >= 0 && krokodyleTemp < 2)
                {
                    krokodyle = krokodyleTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawną liczbę krokodyli (0-1)!");
                    textBox_krokodyle.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_x.Text))
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                textBox_krokodyle.Text = "";
            }
        }

        private void textBox_szopy_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_szopy.Text, out int szopyTemp))
            {
                if (szopyTemp > 2 && szopyTemp < 9)
                {
                    szopy = szopyTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawną liczbę szopów (3-8)!");
                    textBox_szopy.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(textBox_x.Text))
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                textBox_szopy.Text = "";
            }
        }

        private void textBox_czas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
