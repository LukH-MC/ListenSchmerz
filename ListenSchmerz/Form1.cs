using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ListenSchmerz
{
    public partial class Form1 : Form
    {
        private static bool CheckDataBaseExists()
        {
            string con = "Server=localhost;Database=listen;User ID=root;";
            MySqlConnection connection = new MySqlConnection(con);
            try
            {
                connection.Open();
                Console.WriteLine("DB Verbunden!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            if (!CheckDataBaseExists())
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;User ID=root");
                string sqlbase = "CREATE DATABASE IF NOT EXISTS listen";

                string sqltable1 = "CREATE TABLE IF NOT EXISTS listen.kontakte(" +
                                   "`KontakteID` int(8) NOT NULL PRIMARY KEY," +
                                   "`Name` varchar(32) NOT NULL," +
                                   "`Vorname` varchar(32) NOT NULL," +
                                   "`Adresse` varchar(32) NOT NULL," +
                                   "`Telefon` int(11) NOT NULL," +
                                   "`Mail` varchar(64) NOT NULL," +
                                   "`BildID` int(11) NOT NULL)";

                string sqltable2 = "CREATE TABLE IF NOT EXISTS listen.todo(" +
                                   "`ToDoID` int(8) NOT NULL PRIMARY KEY," +
                                   "`Titel` varchar(64) NOT NULL," +
                                   "`Start` date NOT NULL," +
                                   "`End` date NOT NULL," +
                                   "`Prio` int(255) NOT NULL," +
                                   "`Kontakte` varchar(256) NOT NULL," +
                                   "`Beschreibung` varchar(256) NOT NULL," +
                                   "`Liste` int(11) NOT NULL)";

                string sqltable3 = "CREATE TABLE IF NOT EXISTS listen.todoliste(" +
                                   "`ListenID` varchar(32) NOT NULL PRIMARY KEY," +
                                   "`Desc` varchar(32) NOT NULL)";


                MySqlCommand baseCommand = new MySqlCommand(sqlbase, connection);
                MySqlCommand table1 = new MySqlCommand(sqltable1, connection);
                MySqlCommand table2 = new MySqlCommand(sqltable2, connection);
                MySqlCommand table3 = new MySqlCommand(sqltable3, connection);
                try
                {
                    connection.Open();
                    baseCommand.ExecuteNonQuery();
                    table1.ExecuteNonQuery();
                    table2.ExecuteNonQuery();
                    table3.ExecuteNonQuery();
                    Console.WriteLine("DataBase successfully created!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
