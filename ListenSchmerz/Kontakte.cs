using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class Kontakte : Form
    {
        public Kontakte()
        {
            InitializeComponent();
        }

        private void Kontakte_Load(object sender, EventArgs e)
        {

        }

        private void lName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Contact add button
            MessageBox.Show(new NotImplementedException().ToString(), "Error", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            MessageBox.Show("Bite wählen sie nur Bilder aus die 156x156 Pixel Groß sind!", "Hinweis", MessageBoxButtons.OK);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Images(*.BMP;*.JPG;*.GIF, *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.Title = "Please select an image file";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                // Create and show the cropping form
                using (CropForm cropForm = new CropForm(filePath))
                {
                    if (cropForm.ShowDialog() == DialogResult.OK)
                    {
                        // Load the cropped image into PictureBox
                        pictureBox.Image = cropForm.CroppedImage;
                    }
                }
            }
            else
            {
                MessageBox.Show("Es wurde keine Datei angegeben!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Data delete button
            MessageBox.Show(new NotImplementedException().ToString(), "Error", MessageBoxButtons.OK);
        }
    }
}
