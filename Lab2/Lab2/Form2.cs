using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Komputer : Form
    {
        private Form1 ParentForm;
        private decimal proc_cena = 0;
        private decimal dysk_cena = 0;
        public Komputer(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;
            wybor_procesora.Items.AddRange(new string[] {"Intel Core i9-14900K", "Intel Core i7-14700K", "AMD Ryzen 9 5900X", "AMD Ryzen 7 7800X3D"});

            wybor_procesora.Text = "...";
        }

        private void Aktualizacja_cen()
        {
            textBox2.Text = (proc_cena + dysk_cena).ToString();
        }

        private void Cena_procesora_TextChanged(object sender, EventArgs e)
        {

        }

        private void wybor_procesora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wybor_procesora.SelectedItem != null)
            {
                string wybrany_proc = wybor_procesora.SelectedItem.ToString();

                switch (wybrany_proc)
                {
                    case "Intel Core i9-14900K":
                        proc_cena = 2399;
                        break;
                    case "Intel Core i7-14700K":
                        proc_cena = 1899;
                        break;
                    case "AMD Ryzen 9 5900X":
                        proc_cena = 1699;
                        break;
                    case "AMD Ryzen 7 7800X3D":
                        proc_cena = 2099;
                        break;
                }
                Cena_procesora.Text = proc_cena.ToString();
                Aktualizacja_cen();
            }
        }

        private void cena_dysku_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_d1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_d1.Checked)
            {
                dysk_cena = 129;
                cena_dysku.Text = dysk_cena.ToString();
                Aktualizacja_cen();
            }
        }

        private void radioButton_d2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_d2.Checked)
            {
                dysk_cena = 259;
                cena_dysku.Text = dysk_cena.ToString();
                Aktualizacja_cen();
            }
        }

        private void radioButton_d3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_d3.Checked)
            {
                dysk_cena = 499;
                cena_dysku.Text = dysk_cena.ToString();
                Aktualizacja_cen();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            ParentForm.cena_komputera = proc_cena + dysk_cena;
            ParentForm.Aktualizacja_cen();
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
