using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QRCoder;
using System.Drawing;
using System.IO;

namespace lab11
{
    public partial class Form1 : Form
    {
        private List<Probki> listaProbek = new List<Probki>();
        private DatabaseManager db = new DatabaseManager();
        private Bitmap QR_bitmapa = null;

        public Form1()
        {
            InitializeComponent();
            comboBox_filtowanie.Items.AddRange(new string[] { "Wszystkie", "DNA", "RNA", "Bia³ko", "Inny" });
            comboBox_filtowanie.SelectedIndex = 0;
            OdswiezWidok();
        }

        private void OdswiezWidok()
        {
            dataGridView_probki.DataSource = null;
            dataGridView_probki.DataSource = listaProbek;
            if (dataGridView_probki.Columns["SampleId"] != null)
                dataGridView_probki.Columns["SampleId"].HeaderText = "ID próbki";
            if (dataGridView_probki.Columns["Name"] != null)
                dataGridView_probki.Columns["Name"].HeaderText = "Nazwa próbki";
            if (dataGridView_probki.Columns["Type"] != null)
                dataGridView_probki.Columns["Type"].HeaderText = "Typ";
            if (dataGridView_probki.Columns["CollectionDate"] != null)
                dataGridView_probki.Columns["CollectionDate"].HeaderText = "Data pobrania";
            if (dataGridView_probki.Columns["Description"] != null)
                dataGridView_probki.Columns["Description"].HeaderText = "Opis";
        }

        private void Filtrowanie_i_wyszukaiwanie()
        {
            string tekst = textBox_wyszukaj.Text.ToLower();
            string typ = comboBox_filtowanie.SelectedItem?.ToString();

            var filtr = listaProbek.Where(p =>
                (string.IsNullOrEmpty(tekst) ||
                 p.SampleId.ToLower().Contains(tekst) ||
                 p.Name.ToLower().Contains(tekst) ||
                 p.Description.ToLower().Contains(tekst))
                &&
                (
                    string.IsNullOrEmpty(typ) ||
                    typ == "Wszystkie" ||
                    p.Type == StringToSampleType(typ)
                )
            ).ToList();

            dataGridView_probki.DataSource = null;
            dataGridView_probki.DataSource = filtr;

            if (dataGridView_probki.Columns["SampleId"] != null)
                dataGridView_probki.Columns["SampleId"].HeaderText = "ID próbki";
            if (dataGridView_probki.Columns["Name"] != null)
                dataGridView_probki.Columns["Name"].HeaderText = "Nazwa próbki";
            if (dataGridView_probki.Columns["Type"] != null)
                dataGridView_probki.Columns["Type"].HeaderText = "Typ";
            if (dataGridView_probki.Columns["CollectionDate"] != null)
                dataGridView_probki.Columns["CollectionDate"].HeaderText = "Data pobrania";
            if (dataGridView_probki.Columns["Description"] != null)
                dataGridView_probki.Columns["Description"].HeaderText = "Opis";
        }
        private SampleType StringToSampleType(string typ)
        {
            switch (typ)
            {
                case "DNA": return SampleType.DNA;
                case "RNA": return SampleType.RNA;
                case "Bia³ko": return SampleType.Protein;
                case "Inny": return SampleType.Other;
                default: return SampleType.Other;
            }
        }

        private string TypEnumNaString(SampleType typ)
        {
            switch (typ)
            {
                case SampleType.DNA: return "DNA";
                case SampleType.RNA: return "RNA";
                case SampleType.Protein: return "Bia³ko";
                case SampleType.Other: return "Inny";
                default: return "Inny";
            }
        }

        private void dataGridView_probki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_probki.CurrentRow != null && dataGridView_probki.CurrentRow.Index >= 0)
            {
                Probki wybrana = (Probki)dataGridView_probki.CurrentRow.DataBoundItem;
            }
        }

        private void textBox_wyszukaj_TextChanged(object sender, EventArgs e)
        {
            Filtrowanie_i_wyszukaiwanie();
        }

        private void comboBox_filtowanie_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrowanie_i_wyszukaiwanie();
        }

        private void button_wyszukaj_Click(object sender, EventArgs e)
        {
            Filtrowanie_i_wyszukaiwanie();
        }

        private void button_dodaj_probke_Click(object sender, EventArgs e)
        {
            var istniejace_ID = listaProbek.Select(p => p.SampleId).ToList();
            Form2 form2 = new Form2(istniejace_ID);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                listaProbek.Add(form2.Sample);
                OdswiezWidok();
            }
        }

        private void button_edytuj_probke_Click(object sender, EventArgs e)
        {
            if (dataGridView_probki.CurrentRow == null || dataGridView_probki.CurrentRow.Index < 0)
            {
                MessageBox.Show("Wybierz wiersz do edycji!");
                return;
            }

            Probki wybrana = (Probki)dataGridView_probki.CurrentRow.DataBoundItem;
            var existingIds = listaProbek.Select(p => p.SampleId).ToList();
            Form2 form2 = new Form2(wybrana, existingIds);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                OdswiezWidok();
            }
        }

        private void button_generacja_QR_Click(object sender, EventArgs e)
        {
            if (dataGridView_probki.CurrentRow == null)
            {
                MessageBox.Show("Wybierz próbkê!");
                return;
            }
            Probki sample = (Probki)dataGridView_probki.CurrentRow.DataBoundItem;
            string qrText = $"ID: {sample.SampleId}\nNazwa: {sample.Name}\nTyp: {TypEnumNaString(sample.Type)}\nData: {sample.CollectionDate:yyyy-MM-dd}\nOpis: {sample.Description}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QR_bitmapa = qrCode.GetGraphic(20);

            Form qrPreview = new Form();
            qrPreview.Text = "Podgl¹d QR";
            PictureBox pb = new PictureBox { Image = QR_bitmapa, Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom };
            qrPreview.Controls.Add(pb);
            qrPreview.ClientSize = new Size(300, 300);
            qrPreview.ShowDialog();
        }

        private void button_eksport_QR_Click(object sender, EventArgs e)
        {
            if (QR_bitmapa == null)
            {
                MessageBox.Show("Najpierw wygeneruj kod QR!");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plik PNG|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                QR_bitmapa.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Zapisano kod QR do pliku.");
            }
        }

        private void button_drukuj_QR_Click(object sender, EventArgs e)
        {
            if (QR_bitmapa == null)
            {
                MessageBox.Show("Najpierw wygeneruj kod QR!");
                return;
            }
            PrintDialog pd = new PrintDialog();
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += (s, ev) =>
            {
                ev.Graphics.DrawImage(QR_bitmapa, 10, 10, 200, 200);
            };
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }

        private void button_zapis_db_Click(object sender, EventArgs e)
        {
            db.Zapisz_probki(listaProbek);
            MessageBox.Show("Zapisano do bazy danych.");
        }

        private void button_wczytaj_db_Click(object sender, EventArgs e)
        {
            listaProbek = db.Pobierz_probki();
            OdswiezWidok();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
