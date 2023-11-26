namespace TrackerUI
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropdown = new ComboBox();
            unplayedCheckBox = new CheckBox();
            matchUpListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneTextBox = new TextBox();
            teamTwoTextBox = new TextBox();
            teamTwoScore = new Label();
            teamTwoLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(30, 25);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(250, 25);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.BackColor = Color.Transparent;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(47, 84);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            roundDropdown.FormattingEnabled = true;
            roundDropdown.Location = new Point(167, 83);
            roundDropdown.Name = "roundDropdown";
            roundDropdown.Size = new Size(233, 38);
            roundDropdown.TabIndex = 3;
            // 
            // unplayedCheckBox
            // 
            unplayedCheckBox.AutoSize = true;
            unplayedCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedCheckBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedCheckBox.ForeColor = Color.FromArgb(51, 152, 255);
            unplayedCheckBox.Location = new Point(167, 144);
            unplayedCheckBox.Name = "unplayedCheckBox";
            unplayedCheckBox.Size = new Size(209, 41);
            unplayedCheckBox.TabIndex = 4;
            unplayedCheckBox.Text = "Unplayed Only";
            unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            matchUpListBox.BorderStyle = BorderStyle.FixedSingle;
            matchUpListBox.FormattingEnabled = true;
            matchUpListBox.ItemHeight = 30;
            matchUpListBox.Location = new Point(32, 230);
            matchUpListBox.Name = "matchUpListBox";
            matchUpListBox.Size = new Size(368, 272);
            matchUpListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.BackColor = Color.Transparent;
            teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(436, 230);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.BackColor = Color.Transparent;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = SystemColors.MenuHighlight;
            teamOneScoreLabel.Location = new Point(436, 286);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(88, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score:";
            teamOneScoreLabel.Click += label1_Click_1;
            // 
            // teamOneTextBox
            // 
            teamOneTextBox.BorderStyle = BorderStyle.FixedSingle;
            teamOneTextBox.Location = new Point(524, 288);
            teamOneTextBox.Name = "teamOneTextBox";
            teamOneTextBox.Size = new Size(100, 35);
            teamOneTextBox.TabIndex = 8;
            // 
            // teamTwoTextBox
            // 
            teamTwoTextBox.BorderStyle = BorderStyle.FixedSingle;
            teamTwoTextBox.Location = new Point(524, 464);
            teamTwoTextBox.Name = "teamTwoTextBox";
            teamTwoTextBox.Size = new Size(100, 35);
            teamTwoTextBox.TabIndex = 11;
            // 
            // teamTwoScore
            // 
            teamTwoScore.AutoSize = true;
            teamTwoScore.BackColor = Color.Transparent;
            teamTwoScore.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScore.ForeColor = SystemColors.MenuHighlight;
            teamTwoScore.Location = new Point(436, 462);
            teamTwoScore.Name = "teamTwoScore";
            teamTwoScore.Size = new Size(88, 37);
            teamTwoScore.TabIndex = 10;
            teamTwoScore.Text = "Score:";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.BackColor = Color.Transparent;
            teamTwoLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = SystemColors.MenuHighlight;
            teamTwoLabel.Location = new Point(436, 406);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(165, 37);
            teamTwoLabel.TabIndex = 9;
            teamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.BackColor = Color.Transparent;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = SystemColors.MenuHighlight;
            versusLabel.Location = new Point(491, 349);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 37);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Cursor = Cursors.Hand;
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(636, 350);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(125, 41);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += scoreButton_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 561);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoTextBox);
            Controls.Add(teamTwoScore);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneTextBox);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchUpListBox);
            Controls.Add(unplayedCheckBox);
            Controls.Add(roundDropdown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropdown;
        private CheckBox unplayedCheckBox;
        private ListBox matchUpListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneTextBox;
        private TextBox teamTwoTextBox;
        private Label teamTwoScore;
        private Label teamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}