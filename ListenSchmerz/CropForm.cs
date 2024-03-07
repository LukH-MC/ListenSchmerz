using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class CropForm : Form
    {
        private Bitmap originalImage;
        private Rectangle initialSelection; // Initial rectangle
        private Point startPoint;
        private bool draggingInitialSelection;
        private float zoomFactor = 1.0f; // Zoom factor
        private const float initialZoomFactor = 0.1f; // Initial zoom factor for the image

        public CropForm(string imagePath)
        {
            InitializeComponent();
            // Load the original image
            originalImage = new Bitmap(imagePath);
            pictureBox.MouseDown += PictureBoxMouseDown;
            pictureBox.MouseMove += PictureBoxMouseMove;
            pictureBox.MouseUp += PictureBoxMouseUp;
            pictureBox.Paint += PictureBox_Paint; // Attach Paint event handler
            pictureBox.MouseWheel += PictureBox_MouseWheel; // Attach MouseWheel event handler

            // Set initial selection rectangle size to 156x156
            initialSelection = new Rectangle(0, 0, 156, 156);

            // Set initial zoom factor for the image
            zoomFactor = initialZoomFactor;

            // Resize and center the original image to 10% of the client window size
            ResizeAndCenterImage();

            Controls.Add(pictureBox);
            pictureBox.BringToFront();
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
                int deltaX = e.X - startPoint.X;
                int deltaY = e.Y - startPoint.Y;

                initialSelection.X += deltaX;
                initialSelection.Y += deltaY;

                startPoint = e.Location;

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
            // Draw the image
            e.Graphics.DrawImage(originalImage, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

            // Draw the inner rectangle
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                e.Graphics.DrawRectangle(pen, initialSelection);
            }

            // Draw the outer rectangle
            Rectangle outerRectangle = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            using (Pen pen = new Pen(Color.FromArgb(128, Color.Black), 2)) // Transparent color for the outer rectangle
            {
                e.Graphics.DrawRectangle(pen, outerRectangle);
            }
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            float zoomChange = delta > 0 ? 0.1f : -0.1f; // Change in zoom factor
            zoomFactor += zoomChange; // Adjust zoom factor
            zoomFactor = Math.Max(zoomFactor, 0.1f); // Ensure zoom factor stays within reasonable bounds

            // Resize and center the image according to the new zoom factor
            ResizeAndCenterImage();

            pictureBox.Invalidate();
        }

        // Method to resize and center the image based on the current zoom factor
        private void ResizeAndCenterImage()
        {
            int newWidth = (int)(originalImage.Width * zoomFactor);
            int newHeight = (int)(originalImage.Height * zoomFactor);

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = ResizeImage(originalImage, newWidth, newHeight);

            // Reposition the initial selection rectangle to keep it centered
            initialSelection.X = (pictureBox.Width - initialSelection.Width) / 2;
            initialSelection.Y = (pictureBox.Height - initialSelection.Height) / 2;
        }

        // Method to resize the image
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
