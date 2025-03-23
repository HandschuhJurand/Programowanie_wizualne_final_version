using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string stanowisko;
        private Form1 ParentForm;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;

            comboBox1.Items.AddRange(new string[] { "Sekretarka", "Dyrektor", "Kierownik", "Sprzątacz", "Magazynier"});
        }

        private void podaj_imie_TextChanged(object sender, EventArgs e)
        {
            imie = podaj_imie.Text;
        }

        private void podaj_nazwisko_TextChanged(object sender, EventArgs e)
        {
            nazwisko = podaj_nazwisko.Text;
        }

        private void podaj_wiek_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(podaj_wiek.Text, out int wiekTemp))
            {
                if (wiekTemp > 0 && wiekTemp < 150)  // Sprawdzanie czy wiek jest w rozsądnym zakresie
                {
                    wiek = wiekTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawny wiek (1-150 lat)!");
                    podaj_wiek.Text = "";  // Czyszczenie niepoprawnej wartości
                }
            }
            else if (!string.IsNullOrEmpty(podaj_wiek.Text))  // Sprawdzanie czy pole nie jest puste
            {
                MessageBox.Show("Proszę podać liczbę całkowitą!");
                podaj_wiek.Text = "";  // Czyszczenie niepoprawnej wartości
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                stanowisko = comboBox1.SelectedItem.ToString();
            }
        }

        private void button_zatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(podaj_imie.Text))
            {
                MessageBox.Show("Pole 'Imię' nie może być puste!");
                return;
            }

            if (string.IsNullOrWhiteSpace(podaj_nazwisko.Text))
            {
                MessageBox.Show("Pole 'Nazwisko' nie może być puste!");
                return;
            }

            if (string.IsNullOrWhiteSpace(podaj_wiek.Text))
            {
                MessageBox.Show("Pole 'Wiek' nie może być puste!");
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać stanowisko!");
                return;
            }

            ParentForm.imie = imie;
            ParentForm.nazwisko = nazwisko;
            ParentForm.wiek = wiek;
            ParentForm.stanowisko = stanowisko;
            ParentForm.Aktualizacja_danych();
            ParentForm.ID++;
            this.Close();
            ParentForm.Show();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentForm.Show();
        }
    }
}
