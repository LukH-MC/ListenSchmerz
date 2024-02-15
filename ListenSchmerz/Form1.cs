using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class Form1 : Form
    {
        public bool darkMode;

        public Form1()
        {
            InitializeComponent();
    }

        private void button_projects_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo(darkMode);
            toDo.ShowDialog();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            Kontakte kontakte = new Kontakte();
            kontakte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (darkMode)
            {
                case true: //when switched to DarkMode
                    this.button_togleDarkMode.Text = "🌙";
                    this.button_togleDarkMode.BackColor = SystemColors.ControlLight;
                    this.BackColor = SystemColors.Control;
                    this.button_employee.BackColor = SystemColors.ControlLight;
                    this.button_projects.BackColor = SystemColors.ControlLight;
                    darkMode = false;
                    break;

                case false: //when switched away from DarkMode
                    this.button_togleDarkMode.Text = "☀";
                    this.button_togleDarkMode.BackColor = System.Drawing.Color.LightGray;
                    this.BackColor = System.Drawing.Color.DimGray;
                    this.button_employee.BackColor = System.Drawing.Color.LightGray;
                    this.button_projects.BackColor = System.Drawing.Color.LightGray;
                    darkMode = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
