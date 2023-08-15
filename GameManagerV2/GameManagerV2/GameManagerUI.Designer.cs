namespace GameManagerV2
{
    partial class GameManagerUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            selectedItemContainer = new System.Windows.Forms.GroupBox();
            progressBox = new System.Windows.Forms.ComboBox();
            scoreBox = new System.Windows.Forms.NumericUpDown();
            dateBox = new System.Windows.Forms.DateTimePicker();
            editGameButton = new System.Windows.Forms.Button();
            nameBox = new System.Windows.Forms.TextBox();
            scoreLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            progressLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            gameListView = new System.Windows.Forms.ListView();
            id = new System.Windows.Forms.ColumnHeader();
            name = new System.Windows.Forms.ColumnHeader();
            date = new System.Windows.Forms.ColumnHeader();
            progress = new System.Windows.Forms.ColumnHeader();
            score = new System.Windows.Forms.ColumnHeader();
            addGameButton = new System.Windows.Forms.Button();
            gameNameBox = new System.Windows.Forms.TextBox();
            gameManagerMenu = new System.Windows.Forms.MenuStrip();
            showShortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel1.SuspendLayout();
            selectedItemContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoreBox).BeginInit();
            gameManagerMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(selectedItemContainer);
            panel1.Controls.Add(gameListView);
            panel1.Controls.Add(addGameButton);
            panel1.Controls.Add(gameNameBox);
            panel1.Controls.Add(gameManagerMenu);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.MaximumSize = new System.Drawing.Size(772, 465);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(672, 365);
            panel1.TabIndex = 1;
            // 
            // selectedItemContainer
            // 
            selectedItemContainer.Controls.Add(progressBox);
            selectedItemContainer.Controls.Add(scoreBox);
            selectedItemContainer.Controls.Add(dateBox);
            selectedItemContainer.Controls.Add(editGameButton);
            selectedItemContainer.Controls.Add(nameBox);
            selectedItemContainer.Controls.Add(scoreLabel);
            selectedItemContainer.Controls.Add(nameLabel);
            selectedItemContainer.Controls.Add(progressLabel);
            selectedItemContainer.Controls.Add(dateLabel);
            selectedItemContainer.Location = new System.Drawing.Point(57, 263);
            selectedItemContainer.Name = "selectedItemContainer";
            selectedItemContainer.Size = new System.Drawing.Size(545, 77);
            selectedItemContainer.TabIndex = 12;
            selectedItemContainer.TabStop = false;
            selectedItemContainer.Text = "Edit selected game";
            // 
            // progressBox
            // 
            progressBox.FormattingEnabled = true;
            progressBox.Items.AddRange(new object[] { "Completed", "In progress", "To be started", "On hold" });
            progressBox.Location = new System.Drawing.Point(331, 16);
            progressBox.Name = "progressBox";
            progressBox.Size = new System.Drawing.Size(127, 23);
            progressBox.TabIndex = 6;
            progressBox.KeyDown += progressBox_KeyDown;
            // 
            // scoreBox
            // 
            scoreBox.Location = new System.Drawing.Point(331, 45);
            scoreBox.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            scoreBox.Name = "scoreBox";
            scoreBox.Size = new System.Drawing.Size(127, 23);
            scoreBox.TabIndex = 7;
            scoreBox.KeyDown += scoreBox_KeyDown;
            // 
            // dateBox
            // 
            dateBox.Location = new System.Drawing.Point(52, 45);
            dateBox.Name = "dateBox";
            dateBox.Size = new System.Drawing.Size(200, 23);
            dateBox.TabIndex = 5;
            dateBox.KeyDown += dateBox_KeyDown;
            // 
            // editGameButton
            // 
            editGameButton.Location = new System.Drawing.Point(470, 16);
            editGameButton.Name = "editGameButton";
            editGameButton.Size = new System.Drawing.Size(69, 52);
            editGameButton.TabIndex = 8;
            editGameButton.Text = "Save";
            editGameButton.UseVisualStyleBackColor = true;
            editGameButton.Click += editGameButton_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new System.Drawing.Point(52, 16);
            nameBox.Name = "nameBox";
            nameBox.Size = new System.Drawing.Size(200, 23);
            nameBox.TabIndex = 4;
            nameBox.KeyDown += nameBox_KeyDown;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(273, 48);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(36, 15);
            scoreLabel.TabIndex = 11;
            scoreLabel.Text = "Score";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 19);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(39, 15);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name";
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new System.Drawing.Point(273, 19);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new System.Drawing.Size(52, 15);
            progressLabel.TabIndex = 10;
            progressLabel.Text = "Progress";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(6, 48);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 15);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date";
            // 
            // gameListView
            // 
            gameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { id, name, date, progress, score });
            gameListView.FullRowSelect = true;
            gameListView.GridLines = true;
            gameListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            gameListView.Location = new System.Drawing.Point(57, 90);
            gameListView.MaximumSize = new System.Drawing.Size(600, 300);
            gameListView.MultiSelect = false;
            gameListView.Name = "gameListView";
            gameListView.RightToLeftLayout = true;
            gameListView.Size = new System.Drawing.Size(545, 167);
            gameListView.TabIndex = 3;
            gameListView.UseCompatibleStateImageBehavior = false;
            gameListView.View = System.Windows.Forms.View.Details;
            gameListView.SelectedIndexChanged += gameListView_SelectedIndexChanged;
            gameListView.Enter += gameListView_Enter;
            gameListView.KeyDown += gameListView_KeyDown;
            // 
            // id
            // 
            id.Name = "id";
            id.Text = "ID";
            id.Width = 30;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 250;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 90;
            // 
            // progress
            // 
            progress.Text = "Progress";
            progress.Width = 90;
            // 
            // score
            // 
            score.Text = "Score";
            // 
            // addGameButton
            // 
            addGameButton.Location = new System.Drawing.Point(527, 35);
            addGameButton.Name = "addGameButton";
            addGameButton.Size = new System.Drawing.Size(75, 23);
            addGameButton.TabIndex = 2;
            addGameButton.Text = "Add game";
            addGameButton.UseVisualStyleBackColor = true;
            addGameButton.Click += addGameButton_Click;
            // 
            // gameNameBox
            // 
            gameNameBox.Location = new System.Drawing.Point(57, 35);
            gameNameBox.Name = "gameNameBox";
            gameNameBox.Size = new System.Drawing.Size(464, 23);
            gameNameBox.TabIndex = 1;
            gameNameBox.KeyDown += gameNameBox_KeyDown;
            // 
            // gameManagerMenu
            // 
            gameManagerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { showShortcutsToolStripMenuItem, settingsToolStripMenuItem, clearDatabaseToolStripMenuItem });
            gameManagerMenu.Location = new System.Drawing.Point(0, 0);
            gameManagerMenu.Name = "gameManagerMenu";
            gameManagerMenu.Size = new System.Drawing.Size(672, 24);
            gameManagerMenu.TabIndex = 13;
            gameManagerMenu.Text = "gameManagerMenu";
            // 
            // showShortcutsToolStripMenuItem
            // 
            showShortcutsToolStripMenuItem.Name = "showShortcutsToolStripMenuItem";
            showShortcutsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            showShortcutsToolStripMenuItem.Text = "Show shortcuts";
            showShortcutsToolStripMenuItem.Click += showShortcutsToolStripMenuItem_Click;
            // 
            // clearDatabaseToolStripMenuItem
            // 
            clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            clearDatabaseToolStripMenuItem.Text = "Clear database";
            clearDatabaseToolStripMenuItem.Click += clearDatabaseToolStripMenuItem_Click;
            // 
            // GameManagerUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(696, 388);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MainMenuStrip = gameManagerMenu;
            Name = "GameManagerUI";
            Text = "Game Manager v2";
            Load += GameManagerUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            selectedItemContainer.ResumeLayout(false);
            selectedItemContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scoreBox).EndInit();
            gameManagerMenu.ResumeLayout(false);
            gameManagerMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gameNameBox;
        private System.Windows.Forms.ListView gameListView;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox selectedItemContainer;
        private System.Windows.Forms.Button editGameButton;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.NumericUpDown scoreBox;
        private System.Windows.Forms.ComboBox progressBox;
        private System.Windows.Forms.MenuStrip gameManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem showShortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

