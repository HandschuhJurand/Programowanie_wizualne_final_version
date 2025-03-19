namespace Lab1
{
    public partial class Form1 : Form
    {

        private string aktualny_numer = "";
        private double wynik = 0.0;
        private string operacja = "";
        private bool czy_nowy_numer = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Aktualizacja_wyniku()
        {
            textBox1.Text = aktualny_numer;
        }

        private void Dopisz_numer(string numer)
        {
            if (czy_nowy_numer)
            {
                aktualny_numer = numer;
                czy_nowy_numer = false;
            }
            else
            {
                aktualny_numer += numer;
            }
            Aktualizacja_wyniku();
        }

        private void Wykonaj_operacje(string nowa_operacja)
        {
            if (!czy_nowy_numer)
            {
                if (operacja == "")
                {
                    wynik = double.Parse(textBox1.Text);
                }
                else
                {
                    Oblicz_wynik();
                }
                operacja = nowa_operacja;
                czy_nowy_numer = true;
            }
        }

        private void Oblicz_wynik()
        {
            double numb = double.Parse(textBox1.Text);
            switch (operacja)
            {
                case "+":
                    wynik += numb; 
                    break;
                case "-":
                    wynik -= numb;
                    break;
                case "x":
                    wynik *= numb;
                    break;
                case "/":
                    if (numb != 0)
                    {
                        wynik /= numb;
                    }
                    else
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez zero!!!");
                    }
                    break;
            }
            textBox1.Text = wynik.ToString();
        }

        private void button_zero_Click(object sender, EventArgs e)
        {
            Dopisz_numer("0");
        }

        private void button_jeden_Click(object sender, EventArgs e)
        {
            Dopisz_numer("1");
        }

        private void button_dwa_Click(object sender, EventArgs e)
        {
            Dopisz_numer("2");
        }

        private void button_trzy_Click(object sender, EventArgs e)
        {
            Dopisz_numer("3");
        }

        private void button_cztery_Click(object sender, EventArgs e)
        {
            Dopisz_numer("4");
        }

        private void button_piec_Click(object sender, EventArgs e)
        {
            Dopisz_numer("5");
        }

        private void button_szesc_Click(object sender, EventArgs e)
        {
            Dopisz_numer("6");
        }

        private void button_siedem_Click(object sender, EventArgs e)
        {
            Dopisz_numer("7");
        }

        private void button_osiem_Click(object sender, EventArgs e)
        {
            Dopisz_numer("8");
        }

        private void button_dziewiec_Click(object sender, EventArgs e)
        {
            Dopisz_numer("9");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_rowna_Click(object sender, EventArgs e)
        {
            if (!czy_nowy_numer && operacja != "")
            {
                Oblicz_wynik();
                operacja = "";
                czy_nowy_numer = true;
            }
        }

        private void button_przecinek_Click(object sender, EventArgs e)
        {
            if (czy_nowy_numer)
            {
                aktualny_numer = "0,";
                czy_nowy_numer = false;
            }
            else if (!textBox1.Text.Contains(","))
            {
                aktualny_numer += ",";
            }
            Aktualizacja_wyniku();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            czy_nowy_numer = true;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("-");
        }

        private void button_dzielenie_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("/");
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("+");
        }

        private void button_razy_Click(object sender, EventArgs e)
        {
            Wykonaj_operacje("x");
        }
    }
}
