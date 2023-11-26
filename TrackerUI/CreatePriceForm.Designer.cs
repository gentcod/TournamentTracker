namespace TrackerUI
{
    partial class CreatePriceForm
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
            placeNumberTextBox = new TextBox();
            placeNumberLabel = new Label();
            createTeamLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            orLabel = new Label();
            prizePercentTextBox = new TextBox();
            prizePercentageLabel = new Label();
            createPriceButton = new Button();
            SuspendLayout();
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            placeNumberTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberTextBox.Location = new Point(250, 119);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(196, 33);
            placeNumberTextBox.TabIndex = 11;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(60, 120);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(169, 32);
            placeNumberLabel.TabIndex = 10;
            placeNumberLabel.Text = "Place Number:";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(30, 25);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(202, 47);
            createTeamLabel.TabIndex = 16;
            createTeamLabel.Text = "Create Team";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            placeNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameTextBox.Location = new Point(250, 172);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(196, 33);
            placeNameTextBox.TabIndex = 18;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(60, 173);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(145, 32);
            placeNameLabel.TabIndex = 17;
            placeNameLabel.Text = "Place Name:";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizeAmountTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountTextBox.Location = new Point(250, 225);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(196, 33);
            prizeAmountTextBox.TabIndex = 20;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(60, 226);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(163, 32);
            prizeAmountLabel.TabIndex = 19;
            prizeAmountLabel.Text = "Prize Amount:";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(215, 289);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(56, 32);
            orLabel.TabIndex = 21;
            orLabel.Text = "-or-";
            // 
            // prizePercentTextBox
            // 
            prizePercentTextBox.BorderStyle = BorderStyle.FixedSingle;
            prizePercentTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentTextBox.Location = new Point(250, 345);
            prizePercentTextBox.Name = "prizePercentTextBox";
            prizePercentTextBox.Size = new Size(196, 33);
            prizePercentTextBox.TabIndex = 23;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(60, 346);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(195, 32);
            prizePercentageLabel.TabIndex = 22;
            prizePercentageLabel.Text = "Prize Percentage:";
            // 
            // createPriceButton
            // 
            createPriceButton.Cursor = Cursors.Hand;
            createPriceButton.FlatAppearance.BorderColor = Color.Silver;
            createPriceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPriceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPriceButton.FlatStyle = FlatStyle.Flat;
            createPriceButton.ForeColor = SystemColors.MenuHighlight;
            createPriceButton.Location = new Point(139, 430);
            createPriceButton.Name = "createPriceButton";
            createPriceButton.Size = new Size(200, 50);
            createPriceButton.TabIndex = 25;
            createPriceButton.Text = "Create Price";
            createPriceButton.UseVisualStyleBackColor = true;
            createPriceButton.Click += createPriceButton_Click;
            // 
            // CreatePriceForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 511);
            Controls.Add(createPriceButton);
            Controls.Add(prizePercentTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(orLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(createTeamLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(placeNumberLabel);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CreatePriceForm";
            Text = "Create Price";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox placeNumberTextBox;
        private Label placeNumberLabel;
        private Label createTeamLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private Label orLabel;
        private TextBox prizePercentTextBox;
        private Label prizePercentageLabel;
        private Button createPriceButton;
    }
}