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
            stopnie1 = new RadioButton();
            stopnie2 = new RadioButton();
            stopnie3 = new RadioButton();
            button_rotate = new Button();
            button_invert_colors = new Button();
            button_up_side_down = new Button();
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
            // stopnie1
            // 
            stopnie1.AutoSize = true;
            stopnie1.Location = new Point(12, 28);
            stopnie1.Name = "stopnie1";
            stopnie1.Size = new Size(64, 29);
            stopnie1.TabIndex = 2;
            stopnie1.TabStop = true;
            stopnie1.Text = "90°";
            stopnie1.UseVisualStyleBackColor = true;
            stopnie1.CheckedChanged += stopnie1_CheckedChanged;
            // 
            // stopnie2
            // 
            stopnie2.AutoSize = true;
            stopnie2.Location = new Point(12, 63);
            stopnie2.Name = "stopnie2";
            stopnie2.Size = new Size(74, 29);
            stopnie2.TabIndex = 3;
            stopnie2.TabStop = true;
            stopnie2.Text = "180°";
            stopnie2.UseVisualStyleBackColor = true;
            stopnie2.CheckedChanged += stopnie2_CheckedChanged;
            // 
            // stopnie3
            // 
            stopnie3.AutoSize = true;
            stopnie3.Location = new Point(12, 98);
            stopnie3.Name = "stopnie3";
            stopnie3.Size = new Size(74, 29);
            stopnie3.TabIndex = 4;
            stopnie3.TabStop = true;
            stopnie3.Text = "270°";
            stopnie3.UseVisualStyleBackColor = true;
            stopnie3.CheckedChanged += stopnie3_CheckedChanged;
            // 
            // button_rotate
            // 
            button_rotate.BackColor = Color.FromArgb(255, 128, 128);
            button_rotate.Location = new Point(12, 148);
            button_rotate.Name = "button_rotate";
            button_rotate.Size = new Size(184, 61);
            button_rotate.TabIndex = 5;
            button_rotate.Text = "Rotate";
            button_rotate.UseVisualStyleBackColor = false;
            button_rotate.Click += button_rotate_Click;
            // 
            // button_invert_colors
            // 
            button_invert_colors.BackColor = SystemColors.ActiveCaption;
            button_invert_colors.Location = new Point(12, 215);
            button_invert_colors.Name = "button_invert_colors";
            button_invert_colors.Size = new Size(184, 61);
            button_invert_colors.TabIndex = 6;
            button_invert_colors.Text = "Invert Colors";
            button_invert_colors.UseVisualStyleBackColor = false;
            button_invert_colors.Click += button_invert_colors_Click;
            // 
            // button_up_side_down
            // 
            button_up_side_down.BackColor = SystemColors.ActiveCaption;
            button_up_side_down.Location = new Point(12, 282);
            button_up_side_down.Name = "button_up_side_down";
            button_up_side_down.Size = new Size(184, 61);
            button_up_side_down.TabIndex = 7;
            button_up_side_down.Text = "Up Side Down";
            button_up_side_down.UseVisualStyleBackColor = false;
            button_up_side_down.Click += button_up_side_down_Click;
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
            Controls.Add(button_up_side_down);
            Controls.Add(button_invert_colors);
            Controls.Add(button_rotate);
            Controls.Add(stopnie3);
            Controls.Add(stopnie2);
            Controls.Add(stopnie1);
            Controls.Add(button_only_green);
            Controls.Add(button_load);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Edytor zdjec";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_load;
        private RadioButton stopnie1;
        private RadioButton stopnie2;
        private RadioButton stopnie3;
        private Button button_rotate;
        private Button button_invert_colors;
        private Button button_up_side_down;
        private Button button_only_green;
    }
}
