namespace lab11
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
            label1 = new Label();
            textBox_id = new TextBox();
            label2 = new Label();
            textBox_nazwa = new TextBox();
            label3 = new Label();
            comboBox_typ = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox_opis = new TextBox();
            button_zapisz = new Button();
            button_anuluj = new Button();
            dateTimePicker_probka = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "ID próbki";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(127, 31);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(100, 23);
            textBox_id.TabIndex = 1;
            textBox_id.KeyPress += textBox_id_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 67);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Nazwa próbki";
            // 
            // textBox_nazwa
            // 
            textBox_nazwa.Location = new Point(127, 85);
            textBox_nazwa.Name = "textBox_nazwa";
            textBox_nazwa.Size = new Size(100, 23);
            textBox_nazwa.TabIndex = 3;
            textBox_nazwa.TextChanged += textBox_nazwa_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 121);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Typ próbki";
            // 
            // comboBox_typ
            // 
            comboBox_typ.FormattingEnabled = true;
            comboBox_typ.Location = new Point(114, 139);
            comboBox_typ.Name = "comboBox_typ";
            comboBox_typ.Size = new Size(130, 23);
            comboBox_typ.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 176);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Data pobrania";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(161, 234);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Opis";
            // 
            // textBox_opis
            // 
            textBox_opis.Location = new Point(75, 252);
            textBox_opis.Multiline = true;
            textBox_opis.Name = "textBox_opis";
            textBox_opis.Size = new Size(200, 64);
            textBox_opis.TabIndex = 9;
            // 
            // button_zapisz
            // 
            button_zapisz.Location = new Point(31, 349);
            button_zapisz.Name = "button_zapisz";
            button_zapisz.Size = new Size(100, 40);
            button_zapisz.TabIndex = 10;
            button_zapisz.Text = "Zapisz";
            button_zapisz.UseVisualStyleBackColor = true;
            button_zapisz.Click += button_zapisz_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(218, 349);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(100, 40);
            button_anuluj.TabIndex = 11;
            button_anuluj.Text = "Anuluj";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // dateTimePicker_probka
            // 
            dateTimePicker_probka.Location = new Point(75, 208);
            dateTimePicker_probka.Name = "dateTimePicker_probka";
            dateTimePicker_probka.Size = new Size(200, 23);
            dateTimePicker_probka.TabIndex = 12;
            dateTimePicker_probka.ValueChanged += dateTimePicker_probka_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 450);
            Controls.Add(dateTimePicker_probka);
            Controls.Add(button_anuluj);
            Controls.Add(button_zapisz);
            Controls.Add(textBox_opis);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox_typ);
            Controls.Add(label3);
            Controls.Add(textBox_nazwa);
            Controls.Add(label2);
            Controls.Add(textBox_id);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Dodawanie/edytowanie próbek";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_id;
        private Label label2;
        private TextBox textBox_nazwa;
        private Label label3;
        private ComboBox comboBox_typ;
        private Label label4;
        private Label label5;
        private TextBox textBox_opis;
        private Button button_zapisz;
        private Button button_anuluj;
        private DateTimePicker dateTimePicker_probka;
    }
}