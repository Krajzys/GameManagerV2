namespace GameManagerV2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedItemContainer = new System.Windows.Forms.GroupBox();
            this.editGameButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.progressBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.progressLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.gameListView = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.progress = new System.Windows.Forms.ColumnHeader();
            this.score = new System.Windows.Forms.ColumnHeader();
            this.addGameButton = new System.Windows.Forms.Button();
            this.gameNameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.selectedItemContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedItemContainer);
            this.panel1.Controls.Add(this.gameListView);
            this.panel1.Controls.Add(this.addGameButton);
            this.panel1.Controls.Add(this.gameNameBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 365);
            this.panel1.TabIndex = 1;
            // 
            // selectedItemContainer
            // 
            this.selectedItemContainer.Controls.Add(this.editGameButton);
            this.selectedItemContainer.Controls.Add(this.nameBox);
            this.selectedItemContainer.Controls.Add(this.scoreBox);
            this.selectedItemContainer.Controls.Add(this.scoreLabel);
            this.selectedItemContainer.Controls.Add(this.progressBox);
            this.selectedItemContainer.Controls.Add(this.nameLabel);
            this.selectedItemContainer.Controls.Add(this.progressLabel);
            this.selectedItemContainer.Controls.Add(this.dateLabel);
            this.selectedItemContainer.Controls.Add(this.dateBox);
            this.selectedItemContainer.Location = new System.Drawing.Point(57, 263);
            this.selectedItemContainer.Name = "selectedItemContainer";
            this.selectedItemContainer.Size = new System.Drawing.Size(545, 77);
            this.selectedItemContainer.TabIndex = 12;
            this.selectedItemContainer.TabStop = false;
            this.selectedItemContainer.Text = "Edit selected game";
            // 
            // editGameButton
            // 
            this.editGameButton.Location = new System.Drawing.Point(470, 16);
            this.editGameButton.Name = "editGameButton";
            this.editGameButton.Size = new System.Drawing.Size(69, 52);
            this.editGameButton.TabIndex = 13;
            this.editGameButton.Text = "Save";
            this.editGameButton.UseVisualStyleBackColor = true;
            this.editGameButton.Click += new System.EventHandler(this.editGameButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(52, 16);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 23);
            this.nameBox.TabIndex = 4;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBox_KeyDown);
            // 
            // scoreBox
            // 
            this.scoreBox.Location = new System.Drawing.Point(331, 45);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(127, 23);
            this.scoreBox.TabIndex = 7;
            this.scoreBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.scoreBox_KeyDown);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(273, 48);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(36, 15);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Score";
            // 
            // progressBox
            // 
            this.progressBox.Location = new System.Drawing.Point(331, 16);
            this.progressBox.Name = "progressBox";
            this.progressBox.Size = new System.Drawing.Size(127, 23);
            this.progressBox.TabIndex = 6;
            this.progressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.progressBox_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name";
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(273, 19);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(52, 15);
            this.progressLabel.TabIndex = 10;
            this.progressLabel.Text = "Progress";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(6, 48);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 15);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(52, 45);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 23);
            this.dateBox.TabIndex = 5;
            this.dateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateBox_KeyDown);
            // 
            // gameListView
            // 
            this.gameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.date,
            this.progress,
            this.score});
            this.gameListView.FullRowSelect = true;
            this.gameListView.GridLines = true;
            this.gameListView.HideSelection = false;
            this.gameListView.LabelEdit = true;
            this.gameListView.Location = new System.Drawing.Point(57, 90);
            this.gameListView.MultiSelect = false;
            this.gameListView.Name = "gameListView";
            this.gameListView.RightToLeftLayout = true;
            this.gameListView.Size = new System.Drawing.Size(545, 167);
            this.gameListView.TabIndex = 3;
            this.gameListView.UseCompatibleStateImageBehavior = false;
            this.gameListView.View = System.Windows.Forms.View.Details;
            this.gameListView.SelectedIndexChanged += new System.EventHandler(this.gameListView_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Text = "ID";
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 250;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 90;
            // 
            // progress
            // 
            this.progress.Text = "Progress";
            this.progress.Width = 90;
            // 
            // score
            // 
            this.score.Text = "Score";
            // 
            // addGameButton
            // 
            this.addGameButton.Location = new System.Drawing.Point(527, 35);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(75, 23);
            this.addGameButton.TabIndex = 2;
            this.addGameButton.Text = "Add game";
            this.addGameButton.UseVisualStyleBackColor = true;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // gameNameBox
            // 
            this.gameNameBox.Location = new System.Drawing.Point(57, 35);
            this.gameNameBox.Name = "gameNameBox";
            this.gameNameBox.Size = new System.Drawing.Size(464, 23);
            this.gameNameBox.TabIndex = 1;
            this.gameNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameNameBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(704, 388);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Game Manager v2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectedItemContainer.ResumeLayout(false);
            this.selectedItemContainer.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox progressBox;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.GroupBox selectedItemContainer;
        private System.Windows.Forms.Button editGameButton;
    }
}

