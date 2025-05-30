namespace lab10
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
            lista_sekwencji = new ListView();
            nazwa_sekwencji = new ColumnHeader();
            dlugosc_sekwencji = new ColumnHeader();
            button_wczytaj_fasta = new Button();
            button_zapis_CSV = new Button();
            button_zapis_JSON = new Button();
            label_GC = new Label();
            textBox_GC = new TextBox();
            label_liczba_kodonow = new Label();
            textBox_kodony = new TextBox();
            label_zasady = new Label();
            textBox_zasady = new TextBox();
            SuspendLayout();
            // 
            // lista_sekwencji
            // 
            lista_sekwencji.Columns.AddRange(new ColumnHeader[] { nazwa_sekwencji, dlugosc_sekwencji });
            lista_sekwencji.FullRowSelect = true;
            lista_sekwencji.Location = new Point(12, 12);
            lista_sekwencji.Name = "lista_sekwencji";
            lista_sekwencji.Size = new Size(304, 232);
            lista_sekwencji.TabIndex = 0;
            lista_sekwencji.UseCompatibleStateImageBehavior = false;
            lista_sekwencji.View = View.Details;
            lista_sekwencji.SelectedIndexChanged += lista_sekwencji_SelectedIndexChanged;
            // 
            // nazwa_sekwencji
            // 
            nazwa_sekwencji.Tag = "";
            nazwa_sekwencji.Text = "Nazwa Sekwencji";
            nazwa_sekwencji.Width = 200;
            // 
            // dlugosc_sekwencji
            // 
            dlugosc_sekwencji.Text = "Dlugość";
            dlugosc_sekwencji.Width = 100;
            // 
            // button_wczytaj_fasta
            // 
            button_wczytaj_fasta.Location = new Point(416, 398);
            button_wczytaj_fasta.Name = "button_wczytaj_fasta";
            button_wczytaj_fasta.Size = new Size(120, 40);
            button_wczytaj_fasta.TabIndex = 1;
            button_wczytaj_fasta.Text = "Wczytaj FASTA";
            button_wczytaj_fasta.UseVisualStyleBackColor = true;
            button_wczytaj_fasta.Click += button_wczytaj_fasta_Click;
            // 
            // button_zapis_CSV
            // 
            button_zapis_CSV.Location = new Point(542, 398);
            button_zapis_CSV.Name = "button_zapis_CSV";
            button_zapis_CSV.Size = new Size(120, 40);
            button_zapis_CSV.TabIndex = 2;
            button_zapis_CSV.Text = "Zapis do CSV";
            button_zapis_CSV.UseVisualStyleBackColor = true;
            button_zapis_CSV.Click += button_zapis_CSV_Click;
            // 
            // button_zapis_JSON
            // 
            button_zapis_JSON.Location = new Point(668, 398);
            button_zapis_JSON.Name = "button_zapis_JSON";
            button_zapis_JSON.Size = new Size(120, 40);
            button_zapis_JSON.TabIndex = 3;
            button_zapis_JSON.Text = "Zapis do JSON";
            button_zapis_JSON.UseVisualStyleBackColor = true;
            button_zapis_JSON.Click += button_zapis_JSON_Click;
            // 
            // label_GC
            // 
            label_GC.AutoSize = true;
            label_GC.Location = new Point(12, 262);
            label_GC.Name = "label_GC";
            label_GC.Size = new Size(83, 15);
            label_GC.TabIndex = 4;
            label_GC.Text = "Zawartość GC:";
            // 
            // textBox_GC
            // 
            textBox_GC.Location = new Point(122, 254);
            textBox_GC.Name = "textBox_GC";
            textBox_GC.ReadOnly = true;
            textBox_GC.Size = new Size(100, 23);
            textBox_GC.TabIndex = 5;
            textBox_GC.TextChanged += textBox_GC_TextChanged;
            // 
            // label_liczba_kodonow
            // 
            label_liczba_kodonow.AutoSize = true;
            label_liczba_kodonow.Location = new Point(12, 293);
            label_liczba_kodonow.Name = "label_liczba_kodonow";
            label_liczba_kodonow.Size = new Size(96, 15);
            label_liczba_kodonow.TabIndex = 6;
            label_liczba_kodonow.Text = "Liczba kodonów:";
            // 
            // textBox_kodony
            // 
            textBox_kodony.Location = new Point(122, 285);
            textBox_kodony.Name = "textBox_kodony";
            textBox_kodony.ReadOnly = true;
            textBox_kodony.Size = new Size(100, 23);
            textBox_kodony.TabIndex = 7;
            textBox_kodony.TextChanged += textBox_kodony_TextChanged;
            // 
            // label_zasady
            // 
            label_zasady.AutoSize = true;
            label_zasady.Location = new Point(12, 326);
            label_zasady.Name = "label_zasady";
            label_zasady.Size = new Size(75, 15);
            label_zasady.TabIndex = 8;
            label_zasady.Text = "Liczba zasad:";
            // 
            // textBox_zasady
            // 
            textBox_zasady.Location = new Point(122, 318);
            textBox_zasady.Name = "textBox_zasady";
            textBox_zasady.ReadOnly = true;
            textBox_zasady.Size = new Size(200, 23);
            textBox_zasady.TabIndex = 9;
            textBox_zasady.Text = "A:0  T:0  C:0  G:0";
            textBox_zasady.TextChanged += textBox_zasady_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_zasady);
            Controls.Add(label_zasady);
            Controls.Add(textBox_kodony);
            Controls.Add(label_liczba_kodonow);
            Controls.Add(textBox_GC);
            Controls.Add(label_GC);
            Controls.Add(button_zapis_JSON);
            Controls.Add(button_zapis_CSV);
            Controls.Add(button_wczytaj_fasta);
            Controls.Add(lista_sekwencji);
            Name = "Form1";
            Text = "Analizator FASTA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lista_sekwencji;
        private ColumnHeader nazwa_sekwencji;
        private ColumnHeader dlugosc_sekwencji;
        private Button button_wczytaj_fasta;
        private Button button_zapis_CSV;
        private Button button_zapis_JSON;
        private Label label_GC;
        private TextBox textBox_GC;
        private Label label_liczba_kodonow;
        private TextBox textBox_kodony;
        private Label label_zasady;
        private TextBox textBox_zasady;
    }
}
