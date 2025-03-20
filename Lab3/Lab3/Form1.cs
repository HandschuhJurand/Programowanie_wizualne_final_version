namespace Lab3
{
    public partial class Form1 : Form
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public string stanowisko;
        public int ID = 1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Imie", "Imie");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Wiek", "Wiek");
            dataGridView1.Columns.Add("Stanowisko", "Stanowisko");
        }

        public void Aktualizacja_danych()
        {
            dataGridView1.Rows.Add(ID, imie, nazwisko, wiek, stanowisko);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void button_usun_Click(object sender, EventArgs e)
        {

        }

        private void button_odczyt_Click(object sender, EventArgs e)
        {

        }

        private void button_zapis_Click(object sender, EventArgs e)
        {

        }
    }
}
