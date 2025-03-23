namespace Lab3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            podaj_imie = new TextBox();
            podaj_nazwisko = new TextBox();
            podaj_wiek = new TextBox();
            button_zatwierdz = new Button();
            button_anuluj = new Button();
            Imie = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // podaj_imie
            // 
            podaj_imie.Location = new Point(36, 26);
            podaj_imie.Margin = new Padding(2);
            podaj_imie.Name = "podaj_imie";
            podaj_imie.Size = new Size(129, 23);
            podaj_imie.TabIndex = 0;
            podaj_imie.TextChanged += podaj_imie_TextChanged;
            // 
            // podaj_nazwisko
            // 
            podaj_nazwisko.Location = new Point(36, 57);
            podaj_nazwisko.Margin = new Padding(2);
            podaj_nazwisko.Name = "podaj_nazwisko";
            podaj_nazwisko.Size = new Size(129, 23);
            podaj_nazwisko.TabIndex = 1;
            podaj_nazwisko.TextChanged += podaj_nazwisko_TextChanged;
            // 
            // podaj_wiek
            // 
            podaj_wiek.Location = new Point(36, 91);
            podaj_wiek.Margin = new Padding(2);
            podaj_wiek.MaxLength = 3;
            podaj_wiek.Name = "podaj_wiek";
            podaj_wiek.Size = new Size(129, 23);
            podaj_wiek.TabIndex = 2;
            podaj_wiek.TextChanged += podaj_wiek_TextChanged;
            // 
            // button_zatwierdz
            // 
            button_zatwierdz.Location = new Point(36, 187);
            button_zatwierdz.Margin = new Padding(2);
            button_zatwierdz.Name = "button_zatwierdz";
            button_zatwierdz.Size = new Size(78, 25);
            button_zatwierdz.TabIndex = 3;
            button_zatwierdz.Text = "Zatwierdź";
            button_zatwierdz.UseVisualStyleBackColor = true;
            button_zatwierdz.Click += button_zatwierdz_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(173, 187);
            button_anuluj.Margin = new Padding(2);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(78, 25);
            button_anuluj.TabIndex = 4;
            button_anuluj.Text = "Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // Imie
            // 
            Imie.AutoSize = true;
            Imie.Location = new Point(197, 29);
            Imie.Margin = new Padding(2, 0, 2, 0);
            Imie.Name = "Imie";
            Imie.Size = new Size(30, 15);
            Imie.TabIndex = 5;
            Imie.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Stanowisko";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 126);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 257);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Imie);
            Controls.Add(button_anuluj);
            Controls.Add(button_zatwierdz);
            Controls.Add(podaj_wiek);
            Controls.Add(podaj_nazwisko);
            Controls.Add(podaj_imie);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Dodaj pracownika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox podaj_imie;
        private TextBox podaj_nazwisko;
        private TextBox podaj_wiek;
        private Button button_zatwierdz;
        private Button button_anuluj;
        private Label Imie;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}