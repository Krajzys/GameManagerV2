using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManagerV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDB();
            // TODO: Add textbox to fill in game name
            // TODO: Add a button that will insert gamename into the database
            // TODO: Add an option to confirm game name with ENTER
            // TODO: Write functions to insert, delete, edit things in the database
            // TODO: Add list view of games that are in the database
            // TODO: Add possibility of editing game name, date and progress from the list view
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeDB()
        {
            string filename = @".\games.db";
            if (!File.Exists(filename))
            {
                MessageBox.Show("Creating database");
                string connectionString;
                connectionString = @"URI=file:.\games.db";

                SQLiteConnection cnn;
                cnn = new SQLiteConnection(connectionString);
                cnn.Open();

                using var cmd = new SQLiteCommand(cnn);
                cmd.CommandText = "CREATE TABLE games(id INTEGER PRIMARY KEY, name TEXT, date TEXT, progress TEXT, score INTEGER)";
                cmd.ExecuteNonQuery();

                cnn.Close();
            }
        }
    }
}
