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
            label_plansza.Location = new Point(109, 10);
            label_plansza.Margin = new Padding(2, 0, 2, 0);
            label_plansza.Name = "label_plansza";
            label_plansza.Size = new Size(46, 15);
            label_plansza.TabIndex = 0;
            label_plansza.Text = "Plansza";
            // 
            // label_x
            // 
            label_x.AutoSize = true;
            label_x.Location = new Point(66, 35);
            label_x.Margin = new Padding(2, 0, 2, 0);
            label_x.Name = "label_x";
            label_x.Size = new Size(17, 15);
            label_x.TabIndex = 1;
            label_x.Text = "X:";
            // 
            // label_y
            // 
            label_y.AutoSize = true;
            label_y.Location = new Point(66, 67);
            label_y.Margin = new Padding(2, 0, 2, 0);
            label_y.Name = "label_y";
            label_y.Size = new Size(17, 15);
            label_y.TabIndex = 2;
            label_y.Text = "Y:";
            // 
            // textBox_x
            // 
            textBox_x.Location = new Point(100, 32);
            textBox_x.Margin = new Padding(2);
            textBox_x.Name = "textBox_x";
            textBox_x.Size = new Size(71, 23);
            textBox_x.TabIndex = 3;
            textBox_x.TextAlign = HorizontalAlignment.Center;
            textBox_x.Leave += textBox_x_TextChanged;
            // 
            // textBox_y
            // 
            textBox_y.Location = new Point(100, 64);
            textBox_y.Margin = new Padding(2);
            textBox_y.Name = "textBox_y";
            textBox_y.Size = new Size(71, 23);
            textBox_y.TabIndex = 4;
            textBox_y.TextAlign = HorizontalAlignment.Center;
            textBox_y.Leave += textBox_y_TextChanged;
            // 
            // label_dydelf
            // 
            label_dydelf.AutoSize = true;
            label_dydelf.Location = new Point(109, 92);
            label_dydelf.Margin = new Padding(2, 0, 2, 0);
            label_dydelf.Name = "label_dydelf";
            label_dydelf.Size = new Size(47, 15);
            label_dydelf.TabIndex = 5;
            label_dydelf.Text = "Dydelfy";
            // 
            // textBox_dydelfy
            // 
            textBox_dydelfy.Location = new Point(100, 109);
            textBox_dydelfy.Margin = new Padding(2);
            textBox_dydelfy.Name = "textBox_dydelfy";
            textBox_dydelfy.Size = new Size(71, 23);
            textBox_dydelfy.TabIndex = 6;
            textBox_dydelfy.TextAlign = HorizontalAlignment.Center;
            textBox_dydelfy.TextChanged += textBox_dydelfy_TextChanged;
            textBox_dydelfy.Leave += textBox_dydelfy_TextChanged;
            // 
            // label_krokodyle
            // 
            label_krokodyle.AutoSize = true;
            label_krokodyle.Location = new Point(106, 135);
            label_krokodyle.Margin = new Padding(2, 0, 2, 0);
            label_krokodyle.Name = "label_krokodyle";
            label_krokodyle.Size = new Size(60, 15);
            label_krokodyle.TabIndex = 7;
            label_krokodyle.Text = "Krokodyle";
            // 
            // textBox_krokodyle
            // 
            textBox_krokodyle.Location = new Point(100, 152);
            textBox_krokodyle.Margin = new Padding(2);
            textBox_krokodyle.Name = "textBox_krokodyle";
            textBox_krokodyle.Size = new Size(71, 23);
            textBox_krokodyle.TabIndex = 8;
            textBox_krokodyle.TextAlign = HorizontalAlignment.Center;
            textBox_krokodyle.Leave += textBox_krokodyle_TextChanged;
            // 
            // label_czas
            // 
            label_czas.AutoSize = true;
            label_czas.Location = new Point(111, 229);
            label_czas.Margin = new Padding(2, 0, 2, 0);
            label_czas.Name = "label_czas";
            label_czas.Size = new Size(47, 15);
            label_czas.TabIndex = 9;
            label_czas.Text = "Czas [s]";
            // 
            // textBox_czas
            // 
            textBox_czas.Location = new Point(100, 246);
            textBox_czas.Margin = new Padding(2);
            textBox_czas.Name = "textBox_czas";
            textBox_czas.Size = new Size(71, 23);
            textBox_czas.TabIndex = 10;
            textBox_czas.TextAlign = HorizontalAlignment.Center;
            textBox_czas.Leave += textBox_czas_TextChanged;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(17, 284);
            button_ok.Margin = new Padding(2);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(105, 26);
            button_ok.TabIndex = 11;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(153, 284);
            button_anuluj.Margin = new Padding(2);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(105, 26);
            button_anuluj.TabIndex = 12;
            button_anuluj.Text = "ANULUJ";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // label_szop
            // 
            label_szop.AutoSize = true;
            label_szop.Location = new Point(116, 180);
            label_szop.Margin = new Padding(2, 0, 2, 0);
            label_szop.Name = "label_szop";
            label_szop.Size = new Size(38, 15);
            label_szop.TabIndex = 13;
            label_szop.Text = "Szopy";
            // 
            // textBox_szopy
            // 
            textBox_szopy.Location = new Point(100, 202);
            textBox_szopy.Margin = new Padding(2);
            textBox_szopy.Name = "textBox_szopy";
            textBox_szopy.Size = new Size(71, 23);
            textBox_szopy.TabIndex = 14;
            textBox_szopy.TextAlign = HorizontalAlignment.Center;
            textBox_szopy.TextChanged += textBox_szopy_TextChanged;
            textBox_szopy.Leave += textBox_szopy_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 340);
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
            Margin = new Padding(2);
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