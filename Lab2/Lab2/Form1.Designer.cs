namespace Lab2
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
            textBox_cena_zestawu = new TextBox();
            button_komputer = new Button();
            button_monitor = new Button();
            label_cena_zestawu = new Label();
            SuspendLayout();
            // 
            // textBox_cena_zestawu
            // 
            textBox_cena_zestawu.Location = new Point(263, 75);
            textBox_cena_zestawu.Name = "textBox_cena_zestawu";
            textBox_cena_zestawu.ReadOnly = true;
            textBox_cena_zestawu.Size = new Size(100, 23);
            textBox_cena_zestawu.TabIndex = 2;
            textBox_cena_zestawu.TextChanged += textBox_cena_zestawu_TextChanged;
            // 
            // button_komputer
            // 
            button_komputer.Location = new Point(37, 75);
            button_komputer.Name = "button_komputer";
            button_komputer.Size = new Size(75, 23);
            button_komputer.TabIndex = 0;
            button_komputer.Text = "Komputer";
            button_komputer.UseVisualStyleBackColor = true;
            button_komputer.Click += button_komputer_Click;
            // 
            // button_monitor
            // 
            button_monitor.Location = new Point(136, 75);
            button_monitor.Name = "button_monitor";
            button_monitor.Size = new Size(75, 23);
            button_monitor.TabIndex = 1;
            button_monitor.Text = "Monitor";
            button_monitor.UseVisualStyleBackColor = true;
            button_monitor.Click += button_monitor_Click;
            // 
            // label_cena_zestawu
            // 
            label_cena_zestawu.AutoSize = true;
            label_cena_zestawu.Location = new Point(290, 46);
            label_cena_zestawu.Name = "label_cena_zestawu";
            label_cena_zestawu.Size = new Size(45, 15);
            label_cena_zestawu.TabIndex = 3;
            label_cena_zestawu.Text = "Cena zł";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 154);
            Controls.Add(label_cena_zestawu);
            Controls.Add(textBox_cena_zestawu);
            Controls.Add(button_monitor);
            Controls.Add(button_komputer);
            Name = "Form1";
            Text = "Kalkulator Zestawów Komputerowych";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_komputer;
        private Button button_monitor;
        private TextBox textBox_cena_zestawu;
        private Label label_cena_zestawu;
    }
}
