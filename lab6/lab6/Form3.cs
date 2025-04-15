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
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        private int par_x;
        private int par_y;
        private int par_dydelf;
        private int par_krokodyl;
        private int par_szop;
        private int par_czas;
        private int pozostaly_czas;
        private System.Windows.Forms.Timer timer_gry;
        private System.Windows.Forms.Timer timer_szop;
        private System.Windows.Forms.Timer timer_krokodyl;
        private Button[,] plansza;
        private bool[,] odkryte;
        private int[,] pola;
        private int odkryte_dydelfy;
        private Button aktywny_szop;
        private Button aktywny_krokodyl;
        private Label czas_label;
        private Label dydelfy_label;
        private Random random = new Random();
        private const int CZAS_K = 2;
        private const int CZAS_SZ = 2;
        private const int ROZMIAR_PRZYCISKU = 30;

        private bool czy_gra_aktywna = true;


        public Form3(Form1 parent, int x, int y, int d, int k, int sz, int cz)
        {
            InitializeComponent();
            this.parentForm = parent;

            par_x = x;
            par_y = y;
            par_dydelf = d;
            par_szop = sz;
            par_krokodyl = k;
            par_czas = cz;
            pozostaly_czas = cz;

            plansza = new Button[x, y];
            odkryte = new bool[x, y];
            pola = new int[x, y];
            odkryte_dydelfy = 0;

            Utworzenie_timerow();

            Utworz_Plansze();

            Rozmieszczenie_Pol(par_dydelf, par_krokodyl, par_szop);

            Dodaj_Liczniki();

            timer_gry.Start();
        }

        private void Utworzenie_timerow()
        {
            timer_gry = new System.Windows.Forms.Timer();
            timer_gry.Interval = 1000;
            timer_gry.Tick += Timer_Tick;

            timer_krokodyl = new System.Windows.Forms.Timer();
            timer_krokodyl.Interval = 2000;
            timer_krokodyl.Tick += TimerKrokodyl_Tick;

            timer_szop = new System.Windows.Forms.Timer();
            timer_szop.Interval = 2000;
            timer_szop.Tick += TimerSzop_Tick;
        }

        private void Utworz_Plansze()
        {
            int margin = 5;
            int dodatkowa_wysokosc = 80;

            for (int x = 0; x < par_x; x++)
            {
                for (int y = 0; y < par_y; y++)
                {
                    Button button = new Button();
                    button.Size = new Size(ROZMIAR_PRZYCISKU, ROZMIAR_PRZYCISKU);
                    button.Location = new Point(margin + x * (ROZMIAR_PRZYCISKU + margin), margin + y * (ROZMIAR_PRZYCISKU + margin));
                    button.Name = $"button_{x}_{y}";
                    button.Click += Pole_Click;
                    button.Font = new Font("Arial", 12, FontStyle.Bold);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    plansza[x, y] = button;
                    this.Controls.Add(button);
                }
            }

            this.ClientSize = new Size(
                margin + par_x * (ROZMIAR_PRZYCISKU + margin) + 40,
                margin + par_y * (ROZMIAR_PRZYCISKU + margin) + dodatkowa_wysokosc);
        }

        private void Rozmieszczenie_Pol(int dydelfy, int krokodyle, int szopy)
        {
            List<(int x, int y)> dostepnePola = new List<(int x, int y)>();
            for (int x = 0; x < par_x; x++)
                for (int y = 0; y < par_y; y++)
                    dostepnePola.Add((x, y));

            // Rozmieszczenie dydelfów
            for (int i = 0; i < dydelfy; i++)
            {
                int index = random.Next(dostepnePola.Count);
                var (x, y) = dostepnePola[index];
                pola[x, y] = 1;
                dostepnePola.RemoveAt(index);
            }

            // Rozmieszczenie krokodyla
            if (krokodyle > 0)
            {
                int index = random.Next(dostepnePola.Count);
                var (x, y) = dostepnePola[index];
                pola[x, y] = 2;
                dostepnePola.RemoveAt(index);
            }

            // Rozmieszczenie szopów
            for (int i = 0; i < szopy; i++)
            {
                int index = random.Next(dostepnePola.Count);
                var (x, y) = dostepnePola[index];
                pola[x, y] = 3;
                dostepnePola.RemoveAt(index);
            }
        }

        private void Pole_Click(object sender, EventArgs e)
        {
            if (!czy_gra_aktywna) return;

            Button clickedButton = (Button)sender;
            string[] coords = clickedButton.Name.Split('_');
            int x = int.Parse(coords[1]);
            int y = int.Parse(coords[2]);

            if (odkryte[x, y] && pola[x, y] != 1) return;  // Pozwalamy na ponowne kliknięcie tylko w dydelfa

            switch (pola[x, y])
            {
                case 1: // Dydelf
                    clickedButton.Text = "D";
                    odkryte[x, y] = true;  // Tylko dydelfy są oznaczone jako odkryte na stałe
                    odkryte_dydelfy++;
                    dydelfy_label.Text = $"Znalezione dydelfy: {odkryte_dydelfy}/{par_dydelf}";
                    if (odkryte_dydelfy == par_dydelf)
                    {
                        Koniec_gry(true, "Gratulacje! Znalazłeś wszystkie dydelfy!");
                    }
                    break;

                case 2: // Krokodyl
                    if (aktywny_krokodyl == clickedButton)
                    {
                        // Drugie kliknięcie w krokodyla - zamykamy go
                        aktywny_krokodyl.Text = "";
                        aktywny_krokodyl = null;
                        timer_krokodyl.Stop();
                    }
                    else
                    {
                        // Pierwsze kliknięcie w krokodyla
                        clickedButton.Text = "K";
                        aktywny_krokodyl = clickedButton;
                        timer_krokodyl.Start();
                    }
                    break;

                case 3: // Szop
                    clickedButton.Text = "SZ";
                    aktywny_szop = clickedButton;
                    // Pokaż sąsiednie pola
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            int newX = x + dx;
                            int newY = y + dy;

                            if (newX >= 0 && newX < par_x && newY >= 0 && newY < par_y)
                            {
                                if (!odkryte[newX, newY])
                                {
                                    plansza[newX, newY].Text = "?";
                                }
                            }
                        }
                    }
                    timer_szop.Start();
                    break;

                default: // Puste pole
                    clickedButton.Text = "-";
                    break;
            }
        }

        private void Dodaj_Liczniki()
        {
            czas_label = new Label();
            czas_label.AutoSize = true;
            czas_label.Location = new Point(10, this.ClientSize.Height - 30);
            czas_label.Text = $"Pozostały czas: {pozostaly_czas} s";

            dydelfy_label = new Label();
            dydelfy_label.AutoSize = true;
            dydelfy_label.Location = new Point(10, this.ClientSize.Height - 10);
            dydelfy_label.Text = $"Znalezione dydelfy: {odkryte_dydelfy}/{par_dydelf}";

            this.Controls.Add(czas_label);
            this.Controls.Add(dydelfy_label);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pozostaly_czas--;
            czas_label.Text = $"Pozostały czas: {pozostaly_czas} s";

            if (pozostaly_czas <= 0)
            {
                Koniec_gry(false, "KONIEC CZASU!");
            }
        }

        private void TimerKrokodyl_Tick(object sender, EventArgs e)
        {
            if (aktywny_krokodyl != null)
            {
                // Gracz nie zdążył kliknąć ponownie w ciągu 2 sekund
                timer_krokodyl.Stop();
                Koniec_gry(false, "Krokodyl Cię złapał! Koniec gry!");
            }
        }

        private void TimerSzop_Tick(object sender, EventArgs e)
        {
            if (aktywny_szop != null)
            {
                string[] coords = aktywny_szop.Name.Split('_');
                int x = int.Parse(coords[1]);
                int y = int.Parse(coords[2]);

                // Ukryj ikonkę szopa
                aktywny_szop.Text = "";

                // Ukryj wszystkie sąsiednie pola
                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int newX = x + dx;
                        int newY = y + dy;

                        if (newX >= 0 && newX < par_x && newY >= 0 && newY < par_y)
                        {
                            if (!odkryte[newX, newY])
                            {
                                plansza[newX, newY].Text = "";
                            }
                        }
                    }
                }
                aktywny_szop = null;
            }
            timer_szop.Stop();
        }

        private void Koniec_gry(bool wygrana, string message)
        {
            czy_gra_aktywna = false;
            timer_gry.Stop();
            timer_krokodyl.Stop();
            timer_szop.Stop();

            // Wyswietlenie wszystkich dydelfow
            for (int x = 0; x < par_x; x++)
            {
                for (int y = 0; y < par_y; y++)
                {
                    if (pola[x, y] == 1 && !odkryte[x, y])
                    {
                        plansza[x, y].Text = "D";
                    }   
                }
            }

            MessageBox.Show(message);

            System.Windows.Forms.Timer powrotTimer = new System.Windows.Forms.Timer();
            powrotTimer.Interval = 5000;
            powrotTimer.Tick += (s, e) =>
            {
                powrotTimer.Stop();
                this.Close();
                parentForm.Show();
            };
            powrotTimer.Start();
        }
    }
}
