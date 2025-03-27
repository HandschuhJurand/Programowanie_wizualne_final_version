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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Load
            // 
            Load.Location = new Point(38, 566);
            Load.Name = "Load";
            Load.Size = new Size(112, 34);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 639);
            Controls.Add(pictureBox1);
            Controls.Add(Load);
            Name = "Form1";
            Text = "Edytor zdjec";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Load;
        private PictureBox pictureBox1;
    }
}
