using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ListenSchmerz
{
    public partial class ToDo : Form
    {
        public bool darkMode;
        private TreeView tv_TreeView;
        private TextBox tb_Title;
        private Label lStart;
        private DateTimePicker dtp_Startawd;
        private DateTimePicker dtp_End;
        private Label lEnd;
        private Label lPrio;
        private NumericUpDown nud_Prio;
        private Label lContacts;
        private ListBox lt_contacts;
        private Button button_selCont;
        private Label lDesc;
        private RichTextBox tb_desc;
        private CheckBox cb_Done;
        private Button button_newToDo;
        private Button button_newEntry;
        private Button button_delete;
        private DateTimePickerWithBackColor.BCDateTimePicker dtp_Start;
        private Label lTitle;


        public ToDo(bool darkMode)
        {
            InitializeComponent();
            Console.WriteLine("Test");
            //Control DarkMode
            this.darkMode = darkMode;
            switch (darkMode)
            {
                case true:
                    this.BackColor = System.Drawing.Color.DimGray;
                    this.button_delete.BackColor = System.Drawing.Color.LightGray;
                    this.button_newEntry.BackColor = System.Drawing.Color.LightGray;
                    this.button_newToDo.BackColor = System.Drawing.Color.LightGray;
                    this.button_selCont.BackColor = System.Drawing.Color.LightGray;
                    this.tv_TreeView.BackColor = System.Drawing.Color.Gainsboro;
                    this.tb_Title.BackColor = System.Drawing.Color.Gainsboro;
                    this.dtp_Startawd.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
                    this.dtp_End.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
                    this.nud_Prio.BackColor = System.Drawing.Color.Gainsboro;
                    this.lt_contacts.BackColor = System.Drawing.Color.Gainsboro;
                    this.tb_desc.BackColor = System.Drawing.Color.Gainsboro;
                    Console.WriteLine("true");
                    break;

                case false:
                    this.button_delete.BackColor = SystemColors.ControlLight;
                    this.button_newEntry.BackColor = SystemColors.ControlLight;
                    this.button_newToDo.BackColor = SystemColors.ControlLight;
                    this.button_selCont.BackColor = SystemColors.ControlLight;
                    this.BackColor= SystemColors.Control;
                    Console.WriteLine("false");
                    break;
            }
        }

        private void InitializeComponent()
        {
            //so kannst du eine DB verbindung aufbauen
            /*
            string con = "Server=127.0.0.1;Database=listen;User ID=root;";
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                Console.WriteLine("DB Verbunden!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }*/



            this.tv_TreeView = new System.Windows.Forms.TreeView();
            this.lTitle = new System.Windows.Forms.Label();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.lStart = new System.Windows.Forms.Label();
            this.dtp_Startawd = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.lEnd = new System.Windows.Forms.Label();
            this.lPrio = new System.Windows.Forms.Label();
            this.nud_Prio = new System.Windows.Forms.NumericUpDown();
            this.lContacts = new System.Windows.Forms.Label();
            this.lt_contacts = new System.Windows.Forms.ListBox();
            this.button_selCont = new System.Windows.Forms.Button();
            this.lDesc = new System.Windows.Forms.Label();
            this.tb_desc = new System.Windows.Forms.RichTextBox();
            this.cb_Done = new System.Windows.Forms.CheckBox();
            this.button_newToDo = new System.Windows.Forms.Button();
            this.button_newEntry = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dtp_Start = new DateTimePickerWithBackColor.BCDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).BeginInit();
            this.SuspendLayout();
            // 
            // tv_TreeView
            // 
            this.tv_TreeView.BackColor = System.Drawing.SystemColors.Window;
            this.tv_TreeView.Location = new System.Drawing.Point(12, 25);
            this.tv_TreeView.Name = "tv_TreeView";
            this.tv_TreeView.Size = new System.Drawing.Size(373, 593);
            this.tv_TreeView.TabIndex = 0;
            this.tv_TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(406, 27);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(41, 20);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Titel";
            this.lTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(533, 25);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(368, 22);
            this.tb_Title.TabIndex = 2;
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStart.Location = new System.Drawing.Point(406, 84);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(91, 20);
            this.lStart.TabIndex = 3;
            this.lStart.Text = "Startdatum";
            this.lStart.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtp_Startawd
            // 
            this.dtp_Startawd.Location = new System.Drawing.Point(533, 84);
            this.dtp_Startawd.Name = "dtp_Startawd";
            this.dtp_Startawd.Size = new System.Drawing.Size(368, 22);
            this.dtp_Startawd.TabIndex = 5;
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(533, 142);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(368, 22);
            this.dtp_End.TabIndex = 7;
            // 
            // lEnd
            // 
            this.lEnd.AutoSize = true;
            this.lEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEnd.Location = new System.Drawing.Point(406, 142);
            this.lEnd.Name = "lEnd";
            this.lEnd.Size = new System.Drawing.Size(84, 20);
            this.lEnd.TabIndex = 6;
            this.lEnd.Text = "Enddatum";
            // 
            // lPrio
            // 
            this.lPrio.AutoSize = true;
            this.lPrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrio.Location = new System.Drawing.Point(406, 202);
            this.lPrio.Name = "lPrio";
            this.lPrio.Size = new System.Drawing.Size(68, 20);
            this.lPrio.TabIndex = 8;
            this.lPrio.Text = "Priorität";
            this.lPrio.Click += new System.EventHandler(this.label3_Click);
            // 
            // nud_Prio
            // 
            this.nud_Prio.Location = new System.Drawing.Point(533, 199);
            this.nud_Prio.Name = "nud_Prio";
            this.nud_Prio.Size = new System.Drawing.Size(57, 22);
            this.nud_Prio.TabIndex = 9;
            // 
            // lContacts
            // 
            this.lContacts.AutoSize = true;
            this.lContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lContacts.Location = new System.Drawing.Point(406, 258);
            this.lContacts.Name = "lContacts";
            this.lContacts.Size = new System.Drawing.Size(84, 40);
            this.lContacts.TabIndex = 10;
            this.lContacts.Text = "betroffene\r\nKontakte";
            this.lContacts.Click += new System.EventHandler(this.label4_Click);
            // 
            // lt_contacts
            // 
            this.lt_contacts.FormattingEnabled = true;
            this.lt_contacts.ItemHeight = 16;
            this.lt_contacts.Location = new System.Drawing.Point(533, 258);
            this.lt_contacts.Name = "lt_contacts";
            this.lt_contacts.ScrollAlwaysVisible = true;
            this.lt_contacts.Size = new System.Drawing.Size(358, 36);
            this.lt_contacts.TabIndex = 11;
            this.lt_contacts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_selCont
            // 
            this.button_selCont.Location = new System.Drawing.Point(668, 229);
            this.button_selCont.Name = "button_selCont";
            this.button_selCont.Size = new System.Drawing.Size(223, 23);
            this.button_selCont.TabIndex = 12;
            this.button_selCont.Text = "Kontakte auswählen";
            this.button_selCont.UseVisualStyleBackColor = true;
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.Location = new System.Drawing.Point(406, 353);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(112, 20);
            this.lDesc.TabIndex = 13;
            this.lDesc.Text = "Beschreibung";
            // 
            // tb_desc
            // 
            this.tb_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_desc.Location = new System.Drawing.Point(533, 353);
            this.tb_desc.Name = "tb_desc";
            this.tb_desc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tb_desc.Size = new System.Drawing.Size(358, 302);
            this.tb_desc.TabIndex = 15;
            this.tb_desc.Text = "";
            this.tb_desc.TextChanged += new System.EventHandler(this.tb_desc_TextChanged);
            // 
            // cb_Done
            // 
            this.cb_Done.AutoSize = true;
            this.cb_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Done.Location = new System.Drawing.Point(636, 674);
            this.cb_Done.Name = "cb_Done";
            this.cb_Done.Size = new System.Drawing.Size(157, 42);
            this.cb_Done.TabIndex = 16;
            this.cb_Done.Text = "Erledigt";
            this.cb_Done.UseVisualStyleBackColor = true;
            // 
            // button_newToDo
            // 
            this.button_newToDo.Location = new System.Drawing.Point(35, 624);
            this.button_newToDo.Name = "button_newToDo";
            this.button_newToDo.Size = new System.Drawing.Size(146, 32);
            this.button_newToDo.TabIndex = 17;
            this.button_newToDo.Text = "Neue TODO-Liste";
            this.button_newToDo.UseVisualStyleBackColor = true;
            // 
            // button_newEntry
            // 
            this.button_newEntry.Location = new System.Drawing.Point(209, 624);
            this.button_newEntry.Name = "button_newEntry";
            this.button_newEntry.Size = new System.Drawing.Size(146, 32);
            this.button_newEntry.TabIndex = 18;
            this.button_newEntry.Text = "Neuer Eintrag";
            this.button_newEntry.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(123, 678);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(146, 32);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Löschen";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // dtp_Start
            // 
            this.dtp_Start.BackDisabledColor = System.Drawing.SystemColors.Window;
            this.dtp_Start.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtp_Start.Location = new System.Drawing.Point(533, 110);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(368, 22);
            this.dtp_Start.TabIndex = 5;
            // 
            // ToDo
            // 
            this.ClientSize = new System.Drawing.Size(959, 738);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_newEntry);
            this.Controls.Add(this.button_newToDo);
            this.Controls.Add(this.cb_Done);
            this.Controls.Add(this.tb_desc);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.button_selCont);
            this.Controls.Add(this.lt_contacts);
            this.Controls.Add(this.lContacts);
            this.Controls.Add(this.nud_Prio);
            this.Controls.Add(this.lPrio);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.lEnd);
            this.Controls.Add(this.dtp_Startawd);
            this.Controls.Add(this.lStart);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tv_TreeView);
            this.MaximumSize = new System.Drawing.Size(977, 785);
            this.MinimumSize = new System.Drawing.Size(977, 785);
            this.Name = "ToDo";
            this.Text = "ToDoListe";
            this.Load += new System.EventHandler(this.ToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Prio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void button_newTodo(object sender, EventArgs e)
        {
            string con = "Server=127.0.0.1;Database=listen;User ID=root;";
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                Console.WriteLine("DB Verbunden!");
                MySqlTransaction insertTrans = connection.BeginTransaction();
                MySqlCommand insertSQL = connection.CreateCommand();
                insertSQL.CommandText = "INSERT INTO todoliste VALUES (" + this.tb_Title.Text + ", " + this.tb_desc.Text + ");";
                insertSQL.ExecuteNonQuery();
                insertTrans.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            connection.Close();
        }

        private void ToDo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_desc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
