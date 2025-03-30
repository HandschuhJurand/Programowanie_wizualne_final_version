namespace Lab4_nowy
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
            pictureBox1 = new PictureBox();
            button_load = new Button();
            button_only_green = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(217, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(879, 587);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button_load
            // 
            button_load.Location = new Point(12, 554);
            button_load.Name = "button_load";
            button_load.Size = new Size(184, 61);
            button_load.TabIndex = 1;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += button_load_Click;
            // 
            // button_only_green
            // 
            button_only_green.BackColor = Color.FromArgb(192, 255, 192);
            button_only_green.Location = new Point(12, 442);
            button_only_green.Name = "button_only_green";
            button_only_green.Size = new Size(184, 61);
            button_only_green.TabIndex = 2;
            button_only_green.Text = "Only Green";
            button_only_green.UseVisualStyleBackColor = false;
            button_only_green.Click += button_only_green_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 661);
            Controls.Add(button_only_green);
            Controls.Add(button_load);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Edytor zdjec";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_load;
        private Button button_only_green;
    }
}
