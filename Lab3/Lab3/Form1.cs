using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

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

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            try
            {
                string csvContent = string.Join(";",
                    dataGridView.Columns.Cast<DataGridViewColumn>()
                    .Select(column => column.HeaderText)) + Environment.NewLine;

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        csvContent += string.Join(";",
                            row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => cell.Value?.ToString() ?? "")) + Environment.NewLine;
                    }
                }

                File.WriteAllText(filePath, csvContent, Encoding.UTF8);
                MessageBox.Show("Plik został pomyślnie wyeksportowany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas eksportu: {ex.Message}");
            }
        }

        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                dataGridView1.Rows.Clear();
                ID = 1;

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    if (values.Length == dataGridView1.Columns.Count)
                    {
                        dataGridView1.Rows.Add(values);
                        // Aktualizacja licznika ID
                        if (int.TryParse(values[0], out int currentId))
                        {
                            ID = Math.Max(ID, currentId + 1);
                        }
                    }
                }

                MessageBox.Show("Dane zostały wczytane pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas wczytywania pliku: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Pracownik został usunięty.");
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia!");
            }
        }

        private void button_odczyt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog.Title = "Wybierz plik CSV do wczytania";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                LoadCSVToDataGridView(openFileDialog.FileName);
            }
        }

        private void button_zapis_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.DefaultExt = "csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(dataGridView1, saveFileDialog.FileName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExportToXML(string file)
        {
            try
            {
                var pracownicy = new List<Pracownik>();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        pracownicy.Add(new Pracownik
                        {
                            ID = Convert.ToInt32(row.Cells["ID"].Value),
                            Imie = row.Cells["Imie"].Value.ToString(),
                            Nazwisko = row.Cells["Nazwisko"].Value.ToString(),
                            Wiek = Convert.ToInt32(row.Cells["Wiek"].Value),
                            Stanowisko = row.Cells["Stanowisko"].Value.ToString()
                        });
                    }
                }
                XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));

                using (TextWriter writer = new StreamWriter(file))
                {
                    serializer.Serialize(writer, pracownicy);
                }
                MessageBox.Show("Dane zostały zapisane");
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show("Wystapil blad podczas zapisywania danych: ", ex.Message);
                }
            }

        }

        private void LoadFromXML(string file)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Pracownik>));

                var pracownicy = new List<Pracownik>();

                using (StreamReader reader = new StreamReader(file))
                {
                    pracownicy = (List<Pracownik>)serializer.Deserialize(reader);
                }

                dataGridView1.Rows.Clear();
                ID = 1;

                foreach (var pracownik in pracownicy)
                {
                    dataGridView1.Rows.Add(
                        pracownik.ID,
                        pracownik.Imie,
                        pracownik.Nazwisko,
                        pracownik.Wiek,
                        pracownik.Stanowisko);
                    ID = Math.Max(ID, pracownik.ID + 1);
                }
                MessageBox.Show("Dane zostaly wczytane");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystapil blad podczas wczytywania: ", ex.Message);
            }
        }

        private void button_xml_zapis_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.DefaultExt = "xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToXML(saveFileDialog.FileName);

                }
            }
        }

        private void button_odczyt_xml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*";
                openFileDialog.Title = "Wybierz plik XML do wczytania";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadFromXML(openFileDialog.FileName);
                }
            }
        }
    }
}
