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
    public partial class Form3 : Form
    {
        private Form1 ParentForm;
        private decimal cena = 0;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.ParentForm = form1;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Nazwa", 150);
            listView1.Columns.Add("Cena");

            ListViewItem[] items = new ListViewItem[]
            {
                new ListViewItem(new string[] { "Monitor 24\" Full HD", "799" }),
                new ListViewItem(new string[] { "Monitor 27\" 2K", "999" }),
                new ListViewItem(new string[] { "Monitor 32\" 4K", "1999" })
            };
            listView1.Items.AddRange(items);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string wybrany_monitor = listView1.SelectedItems[0].SubItems[0].Text;
                cena = decimal.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                textBox_monitor.Text = cena.ToString();
            }
        }

        private void textBox_monitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            ParentForm.cena_monitora = cena;
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
