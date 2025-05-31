using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form2 : Form
    {

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public Probki Sample { get; private set; }
        private bool czy_tryb_edycji;
        private List<string> istniejace_ID;
        private string orginalne_ID;
        public Form2(List<string> istniejace_ID)
        {
            InitializeComponent();
            czy_tryb_edycji = false;
            this.istniejace_ID = istniejace_ID;
            UstawComboBox();
        }

        public Form2(Probki sample, List<string> istniejace_ID) : this(istniejace_ID)
        {
            czy_tryb_edycji = true;
            Sample = sample;
            orginalne_ID = sample.SampleId;
            WypelnijPola();
        }

        private void UstawComboBox()
        {
            comboBox_typ.Items.Clear();
            comboBox_typ.Items.AddRange(new string[] { "DNA", "RNA", "Białko", "Inny" });
            comboBox_typ.SelectedIndex = 0;
        }

        private void WypelnijPola()
        {
            if (Sample == null) return;
            textBox_id.Text = Sample.SampleId;
            textBox_nazwa.Text = Sample.Name;
            comboBox_typ.SelectedItem = TypEnumNaString(Sample.Type);
            dateTimePicker_probka.Value = Sample.CollectionDate;
            textBox_opis.Text = Sample.Description;
        }
        private string TypEnumNaString(SampleType typ)
        {
            switch (typ)
            {
                case SampleType.DNA: return "DNA";
                case SampleType.RNA: return "RNA";
                case SampleType.Protein: return "Białko";
                case SampleType.Other: return "Inny";
                default: return "Inny";
            }
        }

        private SampleType StringNaEnum(string typ)
        {
            switch (typ)
            {
                case "DNA": return SampleType.DNA;
                case "RNA": return SampleType.RNA;
                case "Białko": return SampleType.Protein;
                case "Inny": return SampleType.Other;
                default: return SampleType.Other;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_nazwa_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_typ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_opis_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_zapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text) ||
                string.IsNullOrWhiteSpace(textBox_nazwa.Text))
            {
                MessageBox.Show("Uzupełnij wymagane pola!");
                return;
            }

            string wpisaneId = textBox_id.Text.Trim();
            if ((!czy_tryb_edycji && istniejace_ID.Contains(wpisaneId)) ||
                (czy_tryb_edycji && wpisaneId != orginalne_ID && istniejace_ID.Contains(wpisaneId)))
            {
                MessageBox.Show("ID próbki musi być unikalne!");
                return;
            }

            if (Sample == null)
                Sample = new Probki();

            Sample.SampleId = wpisaneId;
            Sample.Name = textBox_nazwa.Text.Trim();
            Sample.Type = StringNaEnum(comboBox_typ.SelectedItem.ToString());
            Sample.CollectionDate = dateTimePicker_probka.Value.Date;
            Sample.Description = textBox_opis.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_anuluj_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dateTimePicker_probka_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
