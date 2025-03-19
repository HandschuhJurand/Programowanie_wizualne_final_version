namespace Lab2
{
    partial class Komputer
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
            Procesor = new Label();
            Cena_procesora = new TextBox();
            zl = new Label();
            wybor_procesora = new ComboBox();
            Dysk = new Label();
            cena_dysku = new TextBox();
            label2 = new Label();
            radioButton_d1 = new RadioButton();
            radioButton_d2 = new RadioButton();
            radioButton_d3 = new RadioButton();
            suma = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button_ok = new Button();
            button_anuluj = new Button();
            SuspendLayout();
            // 
            // Procesor
            // 
            Procesor.AutoSize = true;
            Procesor.Location = new Point(64, 47);
            Procesor.Name = "Procesor";
            Procesor.Size = new Size(53, 15);
            Procesor.TabIndex = 0;
            Procesor.Text = "Procesor";
            // 
            // Cena_procesora
            // 
            Cena_procesora.Location = new Point(132, 44);
            Cena_procesora.Name = "Cena_procesora";
            Cena_procesora.ReadOnly = true;
            Cena_procesora.Size = new Size(100, 23);
            Cena_procesora.TabIndex = 1;
            Cena_procesora.TextChanged += Cena_procesora_TextChanged;
            // 
            // zl
            // 
            zl.AutoSize = true;
            zl.Location = new Point(251, 46);
            zl.Name = "zl";
            zl.Size = new Size(15, 15);
            zl.TabIndex = 2;
            zl.Text = "zł";
            // 
            // wybor_procesora
            // 
            wybor_procesora.FormattingEnabled = true;
            wybor_procesora.Location = new Point(64, 80);
            wybor_procesora.Name = "wybor_procesora";
            wybor_procesora.Size = new Size(225, 23);
            wybor_procesora.TabIndex = 3;
            wybor_procesora.SelectedIndexChanged += wybor_procesora_SelectedIndexChanged;
            // 
            // Dysk
            // 
            Dysk.AutoSize = true;
            Dysk.Location = new Point(64, 121);
            Dysk.Name = "Dysk";
            Dysk.Size = new Size(32, 15);
            Dysk.TabIndex = 4;
            Dysk.Text = "Dysk";
            // 
            // cena_dysku
            // 
            cena_dysku.Location = new Point(132, 115);
            cena_dysku.Name = "cena_dysku";
            cena_dysku.ReadOnly = true;
            cena_dysku.Size = new Size(100, 23);
            cena_dysku.TabIndex = 5;
            cena_dysku.TextChanged += cena_dysku_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 121);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 6;
            label2.Text = "zł";
            // 
            // radioButton_d1
            // 
            radioButton_d1.AutoSize = true;
            radioButton_d1.Location = new Point(132, 158);
            radioButton_d1.Name = "radioButton_d1";
            radioButton_d1.Size = new Size(84, 19);
            radioButton_d1.TabIndex = 7;
            radioButton_d1.TabStop = true;
            radioButton_d1.Text = "240 GB SSD";
            radioButton_d1.UseVisualStyleBackColor = true;
            radioButton_d1.CheckedChanged += radioButton_d1_CheckedChanged;
            // 
            // radioButton_d2
            // 
            radioButton_d2.AutoSize = true;
            radioButton_d2.Location = new Point(132, 183);
            radioButton_d2.Name = "radioButton_d2";
            radioButton_d2.Size = new Size(90, 19);
            radioButton_d2.TabIndex = 8;
            radioButton_d2.TabStop = true;
            radioButton_d2.Text = "500 GB SATA";
            radioButton_d2.UseVisualStyleBackColor = true;
            radioButton_d2.CheckedChanged += radioButton_d2_CheckedChanged;
            // 
            // radioButton_d3
            // 
            radioButton_d3.AutoSize = true;
            radioButton_d3.Location = new Point(132, 208);
            radioButton_d3.Name = "radioButton_d3";
            radioButton_d3.Size = new Size(87, 19);
            radioButton_d3.TabIndex = 9;
            radioButton_d3.TabStop = true;
            radioButton_d3.Text = "1000 GB M2";
            radioButton_d3.UseVisualStyleBackColor = true;
            radioButton_d3.CheckedChanged += radioButton_d3_CheckedChanged;
            // 
            // suma
            // 
            suma.AutoSize = true;
            suma.Location = new Point(64, 262);
            suma.Name = "suma";
            suma.Size = new Size(37, 15);
            suma.TabIndex = 10;
            suma.Text = "Suma";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 259);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 262);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 12;
            label3.Text = "zł";
            // 
            // button_ok
            // 
            button_ok.Location = new Point(64, 378);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 13;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(214, 378);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(75, 23);
            button_anuluj.TabIndex = 14;
            button_anuluj.Text = "ANULUJ";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // Komputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 450);
            Controls.Add(button_anuluj);
            Controls.Add(button_ok);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(suma);
            Controls.Add(radioButton_d3);
            Controls.Add(radioButton_d2);
            Controls.Add(radioButton_d1);
            Controls.Add(label2);
            Controls.Add(cena_dysku);
            Controls.Add(Dysk);
            Controls.Add(wybor_procesora);
            Controls.Add(zl);
            Controls.Add(Cena_procesora);
            Controls.Add(Procesor);
            Name = "Komputer";
            Text = "Komputer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Procesor;
        private TextBox Cena_procesora;
        private Label zl;
        private ComboBox wybor_procesora;
        private Label Dysk;
        private TextBox cena_dysku;
        private Label label2;
        private RadioButton radioButton_d1;
        private RadioButton radioButton_d2;
        private RadioButton radioButton_d3;
        private Label suma;
        private TextBox textBox2;
        private Label label3;
        private Button button_ok;
        private Button button_anuluj;
    }
}