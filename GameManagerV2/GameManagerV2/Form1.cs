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
        DatabaseHandler dbHandler;
        public Form1()
        {
            InitializeComponent();
            dbHandler = new DatabaseHandler();
            dbHandler.InitializeDB();
            dbHandler.GetAllGames().ForEach((GameRecord game) => { MessageBox.Show(game.name); });
            this.listView1.Columns.Add("Name");
            this.listView1.Columns.Add("Date");
            this.listView1.Columns.Add("Progress");
            this.listView1.Columns.Add("Score");

            // TODO: Why the sound when you press enter ?
            // TODO: Write functions to delete, edit things in the database
            // TODO: Add list view of games that are in the database
            // TODO: Add possibility of editing game name, date and progress from the list view
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.Update();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            string gameName = this.textBox1.Text;
            this.textBox1.Text = "";
            dbHandler.Insert(gameName);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
