namespace lab6
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
            tytul = new Label();
            button_start = new Button();
            button_ustawienia = new Button();
            button_koniec = new Button();
            SuspendLayout();
            // 
            // tytul
            // 
            tytul.AutoSize = true;
            tytul.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            tytul.Location = new Point(44, 46);
            tytul.Name = "tytul";
            tytul.Size = new Size(293, 41);
            tytul.TabIndex = 0;
            tytul.Text = "GDZIE JEST DYDELF";
            // 
            // button_start
            // 
            button_start.Location = new Point(91, 158);
            button_start.Name = "button_start";
            button_start.Size = new Size(200, 60);
            button_start.TabIndex = 1;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // button_ustawienia
            // 
            button_ustawienia.Location = new Point(91, 249);
            button_ustawienia.Name = "button_ustawienia";
            button_ustawienia.Size = new Size(200, 60);
            button_ustawienia.TabIndex = 2;
            button_ustawienia.Text = "USTAWIENIA";
            button_ustawienia.UseVisualStyleBackColor = true;
            button_ustawienia.Click += button_ustawienia_Click;
            // 
            // button_koniec
            // 
            button_koniec.Location = new Point(91, 339);
            button_koniec.Name = "button_koniec";
            button_koniec.Size = new Size(200, 60);
            button_koniec.TabIndex = 3;
            button_koniec.Text = "KONIEC";
            button_koniec.UseVisualStyleBackColor = true;
            button_koniec.Click += button_koniec_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 450);
            Controls.Add(button_koniec);
            Controls.Add(button_ustawienia);
            Controls.Add(button_start);
            Controls.Add(tytul);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tytul;
        private Button button_start;
        private Button button_ustawienia;
        private Button button_koniec;
    }
}
