using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class CropForm : Form
    {
        private PictureBox pictureBox;
        private Button cropButton;
        private Bitmap originalImage;
        private Rectangle initialSelection; // Initial rectangle
        private Point startPoint;
        private bool draggingInitialSelection;
        private float zoomFactor = 1.0f; // Zoom factor

        public CropForm(string imagePath)
        {
            InitializeComponent();
            // Load the original image
            originalImage = new Bitmap(imagePath);


            pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = originalImage,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = true,
                Cursor = Cursors.Cross,
            };
            pictureBox.MouseDown += PictureBoxMouseDown;
            pictureBox.MouseMove += PictureBoxMouseMove;
            pictureBox.MouseUp += PictureBoxMouseUp;
            pictureBox.Paint += PictureBox_Paint; // Attach Paint event handler
            pictureBox.MouseWheel += PictureBox_MouseWheel; // Attach MouseWheel event handler

            // Initialize initial selection rectangle
            int initialWidth = 156;
            int initialHeight = 156;
            int initialX = (pictureBox.Width - initialWidth) / 2;
            int initialY = (pictureBox.Height - initialHeight) / 2;
            initialSelection = new Rectangle(initialX, initialY, initialWidth, initialHeight);

            Controls.Add(pictureBox);
            pictureBox.BringToFront();

            cropButton = new Button
            {
                Text = "Zuschneiden",
                Dock = DockStyle.Bottom
            };
            cropButton.Click += CropButtonClick;

            Controls.Add(cropButton);
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                if (initialSelection.Contains(startPoint))
                {
                    draggingInitialSelection = true;
                }
            }
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (draggingInitialSelection)
            {
                initialSelection.X = e.X - initialSelection.Width / 2;
                initialSelection.Y = e.Y - initialSelection.Height / 2;
                pictureBox.Invalidate();
            }
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            draggingInitialSelection = false;
        }

        private void CropButtonClick(object sender, EventArgs e)
        {
            // Crop the image using the coordinates of the blue rectangle
            if (initialSelection.Width > 0 && initialSelection.Height > 0)
            {
                // Create a bitmap for the cropped image
                Bitmap croppedImage = new Bitmap(initialSelection.Width, initialSelection.Height);

                // Copy the selected portion of the original image to the cropped image
                using (Graphics g = Graphics.FromImage(croppedImage))
                {
                    g.DrawImage(originalImage, new Rectangle(0, 0, croppedImage.Width, croppedImage.Height),
                                initialSelection, GraphicsUnit.Pixel);
                }

                // Set the cropped image as the result
                CroppedImage = croppedImage;

                // Close the form
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public Bitmap CroppedImage { get; private set; }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Zeichne das Bild
            e.Graphics.DrawImage(originalImage, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

            // Zeichne das innere Rechteck
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                e.Graphics.DrawRectangle(pen, initialSelection);
            }

            // Zeichne das äußere Rechteck
            Rectangle outerRectangle = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            using (Pen pen = new Pen(Color.FromArgb(128, Color.Black), 2)) // Transparente Farbe für das äußere Rechteck
            {
                e.Graphics.DrawRectangle(pen, outerRectangle);
            }
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            float zoomChange = delta > 0 ? 0.1f : -0.1f; // Änderung des Zoomfaktors
            zoomFactor += zoomChange; // Zoomfaktor anpassen
            zoomFactor = Math.Max(zoomFactor, 0.1f); // Sicherstellen, dass der Zoomfaktor innerhalb vernünftiger Grenzen bleibt

            int newWidth = (int)(originalImage.Width * zoomFactor);
            int newHeight = (int)(originalImage.Height * zoomFactor);

            // Berechnen Sie den maximalen Ausschnitt, den Sie anzeigen können
            int maxVisibleWidth = pictureBox.ClientSize.Width;
            int maxVisibleHeight = pictureBox.ClientSize.Height;

            // Wenn das Bild kleiner als die maximale sichtbare Größe ist, passen Sie die Größe entsprechend an
            if (newWidth < maxVisibleWidth && newHeight < maxVisibleHeight)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox.Image = ResizeImage(originalImage, newWidth, newHeight);
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Image = ResizeImage(originalImage, maxVisibleWidth, maxVisibleHeight);
            }

            // Den Bildausschnitt neu positionieren, um ihn zentriert zu halten
            initialSelection.X = (pictureBox.Width - initialSelection.Width) / 2;
            initialSelection.Y = (pictureBox.Height - initialSelection.Height) / 2;

            pictureBox.Invalidate();
        }

        // Methode zum Ändern der Größe des Bildes
        private Bitmap ResizeImage(Bitmap image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

    }
}
