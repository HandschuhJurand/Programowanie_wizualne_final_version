namespace Lab2
{
    public partial class Form1 : Form
    {
        public decimal cena_komputera = 0;
        public decimal cena_monitora = 0;

        public Form1()
        {
            InitializeComponent();
            Aktualizacja_cen();
        }

        public void Aktualizacja_cen()
        {
            decimal suma = cena_komputera + cena_monitora;
            textBox_cena_zestawu.Text = suma.ToString();
        }

        private void button_komputer_Click(object sender, EventArgs e)
        {
            Komputer form2 = new Komputer(this);
            form2.Show();
            this.Hide();
        }

        private void button_monitor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void textBox_cena_zestawu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
