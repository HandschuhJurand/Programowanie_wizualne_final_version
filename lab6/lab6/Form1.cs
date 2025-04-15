namespace lab6
{
    public partial class Form1 : Form
    {
        private int par_x;
        private int par_y;
        private int par_dydelf;
        private int par_krokodyle;
        private int par_szopy;
        private int par_czas;
        private bool par_ustawione;
        public Form1()
        {
            InitializeComponent();
        }

        public void AktualizacjaParametrow(int x, int y, int d, int k, int sz, int cz)
        {
            par_x = x;
            par_y = y;
            par_dydelf = d;
            par_krokodyle = k;
            par_szopy = sz;
            par_czas = cz;
            par_ustawione = true;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (!par_ustawione)
            {
                MessageBox.Show("Ustaw parametry gry!");
                return;
            }

            Form3 form3 = new Form3(this, par_x,  par_y, par_dydelf, par_krokodyle, par_szopy, par_czas);
            form3.Show();
            this.Hide();
        }

        private void button_ustawienia_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
