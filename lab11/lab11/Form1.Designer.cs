namespace lab11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_wyszukaj = new TextBox();
            comboBox_filtowanie = new ComboBox();
            button_wyszukaj = new Button();
            label1 = new Label();
            dataGridView_probki = new DataGridView();
            button_dodaj_probke = new Button();
            button_edytuj_probke = new Button();
            button_generacja_QR = new Button();
            button_eksport_QR = new Button();
            button_drukuj_QR = new Button();
            button_zapis_db = new Button();
            button_wczytaj_db = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_probki).BeginInit();
            SuspendLayout();
            // 
            // textBox_wyszukaj
            // 
            textBox_wyszukaj.Location = new Point(579, 12);
            textBox_wyszukaj.Name = "textBox_wyszukaj";
            textBox_wyszukaj.PlaceholderText = "Wyszukaj próbkę...";
            textBox_wyszukaj.Size = new Size(121, 23);
            textBox_wyszukaj.TabIndex = 0;
            textBox_wyszukaj.TextChanged += textBox_wyszukaj_TextChanged;
            // 
            // comboBox_filtowanie
            // 
            comboBox_filtowanie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_filtowanie.FormattingEnabled = true;
            comboBox_filtowanie.Location = new Point(579, 79);
            comboBox_filtowanie.Name = "comboBox_filtowanie";
            comboBox_filtowanie.Size = new Size(121, 23);
            comboBox_filtowanie.TabIndex = 1;
            comboBox_filtowanie.SelectedIndexChanged += comboBox_filtowanie_SelectedIndexChanged;
            // 
            // button_wyszukaj
            // 
            button_wyszukaj.Location = new Point(579, 108);
            button_wyszukaj.Name = "button_wyszukaj";
            button_wyszukaj.Size = new Size(120, 40);
            button_wyszukaj.TabIndex = 2;
            button_wyszukaj.Text = "Wyszukaj";
            button_wyszukaj.UseVisualStyleBackColor = true;
            button_wyszukaj.Click += button_wyszukaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 61);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 3;
            label1.Text = "Filtrowanie:";
            // 
            // dataGridView_probki
            // 
            dataGridView_probki.AllowUserToAddRows = false;
            dataGridView_probki.AllowUserToDeleteRows = false;
            dataGridView_probki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_probki.Location = new Point(12, 12);
            dataGridView_probki.MultiSelect = false;
            dataGridView_probki.Name = "dataGridView_probki";
            dataGridView_probki.ReadOnly = true;
            dataGridView_probki.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_probki.Size = new Size(544, 250);
            dataGridView_probki.TabIndex = 4;
            dataGridView_probki.CellContentClick += dataGridView_probki_CellContentClick;
            // 
            // button_dodaj_probke
            // 
            button_dodaj_probke.Location = new Point(12, 280);
            button_dodaj_probke.Name = "button_dodaj_probke";
            button_dodaj_probke.Size = new Size(100, 40);
            button_dodaj_probke.TabIndex = 5;
            button_dodaj_probke.Text = "Dodaj próbkę";
            button_dodaj_probke.UseVisualStyleBackColor = true;
            button_dodaj_probke.Click += button_dodaj_probke_Click;
            // 
            // button_edytuj_probke
            // 
            button_edytuj_probke.Location = new Point(118, 280);
            button_edytuj_probke.Name = "button_edytuj_probke";
            button_edytuj_probke.Size = new Size(100, 40);
            button_edytuj_probke.TabIndex = 6;
            button_edytuj_probke.Text = "Edytuj próbkę";
            button_edytuj_probke.UseVisualStyleBackColor = true;
            button_edytuj_probke.Click += button_edytuj_probke_Click;
            // 
            // button_generacja_QR
            // 
            button_generacja_QR.Location = new Point(224, 280);
            button_generacja_QR.Name = "button_generacja_QR";
            button_generacja_QR.Size = new Size(100, 40);
            button_generacja_QR.TabIndex = 7;
            button_generacja_QR.Text = "Generuj kod QR";
            button_generacja_QR.UseVisualStyleBackColor = true;
            button_generacja_QR.Click += button_generacja_QR_Click;
            // 
            // button_eksport_QR
            // 
            button_eksport_QR.Location = new Point(330, 280);
            button_eksport_QR.Name = "button_eksport_QR";
            button_eksport_QR.Size = new Size(100, 40);
            button_eksport_QR.TabIndex = 8;
            button_eksport_QR.Text = "Eksportuj QR do PNG";
            button_eksport_QR.UseVisualStyleBackColor = true;
            button_eksport_QR.Click += button_eksport_QR_Click;
            // 
            // button_drukuj_QR
            // 
            button_drukuj_QR.Location = new Point(436, 280);
            button_drukuj_QR.Name = "button_drukuj_QR";
            button_drukuj_QR.Size = new Size(100, 40);
            button_drukuj_QR.TabIndex = 9;
            button_drukuj_QR.Text = "Drukuj QR";
            button_drukuj_QR.UseVisualStyleBackColor = true;
            button_drukuj_QR.Click += button_drukuj_QR_Click;
            // 
            // button_zapis_db
            // 
            button_zapis_db.Location = new Point(12, 339);
            button_zapis_db.Name = "button_zapis_db";
            button_zapis_db.Size = new Size(100, 40);
            button_zapis_db.TabIndex = 10;
            button_zapis_db.Text = "Zapis do bazy danych";
            button_zapis_db.UseVisualStyleBackColor = true;
            button_zapis_db.Click += button_zapis_db_Click;
            // 
            // button_wczytaj_db
            // 
            button_wczytaj_db.Location = new Point(118, 339);
            button_wczytaj_db.Name = "button_wczytaj_db";
            button_wczytaj_db.Size = new Size(100, 40);
            button_wczytaj_db.TabIndex = 11;
            button_wczytaj_db.Text = "Wczytaj z bazy danych";
            button_wczytaj_db.UseVisualStyleBackColor = true;
            button_wczytaj_db.Click += button_wczytaj_db_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(button_wczytaj_db);
            Controls.Add(button_zapis_db);
            Controls.Add(button_drukuj_QR);
            Controls.Add(button_eksport_QR);
            Controls.Add(button_generacja_QR);
            Controls.Add(button_edytuj_probke);
            Controls.Add(button_dodaj_probke);
            Controls.Add(dataGridView_probki);
            Controls.Add(label1);
            Controls.Add(button_wyszukaj);
            Controls.Add(comboBox_filtowanie);
            Controls.Add(textBox_wyszukaj);
            Name = "Form1";
            Text = "Menedżer próbek biologicznych";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_probki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_wyszukaj;
        private ComboBox comboBox_filtowanie;
        private Button button_wyszukaj;
        private Label label1;
        private DataGridView dataGridView_probki;
        private Button button_dodaj_probke;
        private Button button_edytuj_probke;
        private Button button_generacja_QR;
        private Button button_eksport_QR;
        private Button button_drukuj_QR;
        private Button button_zapis_db;
        private Button button_wczytaj_db;
    }
}
