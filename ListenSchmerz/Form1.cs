using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_projects_Click(object sender, EventArgs e)
        {
            ToDo toDo = new ToDo();
            toDo.ShowDialog();
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            Kontakte kontakte = new Kontakte();
            kontakte.ShowDialog();
        }
    }
}
