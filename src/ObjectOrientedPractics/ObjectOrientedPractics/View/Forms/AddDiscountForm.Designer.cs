namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
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
            percentDiscountLabel = new Label();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // percentDiscountLabel
            // 
            percentDiscountLabel.AutoSize = true;
            percentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            percentDiscountLabel.Location = new Point(12, 9);
            percentDiscountLabel.Name = "percentDiscountLabel";
            percentDiscountLabel.Size = new Size(106, 15);
            percentDiscountLabel.TabIndex = 0;
            percentDiscountLabel.Text = "Percent Discount:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 44);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(76, 44);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(216, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Location = new Point(140, 82);
            okButton.Name = "okButton";
            okButton.Size = new Size(73, 35);
            okButton.TabIndex = 3;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(219, 82);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 35);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 129);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(percentDiscountLabel);
            MinimumSize = new Size(320, 168);
            Name = "AddDiscountForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label percentDiscountLabel;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Button okButton;
        private Button cancelButton;
    }
}