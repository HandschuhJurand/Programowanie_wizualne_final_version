namespace Lab2
{
    partial class Form3
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
            textBox_monitor = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            button_ok = new Button();
            button_anuluj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 199);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Cena";
            // 
            // textBox_monitor
            // 
            textBox_monitor.Location = new Point(67, 196);
            textBox_monitor.Name = "textBox_monitor";
            textBox_monitor.ReadOnly = true;
            textBox_monitor.Size = new Size(100, 23);
            textBox_monitor.TabIndex = 3;
            textBox_monitor.TextChanged += textBox_monitor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 199);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 4;
            label2.Text = "zł";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(213, 154);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button_ok
            // 
            button_ok.Location = new Point(12, 270);
            button_ok.Name = "button_ok";
            button_ok.Size = new Size(75, 23);
            button_ok.TabIndex = 6;
            button_ok.Text = "OK";
            button_ok.UseVisualStyleBackColor = true;
            button_ok.Click += button_ok_Click;
            // 
            // button_anuluj
            // 
            button_anuluj.Location = new Point(150, 270);
            button_anuluj.Name = "button_anuluj";
            button_anuluj.Size = new Size(75, 23);
            button_anuluj.TabIndex = 7;
            button_anuluj.Text = "ANULUJ";
            button_anuluj.UseVisualStyleBackColor = true;
            button_anuluj.Click += button_anuluj_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 324);
            Controls.Add(button_anuluj);
            Controls.Add(button_ok);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(textBox_monitor);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Monitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_monitor;
        private Label label2;
        private ListView listView1;
        private Button button_ok;
        private Button button_anuluj;
    }
}