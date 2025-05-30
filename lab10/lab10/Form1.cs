using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace lab10
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> sekwencje = new Dictionary<string, string>();
        private Chart wykres;

        public Form1()
        {
            InitializeComponent();

            wykres = new Chart();
            wykres.Name = "wykres";
            wykres.Location = new System.Drawing.Point(350, 20);
            wykres.Size = new System.Drawing.Size(400, 300);
            var chartArea = new ChartArea();
            wykres.ChartAreas.Add(chartArea);
            this.Controls.Add(wykres);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void lista_sekwencji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista_sekwencji.SelectedItems.Count > 0)
            {
                var naglowek = lista_sekwencji.SelectedItems[0].Text;
                var sekwencja = sekwencje[naglowek];
                Pokaz_szczegoly(naglowek, sekwencja);
            }
        }

        private void Pokaz_szczegoly(string naglowek, string sekwencja)
        {
            double gc = Oblicz_GC(sekwencja);
            int kodony = Liczba_kodonow(sekwencja);
            var zasady = Licz_zasady(sekwencja);

            textBox_GC.Text = $"{gc:F2}%";
            textBox_kodony.Text = kodony.ToString();
            textBox_zasady.Text = $"A: {zasady['A']}\r\nT: {zasady['T']}\r\nC: {zasady['C']}\r\nG: {zasady['G']}";
        }

        private double Oblicz_GC(string sekwencja)
        {
            int gc = 0;
            foreach (char c in sekwencja)
            {
                if (c == 'G' || c == 'g' || c == 'C' || c == 'c')
                    gc++;
            }

            double wynik;
            if (sekwencja.Length > 0)
                wynik = (double)gc / sekwencja.Length * 100;
            else
                wynik = 0;

            return wynik;
        }

        private int Liczba_kodonow(string sekwencja)
        {
            return sekwencja.Length / 3;
        }

        private Dictionary<char, int> Licz_zasady(string sekwencja)
        {
            var wynik = new Dictionary<char, int> { { 'A', 0 }, { 'T', 0 }, { 'C', 0 }, { 'G', 0 } };
            foreach (char c in sekwencja.ToUpper())
            {
                if (wynik.ContainsKey(c))
                    wynik[c]++;
            }
            return wynik;
        }

        private void button_wczytaj_fasta_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Pliki FASTA|*.fasta;*.fa|Wszystkie pliki|*.*";
                openFileDialog.Title = "Wybierz plik FASTA";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (var fileName in openFileDialog.FileNames)
                    {
                        var nowe_sekwencje = Wczytaj_fasta(fileName);
                        foreach (var para in nowe_sekwencje)
                        {
                            sekwencje[para.Key] = para.Value;
                        }
                    }
                    Aktualizuj_liste();
                    Aktualizuj_wykres();
                }
            }
        }

        private Dictionary<string, string> Wczytaj_fasta(string sciezka)
        {
            var wynik = new Dictionary<string, string>();
            string naglowek = null;
            var sb = new StringBuilder();

            foreach (var linia in File.ReadLines(sciezka))
            {
                if (string.IsNullOrWhiteSpace(linia)) continue;
                if (linia.StartsWith(">"))
                {
                    if (naglowek != null)
                        wynik[naglowek] = sb.ToString();
                    naglowek = linia.Substring(1).Trim();
                    sb.Clear();
                }
                else
                {
                    sb.Append(linia.Trim());
                }
            }
            if (naglowek != null)
                wynik[naglowek] = sb.ToString();

            return wynik;
        }

        private void Aktualizuj_liste()
        {
            lista_sekwencji.Items.Clear();
            foreach (var para in sekwencje)
            {
                var item = new ListViewItem(para.Key);
                item.SubItems.Add(para.Value.Length.ToString());
                lista_sekwencji.Items.Add(item);
            }
        }

        private void Aktualizuj_wykres()
        {
            wykres.Series.Clear();
            wykres.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            var seria = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "D³ugoœæ sekwencji",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
            };

            foreach (var para in sekwencje)
            {
                seria.Points.AddXY(para.Key, para.Value.Length);
            }

            wykres.Series.Add(seria);
        }

        private void button_zapis_CSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki CSV|*.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(sekwencje, saveFileDialog.FileName);
                }
            }
        }

        private void button_zapis_JSON_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki JSON|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToJSON(sekwencje, saveFileDialog.FileName);
                }
            }
        }

        private void ExportToJSON(Dictionary<string, string> sekwencje, string filePath)
        {
            try
            {
                var lista = new List<object>();

                foreach (var para in sekwencje)
                {
                    string naglowek = para.Key;
                    string sekwencja = para.Value;
                    int dlugosc = sekwencja.Length;
                    double gc = Oblicz_GC(sekwencja);
                    int kodony = Liczba_kodonow(sekwencja);
                    var zasady = Licz_zasady(sekwencja);

                    lista.Add(new
                    {
                        nazwa = naglowek,
                        dlugosc = dlugosc,
                        gc = gc,
                        kodony = kodony,
                        A = zasady['A'],
                        T = zasady['T'],
                        C = zasady['C'],
                        G = zasady['G']
                    });
                }

                string jsonString = JsonSerializer.Serialize(lista, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                File.WriteAllText(filePath, jsonString, Encoding.UTF8);
                MessageBox.Show("Dane zosta³y zapisane do pliku JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d podczas eksportu do JSON: {ex.Message}");
            }
        }

        private void ExportToCSV(Dictionary<string, string> sekwencje, string filePath)
        {
            try
            {
                string csvContent = "Nazwa sekwencji;D³ugoœæ;Zawartoœæ GC (%);Liczba kodonów;A;T;C;G" + Environment.NewLine;

                foreach (var para in sekwencje)
                {
                    string naglowek = para.Key;
                    string sekwencja = para.Value;
                    int dlugosc = sekwencja.Length;
                    double gc = Oblicz_GC(sekwencja);
                    int kodony = Liczba_kodonow(sekwencja);
                    var zasady = Licz_zasady(sekwencja);

                    csvContent += string.Join(";",
                        naglowek,
                        dlugosc,
                        gc.ToString("F2"),
                        kodony,
                        zasady['A'],
                        zasady['T'],
                        zasady['C'],
                        zasady['G']
                    ) + Environment.NewLine;
                }

                File.WriteAllText(filePath, csvContent, Encoding.UTF8);
                MessageBox.Show("Plik zosta³ pomyœlnie wyeksportowany!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wyst¹pi³ b³¹d podczas eksportu: {ex.Message}");
            }
        }

        private void textBox_GC_TextChanged(object sender, EventArgs e) { }
        private void textBox_kodony_TextChanged(object sender, EventArgs e) { }
        private void textBox_zasady_TextChanged(object sender, EventArgs e) { }
    }
}