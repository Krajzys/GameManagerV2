using System;
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
            dbHandler.GetAllGames().ForEach((GameRecord game) => {
                ListViewItem item = new ListViewItem();
                item.Text = game.id.ToString();
                item.SubItems.Add(game.name);
                item.SubItems.Add(game.date.ToString());
                item.SubItems.Add(game.progress);
                item.SubItems.Add(game.score.ToString());
                gameListView.Items.Add(item);
            });

            // TODO: Write functions to delete, edit things in the database
            // TODO: Add list view of games that are in the database - In Progress
            // TODO: Add possibility of editing game name, date and progress from the list view - In Progress
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameListView.Update();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            string gameName = gameNameBox.Text;
            gameNameBox.Text = "";

            int id;
            dbHandler.Insert(gameName, out id);
            GameRecord game = dbHandler.GetGameById(id);

            ListViewItem item = new ListViewItem();
            item.Text = game.id.ToString();
            item.SubItems.Add(game.name);
            item.SubItems.Add(game.date.ToString());
            item.SubItems.Add(game.progress);
            item.SubItems.Add(game.score.ToString());
            item.Selected = true;
            gameListView.Items.Add(item);

            gameListView.Update();
        }

        private void gameNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void nameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dateBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void progressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void scoreBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                editGameButton_Click(sender, e);

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void gameListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView list = (ListView) sender;
            GameRecord game = new GameRecord();
            foreach (ListViewItem item in list.SelectedItems)
            {
                game = dbHandler.GetGameById(Convert.ToInt32(item.Text));
            }
            nameBox.Text = game.name;
            dateBox.Text = game.date.ToString();
            progressBox.Text = game.progress;
            scoreBox.Text = game.score.ToString();
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            // TODO: Finish this
            MessageBox.Show("Saved");
        }
    }
}
