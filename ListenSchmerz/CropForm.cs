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
        private bool selecting_;
        private bool draggingInitialSelection;

        public CropForm(string imagePath)
        {
            InitializeComponent();
            // Load the original image
            originalImage = new Bitmap(imagePath);

            // Initialize form components
            Text = "Bild zuschneiden";
            Size = new Size(1025, 600);

            // Calculate the location to position the PictureBox in the center of the screen
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int pictureBoxWidth = 1500; // Set the desired width of the PictureBox
            int pictureBoxHeight = 1000; // Set the desired height of the PictureBox
            int pictureBoxX = (screenWidth - pictureBoxWidth) / 2;
            int pictureBoxY = (screenHeight - pictureBoxHeight) / 2;

            pictureBox = new PictureBox
            {
                Location = new Point(pictureBoxX, pictureBoxY),
                Size = new Size(pictureBoxWidth, pictureBoxHeight),
                Image = originalImage,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = true,
                Cursor = Cursors.Cross,
            };
            pictureBox.MouseDown += PictureBoxMouseDown;
            pictureBox.MouseMove += PictureBoxMouseMove;
            pictureBox.MouseUp += PictureBoxMouseUp;
            pictureBox.Paint += PictureBox_Paint; // Attach Paint event handler


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
                else
                {
                    selecting_ = true;
                }
            }
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (selecting_)
            {
            }
            else if (draggingInitialSelection)
            {
                initialSelection.X = e.X - initialSelection.Width / 2;
                initialSelection.Y = e.Y - initialSelection.Height / 2;
                pictureBox.Invalidate();
            }
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            selecting_ = false;
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
            using (Pen pen = new Pen(Color.Blue, 2))
            {
                e.Graphics.DrawRectangle(pen, initialSelection);
            }
        }

    }
}
