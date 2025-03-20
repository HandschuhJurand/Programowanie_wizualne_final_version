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
                if (wiekTemp != 0)
                {
                    wiek = wiekTemp;
                }
                else
                {
                    MessageBox.Show("Podaj poprawny wiek!");
                }
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
