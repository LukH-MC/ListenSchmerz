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
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ToDo
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "ToDo";
            this.Text = "ToDoListe";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.ResumeLayout(false);

        }

        private void ToDo_Load(object sender, EventArgs e)
        {

        }
    }
}
