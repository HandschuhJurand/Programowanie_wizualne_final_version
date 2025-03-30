namespace Lab4_nowy
{
    public partial class Form1 : Form
    {
        private int stopnie;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_load_Click(object sender, EventArgs e)
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

        private void button_only_green_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap orginalny = new Bitmap(pictureBox1.Image);
            Bitmap zielony = new Bitmap(orginalny.Width, orginalny.Height);

            for (int x = 0; x < orginalny.Width; x++)
            {
                for (int y = 0; y < orginalny.Height; y++)
                {
                    Color pixel = orginalny.GetPixel(x, y);

                    // Sprawdzamy czy piksel jest bardziej zielony ni¿ czerwony i niebieski
                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        zielony.SetPixel(x, y, pixel); // Zachowujemy oryginalny kolor
                    }
                    else
                    {
                        zielony.SetPixel(x, y, Color.Black); // Ustawiamy czarny kolor
                    }
                }
            }

            pictureBox1.Image = zielony;
            orginalny.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopnie1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stopnie2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stopnie3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_rotate_Click(object sender, EventArgs e)
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

        private void button_invert_colors_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap orginalny = (Bitmap)pictureBox1.Image;
                Bitmap negatyw = new Bitmap(orginalny.Width, orginalny.Height);

                for (int x = 0; x < orginalny.Width; x++)
                {
                    for (int y = 0; y < orginalny.Height; y++)
                    {
                        Color pixel = orginalny.GetPixel(x, y);
                        negatyw.SetPixel(x, y, Color.FromArgb(pixel.A, 255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                    }
                }

                pictureBox1.Image = negatyw;
                orginalny.Dispose();
            }
        }

        private void button_up_side_down_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap orginalny = (Bitmap)pictureBox1.Image;
                Bitmap odwrocony = new Bitmap(orginalny);

                odwrocony.RotateFlip(RotateFlipType.RotateNoneFlipY);

                pictureBox1.Image = odwrocony;
                orginalny.Dispose();
            }
        }
    }
}
