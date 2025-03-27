namespace Lab4
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
            Load = new Button();
            pictureBox1 = new PictureBox();
            stopnie1 = new RadioButton();
            stopnie2 = new RadioButton();
            stopnie3 = new RadioButton();
            rotate = new Button();
            Invert_colors = new Button();
            up_side_down = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Load
            // 
            Load.Location = new Point(23, 545);
            Load.Name = "Load";
            Load.Size = new Size(167, 55);
            Load.TabIndex = 0;
            Load.Text = "Load";
            Load.UseVisualStyleBackColor = true;
            Load.Click += Load_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(196, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(989, 583);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // stopnie1
            // 
            stopnie1.AutoSize = true;
            stopnie1.BackColor = Color.Transparent;
            stopnie1.Location = new Point(23, 26);
            stopnie1.Name = "stopnie1";
            stopnie1.Size = new Size(64, 29);
            stopnie1.TabIndex = 2;
            stopnie1.TabStop = true;
            stopnie1.Text = "90°";
            stopnie1.UseVisualStyleBackColor = false;
            stopnie1.CheckedChanged += stopnie1_CheckedChanged;
            // 
            // stopnie2
            // 
            stopnie2.AutoSize = true;
            stopnie2.Location = new Point(23, 61);
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
            stopnie3.Location = new Point(23, 96);
            stopnie3.Name = "stopnie3";
            stopnie3.Size = new Size(74, 29);
            stopnie3.TabIndex = 4;
            stopnie3.TabStop = true;
            stopnie3.Text = "270°";
            stopnie3.UseVisualStyleBackColor = true;
            stopnie3.CheckedChanged += stopnie3_CheckedChanged;
            // 
            // rotate
            // 
            rotate.BackColor = Color.FromArgb(255, 128, 128);
            rotate.BackgroundImageLayout = ImageLayout.Zoom;
            rotate.Location = new Point(23, 168);
            rotate.Name = "rotate";
            rotate.Size = new Size(167, 59);
            rotate.TabIndex = 5;
            rotate.Text = "Rotate";
            rotate.UseVisualStyleBackColor = false;
            rotate.Click += rotate_Click;
            // 
            // Invert_colors
            // 
            Invert_colors.BackColor = SystemColors.ActiveCaption;
            Invert_colors.Location = new Point(23, 233);
            Invert_colors.Name = "Invert_colors";
            Invert_colors.Size = new Size(167, 55);
            Invert_colors.TabIndex = 6;
            Invert_colors.Text = "Invert Colors";
            Invert_colors.UseVisualStyleBackColor = false;
            Invert_colors.Click += Invert_colors_Click;
            // 
            // up_side_down
            // 
            up_side_down.BackColor = SystemColors.ActiveCaption;
            up_side_down.Location = new Point(23, 294);
            up_side_down.Name = "up_side_down";
            up_side_down.Size = new Size(167, 54);
            up_side_down.TabIndex = 7;
            up_side_down.Text = "Upside Down";
            up_side_down.UseVisualStyleBackColor = false;
            up_side_down.Click += up_side_down_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 639);
            Controls.Add(up_side_down);
            Controls.Add(Invert_colors);
            Controls.Add(rotate);
            Controls.Add(stopnie3);
            Controls.Add(stopnie2);
            Controls.Add(stopnie1);
            Controls.Add(pictureBox1);
            Controls.Add(Load);
            Name = "Form1";
            Text = "Edytor zdjec";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Load;
        private PictureBox pictureBox1;
        private RadioButton stopnie1;
        private RadioButton stopnie2;
        private RadioButton stopnie3;
        private Button rotate;
        private Button Invert_colors;
        private Button up_side_down;
    }
}
