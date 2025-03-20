namespace Lab3
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
            dataGridView1 = new DataGridView();
            button_dodaj = new Button();
            button_usun = new Button();
            button_zapis = new Button();
            button_odczyt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(894, 406);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button_dodaj
            // 
            button_dodaj.Location = new Point(998, 64);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(112, 34);
            button_dodaj.TabIndex = 1;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = true;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // button_usun
            // 
            button_usun.Location = new Point(998, 154);
            button_usun.Name = "button_usun";
            button_usun.Size = new Size(112, 34);
            button_usun.TabIndex = 2;
            button_usun.Text = "Usun";
            button_usun.UseVisualStyleBackColor = true;
            button_usun.Click += button_usun_Click;
            // 
            // button_zapis
            // 
            button_zapis.Location = new Point(59, 487);
            button_zapis.Name = "button_zapis";
            button_zapis.Size = new Size(150, 34);
            button_zapis.TabIndex = 3;
            button_zapis.Text = "Zapis do .csv";
            button_zapis.UseVisualStyleBackColor = true;
            button_zapis.Click += button_zapis_Click;
            // 
            // button_odczyt
            // 
            button_odczyt.Location = new Point(319, 487);
            button_odczyt.Name = "button_odczyt";
            button_odczyt.Size = new Size(150, 34);
            button_odczyt.TabIndex = 4;
            button_odczyt.Text = "Odczyt z .csv";
            button_odczyt.UseVisualStyleBackColor = true;
            button_odczyt.Click += button_odczyt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 634);
            Controls.Add(button_odczyt);
            Controls.Add(button_zapis);
            Controls.Add(button_usun);
            Controls.Add(button_dodaj);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_dodaj;
        private Button button_usun;
        private Button button_zapis;
        private Button button_odczyt;
    }
}
