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
        /*****
         * Ab hier ignorieren
         */

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
            //Contact save button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Image load button
            var filePath = string.Empty;

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = "c:\\Bilder";
            OpenFileDialog.Filter = "Images(*.BMP;*.JPG;*.GIF, *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            OpenFileDialog.RestoreDirectory = true;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                //Get the path of specified file
                filePath = OpenFileDialog.FileName;
            }
            try {
                pictureBox.Image = Image.FromFile(filePath);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Es wurde keine Datei angegeben!", "Error", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Data search button
        }
    }
}
