namespace TrackerUI
{
    partial class CreateTeamForm
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
            createTeamLabel = new Label();
            teamNameLabel = new Label();
            teamNameTextBox = new TextBox();
            selectTeamMemLabel = new Label();
            selectTeamMemDropdown = new ComboBox();
            addMemberButton = new Button();
            addTeamMemGroupBox = new GroupBox();
            createMemButton = new Button();
            phoneNumTextBox = new TextBox();
            phoneNumLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            teamMemListBox = new ListBox();
            teamMemListDelButton = new Button();
            createTeamButton = new Button();
            addTeamMemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(30, 25);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(202, 47);
            createTeamLabel.TabIndex = 0;
            createTeamLabel.Text = "Create Team";
            createTeamLabel.Click += createTeamLabel_Click;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(30, 90);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(142, 32);
            teamNameLabel.TabIndex = 1;
            teamNameLabel.Text = "Team Name";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            teamNameTextBox.Location = new Point(30, 125);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(350, 35);
            teamNameTextBox.TabIndex = 2;
            // 
            // selectTeamMemLabel
            // 
            selectTeamMemLabel.AutoSize = true;
            selectTeamMemLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamMemLabel.Location = new Point(30, 180);
            selectTeamMemLabel.Name = "selectTeamMemLabel";
            selectTeamMemLabel.Size = new Size(240, 32);
            selectTeamMemLabel.TabIndex = 3;
            selectTeamMemLabel.Text = "Select Team Member";
            // 
            // selectTeamMemDropdown
            // 
            selectTeamMemDropdown.FormattingEnabled = true;
            selectTeamMemDropdown.Location = new Point(30, 215);
            selectTeamMemDropdown.Name = "selectTeamMemDropdown";
            selectTeamMemDropdown.Size = new Size(350, 38);
            selectTeamMemDropdown.TabIndex = 4;
            // 
            // addMemberButton
            // 
            addMemberButton.Cursor = Cursors.Hand;
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(81, 270);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(202, 41);
            addMemberButton.TabIndex = 20;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addTeamMemGroupBox
            // 
            addTeamMemGroupBox.Controls.Add(createMemButton);
            addTeamMemGroupBox.Controls.Add(phoneNumTextBox);
            addTeamMemGroupBox.Controls.Add(phoneNumLabel);
            addTeamMemGroupBox.Controls.Add(emailTextBox);
            addTeamMemGroupBox.Controls.Add(emailLabel);
            addTeamMemGroupBox.Controls.Add(lastNameTextBox);
            addTeamMemGroupBox.Controls.Add(lastNameLabel);
            addTeamMemGroupBox.Controls.Add(firstNameTextBox);
            addTeamMemGroupBox.Controls.Add(firstNameLabel);
            addTeamMemGroupBox.ForeColor = SystemColors.MenuHighlight;
            addTeamMemGroupBox.Location = new Point(30, 343);
            addTeamMemGroupBox.Name = "addTeamMemGroupBox";
            addTeamMemGroupBox.Size = new Size(350, 300);
            addTeamMemGroupBox.TabIndex = 21;
            addTeamMemGroupBox.TabStop = false;
            addTeamMemGroupBox.Text = "Add Team Members";
            // 
            // createMemButton
            // 
            createMemButton.Cursor = Cursors.Hand;
            createMemButton.FlatAppearance.BorderColor = Color.Silver;
            createMemButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemButton.FlatStyle = FlatStyle.Flat;
            createMemButton.ForeColor = SystemColors.MenuHighlight;
            createMemButton.Location = new Point(74, 253);
            createMemButton.Name = "createMemButton";
            createMemButton.Size = new Size(202, 41);
            createMemButton.TabIndex = 21;
            createMemButton.Text = "Create Member";
            createMemButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumTextBox
            // 
            phoneNumTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumTextBox.Location = new Point(144, 186);
            phoneNumTextBox.Name = "phoneNumTextBox";
            phoneNumTextBox.Size = new Size(196, 35);
            phoneNumTextBox.TabIndex = 9;
            phoneNumTextBox.TextChanged += phoneNumTextBox_TextChanged;
            // 
            // phoneNumLabel
            // 
            phoneNumLabel.AutoSize = true;
            phoneNumLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumLabel.ForeColor = SystemColors.MenuHighlight;
            phoneNumLabel.Location = new Point(6, 189);
            phoneNumLabel.Name = "phoneNumLabel";
            phoneNumLabel.Size = new Size(126, 32);
            phoneNumLabel.TabIndex = 8;
            phoneNumLabel.Text = "Phone No:";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(144, 145);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(196, 35);
            emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(6, 148);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(76, 32);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(144, 104);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(196, 35);
            lastNameTextBox.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(6, 107);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(131, 32);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(144, 63);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(196, 35);
            firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(4, 66);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(134, 32);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First Name:";
            // 
            // teamMemListBox
            // 
            teamMemListBox.FormattingEnabled = true;
            teamMemListBox.ItemHeight = 30;
            teamMemListBox.Location = new Point(405, 126);
            teamMemListBox.Name = "teamMemListBox";
            teamMemListBox.Size = new Size(300, 514);
            teamMemListBox.TabIndex = 22;
            // 
            // teamMemListDelButton
            // 
            teamMemListDelButton.Cursor = Cursors.Hand;
            teamMemListDelButton.FlatAppearance.BorderColor = Color.Silver;
            teamMemListDelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            teamMemListDelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            teamMemListDelButton.FlatStyle = FlatStyle.Flat;
            teamMemListDelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamMemListDelButton.ForeColor = SystemColors.MenuHighlight;
            teamMemListDelButton.Location = new Point(722, 343);
            teamMemListDelButton.Name = "teamMemListDelButton";
            teamMemListDelButton.Size = new Size(100, 80);
            teamMemListDelButton.TabIndex = 23;
            teamMemListDelButton.Text = "Delete Selected";
            teamMemListDelButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            createTeamButton.Cursor = Cursors.Hand;
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(316, 658);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(202, 41);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(834, 711);
            Controls.Add(createTeamButton);
            Controls.Add(teamMemListDelButton);
            Controls.Add(teamMemListBox);
            Controls.Add(addTeamMemGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemDropdown);
            Controls.Add(selectTeamMemLabel);
            Controls.Add(teamNameTextBox);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            addTeamMemGroupBox.ResumeLayout(false);
            addTeamMemGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTeamLabel;
        private Label teamNameLabel;
        private TextBox teamNameTextBox;
        private Label selectTeamMemLabel;
        private ComboBox selectTeamMemDropdown;
        private Button addMemberButton;
        private GroupBox addTeamMemGroupBox;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Button createMemButton;
        private TextBox phoneNumTextBox;
        private Label phoneNumLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private ListBox teamMemListBox;
        private Button teamMemListDelButton;
        private Button createTeamButton;
    }
}