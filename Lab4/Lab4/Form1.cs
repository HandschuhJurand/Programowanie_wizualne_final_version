namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void only_green_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color pixel = originalBitmap.GetPixel(x, y);

                    if (pixel.G > pixel.R && pixel.G > pixel.B)
                    {
                        newBitmap.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        newBitmap.SetPixel(x, y, Color.Black);
                    }
                }
            }

            pictureBox1.Image = newBitmap;
            originalBitmap.Dispose();
        }
    }
}
