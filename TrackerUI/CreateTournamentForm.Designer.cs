namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            createTournamentLabel = new Label();
            tournamentName = new Label();
            tournamentNameTextBox = new TextBox();
            teamTwoTextBox = new TextBox();
            entryFee = new Label();
            selectTeamLabel = new Label();
            selectTeamDropdown = new ComboBox();
            createNewTeamLabel = new LinkLabel();
            addTeamButton = new Button();
            tournamentPlayerListLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            priceListBox = new ListBox();
            prizeListLabel = new Label();
            deleteTeamSelectedButton = new Button();
            deletePriceSelectedButton = new Button();
            priceButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            createTournamentLabel.Location = new Point(30, 25);
            createTournamentLabel.Margin = new Padding(5, 0, 5, 0);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(301, 47);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(30, 90);
            tournamentName.Margin = new Padding(5, 0, 5, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(245, 37);
            tournamentName.TabIndex = 3;
            tournamentName.Text = "Tournament Name";
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Location = new Point(30, 133);
            tournamentNameTextBox.Margin = new Padding(5, 6, 5, 6);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(350, 35);
            tournamentNameTextBox.TabIndex = 4;
            // 
            // teamTwoTextBox
            // 
            teamTwoTextBox.BorderStyle = BorderStyle.FixedSingle;
            teamTwoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoTextBox.Location = new Point(171, 182);
            teamTwoTextBox.Margin = new Padding(5, 6, 5, 6);
            teamTwoTextBox.Name = "teamTwoTextBox";
            teamTwoTextBox.Size = new Size(120, 29);
            teamTwoTextBox.TabIndex = 13;
            teamTwoTextBox.Text = "0";
            // 
            // entryFee
            // 
            entryFee.AutoSize = true;
            entryFee.BackColor = Color.Transparent;
            entryFee.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFee.ForeColor = SystemColors.MenuHighlight;
            entryFee.Location = new Point(30, 174);
            entryFee.Margin = new Padding(5, 0, 5, 0);
            entryFee.Name = "entryFee";
            entryFee.Size = new Size(131, 37);
            entryFee.TabIndex = 12;
            entryFee.Text = "Entry Fee:";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.BackColor = Color.Transparent;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(30, 241);
            selectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 16;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropdown
            // 
            selectTeamDropdown.FormattingEnabled = true;
            selectTeamDropdown.Location = new Point(30, 281);
            selectTeamDropdown.Name = "selectTeamDropdown";
            selectTeamDropdown.Size = new Size(350, 38);
            selectTeamDropdown.TabIndex = 17;
            // 
            // createNewTeamLabel
            // 
            createNewTeamLabel.AutoSize = true;
            createNewTeamLabel.Location = new Point(213, 248);
            createNewTeamLabel.Name = "createNewTeamLabel";
            createNewTeamLabel.Size = new Size(167, 30);
            createNewTeamLabel.TabIndex = 18;
            createNewTeamLabel.TabStop = true;
            createNewTeamLabel.Text = "create new team";
            // 
            // addTeamButton
            // 
            addTeamButton.Cursor = Cursors.Hand;
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(104, 339);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(202, 41);
            addTeamButton.TabIndex = 19;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // tournamentPlayerListLabel
            // 
            tournamentPlayerListLabel.AutoSize = true;
            tournamentPlayerListLabel.BackColor = Color.Transparent;
            tournamentPlayerListLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayerListLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayerListLabel.Location = new Point(415, 90);
            tournamentPlayerListLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentPlayerListLabel.Name = "tournamentPlayerListLabel";
            tournamentPlayerListLabel.Size = new Size(176, 37);
            tournamentPlayerListLabel.TabIndex = 21;
            tournamentPlayerListLabel.Text = "Team / Player";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(415, 133);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(250, 122);
            tournamentPlayersListBox.TabIndex = 22;
            // 
            // priceListBox
            // 
            priceListBox.BorderStyle = BorderStyle.FixedSingle;
            priceListBox.FormattingEnabled = true;
            priceListBox.ItemHeight = 30;
            priceListBox.Location = new Point(415, 324);
            priceListBox.Name = "priceListBox";
            priceListBox.Size = new Size(250, 122);
            priceListBox.TabIndex = 24;
            // 
            // prizeListLabel
            // 
            prizeListLabel.AutoSize = true;
            prizeListLabel.BackColor = Color.Transparent;
            prizeListLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeListLabel.ForeColor = SystemColors.MenuHighlight;
            prizeListLabel.Location = new Point(415, 281);
            prizeListLabel.Margin = new Padding(5, 0, 5, 0);
            prizeListLabel.Name = "prizeListLabel";
            prizeListLabel.Size = new Size(176, 37);
            prizeListLabel.TabIndex = 23;
            prizeListLabel.Text = "Team / Player";
            // 
            // deleteTeamSelectedButton
            // 
            deleteTeamSelectedButton.Cursor = Cursors.Hand;
            deleteTeamSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deleteTeamSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteTeamSelectedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteTeamSelectedButton.FlatStyle = FlatStyle.Flat;
            deleteTeamSelectedButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteTeamSelectedButton.ForeColor = SystemColors.MenuHighlight;
            deleteTeamSelectedButton.Location = new Point(701, 156);
            deleteTeamSelectedButton.Name = "deleteTeamSelectedButton";
            deleteTeamSelectedButton.Size = new Size(100, 70);
            deleteTeamSelectedButton.TabIndex = 25;
            deleteTeamSelectedButton.Text = "Delete Selected";
            deleteTeamSelectedButton.UseVisualStyleBackColor = true;
            // 
            // deletePriceSelectedButton
            // 
            deletePriceSelectedButton.Cursor = Cursors.Hand;
            deletePriceSelectedButton.FlatAppearance.BorderColor = Color.Silver;
            deletePriceSelectedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deletePriceSelectedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deletePriceSelectedButton.FlatStyle = FlatStyle.Flat;
            deletePriceSelectedButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deletePriceSelectedButton.ForeColor = SystemColors.MenuHighlight;
            deletePriceSelectedButton.Location = new Point(701, 340);
            deletePriceSelectedButton.Name = "deletePriceSelectedButton";
            deletePriceSelectedButton.Size = new Size(100, 70);
            deletePriceSelectedButton.TabIndex = 26;
            deletePriceSelectedButton.Text = "Delete Selected";
            deletePriceSelectedButton.UseVisualStyleBackColor = true;
            // 
            // priceButton
            // 
            priceButton.Cursor = Cursors.Hand;
            priceButton.FlatAppearance.BorderColor = Color.Silver;
            priceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            priceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            priceButton.FlatStyle = FlatStyle.Flat;
            priceButton.ForeColor = SystemColors.MenuHighlight;
            priceButton.Location = new Point(104, 405);
            priceButton.Name = "priceButton";
            priceButton.Size = new Size(202, 41);
            priceButton.TabIndex = 20;
            priceButton.Text = "Create Prize";
            priceButton.UseVisualStyleBackColor = true;
            priceButton.Click += priceButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Cursor = Cursors.Hand;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(300, 500);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(202, 41);
            createTournamentButton.TabIndex = 27;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 561);
            Controls.Add(createTournamentButton);
            Controls.Add(deletePriceSelectedButton);
            Controls.Add(deleteTeamSelectedButton);
            Controls.Add(priceListBox);
            Controls.Add(prizeListLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(tournamentPlayerListLabel);
            Controls.Add(priceButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLabel);
            Controls.Add(selectTeamDropdown);
            Controls.Add(selectTeamLabel);
            Controls.Add(teamTwoTextBox);
            Controls.Add(entryFee);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(tournamentName);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentName;
        private TextBox tournamentNameTextBox;
        private TextBox teamTwoTextBox;
        private Label entryFee;
        private Label selectTeamLabel;
        private ComboBox selectTeamDropdown;
        private LinkLabel createNewTeamLabel;
        private Button addTeamButton;
        private Label tournamentPlayerListLabel;
        private ListBox tournamentPlayersListBox;
        private ListBox priceListBox;
        private Label prizeListLabel;
        private Button deleteTeamSelectedButton;
        private Button deletePriceSelectedButton;
        private Button priceButton;
        private Button createTournamentButton;
    }
}