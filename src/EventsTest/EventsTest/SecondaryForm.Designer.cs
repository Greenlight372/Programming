namespace EventsTest
{
    partial class SecondaryForm
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
            mainPanel = new Panel();
            closeButton = new Button();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            fullnameTextBox = new TextBox();
            fullnameLabel = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(closeButton);
            mainPanel.Controls.Add(addressTextBox);
            mainPanel.Controls.Add(addressLabel);
            mainPanel.Controls.Add(phoneNumberTextBox);
            mainPanel.Controls.Add(phoneNumberLabel);
            mainPanel.Controls.Add(fullnameTextBox);
            mainPanel.Controls.Add(fullnameLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(272, 249);
            mainPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.Location = new Point(185, 214);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 6;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 115);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(248, 23);
            addressTextBox.TabIndex = 5;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 97);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 4;
            addressLabel.Text = "Address:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextBox.Location = new Point(12, 71);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(248, 23);
            phoneNumberTextBox.TabIndex = 3;
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 53);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullnameTextBox.Location = new Point(12, 27);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(248, 23);
            fullnameTextBox.TabIndex = 1;
            fullnameTextBox.TextChanged += fullnameTextBox_TextChanged;
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(12, 9);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(59, 15);
            fullnameLabel.TabIndex = 0;
            fullnameLabel.Text = "Fullname:";
            // 
            // SecondaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 249);
            Controls.Add(mainPanel);
            Name = "SecondaryForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secondary Window";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button closeButton;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox fullnameTextBox;
        private Label fullnameLabel;
    }
}