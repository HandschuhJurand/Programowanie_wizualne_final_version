namespace lab6
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
            label_plansza = new Label();
            label_x = new Label();
            label_y = new Label();
            textBox_x = new TextBox();
            textBox_y = new TextBox();
            label_dydelf = new Label();
            textBox_dydelfy = new TextBox();
            label_krokodyle = new Label();
            textBox_krokodyle = new TextBox();
            label_czas = new Label();
            textBox_czas = new TextBox();
            button_ok = new Button();
            button_anuluj = new Button();
            label_szop = new Label();
            textBox_szopy = new TextBox();
            SuspendLayout();
            // 
            // label_plansza
            // 
            label_plansza.AutoSize = true;
            label_plansza.Location = new Point(156, 16);
            label_plansza.Name = "label_plansza";
            label_plansza.Size = new Size(70, 25);
            label_plansza.TabIndex = 0;
            label_plansza.Text = "Plansza";
            // 
            // label_x
            // 
            label_x.AutoSize = true;
            label_x.Location = new Point(95, 59);
            label_x.Name = "label_x";
            label_x.Size = new Size(27, 25);
            label_x.TabIndex = 1;
            label_x.Text = "X:";
            // 
            // label_y
            // 
            label_y.AutoSize = true;
            label_y.Location = new Point(95, 112);
            label_y.Name = "label_y";
            label_y.Size = new Size(26, 25);
            label_y.TabIndex = 2;
            label_y.Text = "Y:";
            // 
            // textBox_x
            // 
            textBox_x.Location = new Point(143, 53);
            textBox_x.Name = "textBox_x";
            textBox_x.Size = new Size(100, 31);
            textBox_x.TabIndex = 3;
            textBox_x.TextAlign = HorizontalAlignment.Center;
            textBox_x.Leave += textBox_x_TextChanged;
            // 
            // textBox_y
            // 
            textBox_y.Location = new Point(143, 106);
            textBox_y.Name = "textBox_y";
            textBox_y.Size = new Size(100, 31);
            textBox_y.TabIndex = 4;
            textBox_y.TextAlign = HorizontalAlignment.Center;
            textBox_y.Leave += textBox_y_TextChanged;
            // 
            // label_dydelf
            // 
            label_dydelf.AutoSize = true;
            label_dydelf.Location = new Point(156, 153);
            label_dydelf.Name = "label_dydelf";
            label_dydelf.Size = new Size(73, 25);
            label_dydelf.TabIndex = 5;
            label_dydelf.Text = "Dydelfy";
            // 
            // textBox_dydelfy
            // 
            textBox_dydelfy.Location = new Point(143, 181);
            textBox_dydelfy.Name = "textBox_dydelfy";
            textBox_dydelfy.Size = new Size(100, 31);
            textBox_dydelfy.TabIndex = 6;
            textBox_dydelfy.TextAlign = HorizontalAlignment.Center;
            textBox_dydelfy.TextChanged += textBox_dydelfy_TextChanged;
            textBox_dydelfy.Leave += textBox_dydelfy_TextChanged;
            // 
            // label_krokodyle
            // 
            label_krokodyle.AutoSize = true;
            label_krokodyle.Location = new Point(151, 225);
            label_krokodyle.Name = "label_krokodyle";
            label_krokodyle.Size = new Size(92, 25);
            label_krokodyle.TabIndex = 7;
            label_krokodyle.Text = "Krokodyle";
            // 
            // textBox_krokodyle
            // 
            textBox_krokodyle.Location = new Point(143, 253);
            textBox_krokodyle.Name = "textBox_krokodyle";
            textBox_krokodyle.Size = new Size(100, 31);
            textBox_krokodyle.TabIndex = 8;
            textBox_krokodyle.TextAlign = HorizontalAlignment.Center;
            textBox_krokodyle.TextChanged += textBox_krokodyle_TextChanged;
            textBox_krokodyle.Leave += textBox_krokodyle_TextChanged;
            // 
            // label_czas
            // 
            label_czas.AutoSize = true;
            label_czas.Location = new Point(158, 382);
            label_czas.Name = "label_czas";
            label_czas.Size = new Size(71, 25);
            label_czas.TabIndex = 9;
            label_czas.Text = "Czas [s]";
            // 
            // textBox_czas
            // 
            textBox_czas.Location = new Point(143, 410);
            textBox_czas.Name = "textBox_czas";
            textBox_czas.Size = new Size(100, 31);
            textBox_czas.TabIndex = 10;
            textBox_czas.TextAlign = HorizontalAlignment.Center;
            textBox_czas.TextChanged += textBox_czas_TextChanged;
            textBox_czas.Leave += textBox_czas_TextChanged;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(24, 474);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(150, 44);
            button_ok.TabIndex = 11;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(218, 474);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(150, 44);
            button_anuluj.TabIndex = 12;
            button_anuluj.Text = "ANULUJ";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // label_szop
            // 
            label_szop.AutoSize = true;
            label_szop.Location = new Point(166, 300);
            label_szop.Name = "label_szop";
            label_szop.Size = new Size(60, 25);
            label_szop.TabIndex = 13;
            label_szop.Text = "Szopy";
            // 
            // textBox_szopy
            // 
            textBox_szopy.Location = new Point(143, 337);
            textBox_szopy.Name = "textBox_szopy";
            textBox_szopy.Size = new Size(100, 31);
            textBox_szopy.TabIndex = 14;
            textBox_szopy.TextAlign = HorizontalAlignment.Center;
            textBox_szopy.TextChanged += textBox_szopy_TextChanged;
            textBox_szopy.Leave += textBox_szopy_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 567);
            Controls.Add(textBox_szopy);
            Controls.Add(label_szop);
            Controls.Add(button_anuluj);
            Controls.Add(button_ok);
            Controls.Add(textBox_czas);
            Controls.Add(label_czas);
            Controls.Add(textBox_krokodyle);
            Controls.Add(label_krokodyle);
            Controls.Add(textBox_dydelfy);
            Controls.Add(label_dydelf);
            Controls.Add(textBox_y);
            Controls.Add(textBox_x);
            Controls.Add(label_y);
            Controls.Add(label_x);
            Controls.Add(label_plansza);
            Name = "Form2";
            Text = "Ustawienia";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_plansza;
        private Label label_x;
        private Label label_y;
        private TextBox textBox_x;
        private TextBox textBox_y;
        private Label label_dydelf;
        private TextBox textBox_dydelfy;
        private Label label_krokodyle;
        private TextBox textBox_krokodyle;
        private Label label_czas;
        private TextBox textBox_czas;
        private Button button_ok;
        private Button button_anuluj;
        private Label label_szop;
        private TextBox textBox_szopy;
    }
}