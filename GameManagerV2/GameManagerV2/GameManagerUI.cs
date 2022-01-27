using System;
using System.Windows.Forms;

namespace GameManagerV2
{
    public partial class GameManagerUI : Form
    {
        DatabaseHandler dbHandler;
        public GameManagerUI()
        {
            InitializeComponent();

            dbHandler = new DatabaseHandler();
            dbHandler.InitializeDB();
            UpdateGameListView();
        }

        private void UpdateGameListView(int selectRow = 0)
        {
            gameListView.Items.Clear();
            dbHandler.GetAllGames().ForEach((GameRecord game) => {
                ListViewItem item = new ListViewItem();
                item.Text = game.id.ToString();
                item.SubItems.Add(game.name);
                item.SubItems.Add(game.date.ToShortDateString());
                item.SubItems.Add(game.progress);
                item.SubItems.Add(game.score.ToString());
                if (gameListView.Items.Count == selectRow)
                {
                    item.Selected = true;
                }
                gameListView.Items.Add(item);
            });

            if (gameListView.Items.Count != 0)
            {
                gameListView.Items[gameListView.Items.Count - 1].EnsureVisible();
            }
        }

        private void GameManagerUI_Load(object sender, EventArgs e)
        {
            if (gameListView.Items.Count != 0)
            {
                gameListView.Items[0].Selected = true;
            }
            gameListView.Update();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            string gameName = gameNameBox.Text;
            gameNameBox.Text = "";

            dbHandler.Insert(gameName, out _);

            UpdateGameListView(gameListView.Items.Count);
        }

        private void gameNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addGameButton_Click(sender, e);
                if ((ModifierKeys & Keys.Shift) != Keys.Shift)
                {
                    progressBox.Focus();
                    scoreBox.ResetText();
                }

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
            if (gameListView.SelectedItems.Count != 0)
            {
                GameRecord game = new GameRecord();
                String id = gameListView.SelectedItems[0].Text;
                
                game = dbHandler.GetGameById(Convert.ToInt32(id));
                if (game.id != -1)
                {
                    nameBox.Text = game.name;
                    dateBox.Value = game.date;
                    progressBox.Text = game.progress;
                    scoreBox.Value = game.score;
                }
            }
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            if (gameListView.SelectedItems.Count != 0)
            {
                int id = Convert.ToInt32(gameListView.SelectedItems[0].Text);
                GameRecord gameRecord = new GameRecord(id, nameBox.Text, dateBox.Value, progressBox.Text, Convert.ToInt32(scoreBox.Value));

                dbHandler.ModifyByID(id, gameRecord);

                int prevIndex = gameListView.SelectedItems[0].Index;
                UpdateGameListView(prevIndex);
            }
        }

        private void gameListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (gameListView.SelectedItems.Count != 0)
                {
                    int id = Convert.ToInt32(gameListView.SelectedItems[0].Text);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete " + nameBox.Text + "?",
                        "Confirm delete",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dbHandler.DeleteByID(id);
                        UpdateGameListView(-1);
                        nameBox.Text = String.Empty;
                        dateBox.Value = DateTime.Now;
                        scoreBox.Value = 0;
                        progressBox.Text = String.Empty;
                    }
                }
            }
        }

        private void gameListView_Enter(object sender, EventArgs e)
        {
            if (gameListView.SelectedItems.Count != 0)
            {
                gameListView.SelectedItems[0].Focused = true;
            }
            else if (gameListView.FocusedItem != null)
            {
                gameListView.FocusedItem.Selected = true;
            }
            else if (gameListView.Items.Count != 0)
            {
                gameListView.Items[0].Selected = true;
                gameListView.Items[0].Focused = true;
            }
        }
    }
}
