namespace Lab4
{
    public partial class Form1 : Form
    {
        private int stopnie;
        public Form1()
        {
            InitializeComponent();
        }

        private void Rotacja()
        {
            if (pictureBox1 != null)
            {
                Bitmap orginalny = (Bitmap)pictureBox1.Image;
                Bitmap zrotowany = new Bitmap(orginalny);

                if (stopnie1.Checked)
                {
                    zrotowany.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                if (stopnie2.Checked)
                {
                    zrotowany.RotateFlip(RotateFlipType.Rotate180FlipNone);
                }
                if (stopnie3.Checked)
                {
                    zrotowany.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }

                pictureBox1.Image = zrotowany;
                orginalny.Dispose();
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki graficzne |*.jpg; *.jpeg; *.png; *.bmp|Wszystkie pliki (*.*)|*.*";
            ofd.Title = "Wybierz plik graficzny do wczytania";
            ofd.ShowDialog();

            if (ofd.FileName != "")
            {
                Bitmap bitmapa = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = bitmapa;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rotate_Click(object sender, EventArgs e)
        {
            Rotacja();
        }

        private void stopnie1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stopnie2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
