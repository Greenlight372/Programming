namespace Programming
{
    partial class MainForm
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
            this.EnumsTabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.SeasonHandle = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsing = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingResult = new System.Windows.Forms.Label();
            this.WeekdayButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.Enums);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(584, 441);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonHandle);
            this.Enums.Controls.Add(this.WeekdayParsing);
            this.Enums.Controls.Add(this.Enumerations);
            this.Enums.Location = new System.Drawing.Point(4, 24);
            this.Enums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enums.Size = new System.Drawing.Size(576, 413);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.SeasonButton);
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.SeasonLabel);
            this.SeasonHandle.Location = new System.Drawing.Point(297, 225);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Size = new System.Drawing.Size(271, 180);
            this.SeasonHandle.TabIndex = 4;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(170, 38);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 37);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(159, 23);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(3, 19);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.WeekdayParsingResult);
            this.WeekdayParsing.Controls.Add(this.WeekdayButton);
            this.WeekdayParsing.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsing.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsing.Location = new System.Drawing.Point(6, 225);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Size = new System.Drawing.Size(285, 183);
            this.WeekdayParsing.TabIndex = 2;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingResult
            // 
            this.WeekdayParsingResult.AutoSize = true;
            this.WeekdayParsingResult.Location = new System.Drawing.Point(7, 63);
            this.WeekdayParsingResult.Name = "WeekdayParsingResult";
            this.WeekdayParsingResult.Size = new System.Drawing.Size(0, 15);
            this.WeekdayParsingResult.TabIndex = 3;
            // 
            // WeekdayButton
            // 
            this.WeekdayButton.Location = new System.Drawing.Point(164, 38);
            this.WeekdayButton.Name = "WeekdayButton";
            this.WeekdayButton.Size = new System.Drawing.Size(75, 23);
            this.WeekdayButton.TabIndex = 2;
            this.WeekdayButton.Text = "Parse";
            this.WeekdayButton.UseVisualStyleBackColor = true;
            this.WeekdayButton.Click += new System.EventHandler(this.WeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(7, 37);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(151, 23);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(3, 19);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(125, 15);
            this.WeekdayLabel.TabIndex = 0;
            this.WeekdayLabel.Text = "Type value for parsing:";
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.ValueTextBox);
            this.Enumerations.Controls.Add(this.IntValueLabel);
            this.Enumerations.Controls.Add(this.ValuesListBox);
            this.Enumerations.Controls.Add(this.ValuesLabel);
            this.Enumerations.Controls.Add(this.EnumsLabel);
            this.Enumerations.Controls.Add(this.EnumsListBox);
            this.Enumerations.Location = new System.Drawing.Point(7, 4);
            this.Enumerations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enumerations.Size = new System.Drawing.Size(561, 216);
            this.Enumerations.TabIndex = 1;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(400, 54);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(100, 23);
            this.ValueTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(400, 36);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.HorizontalScrollbar = true;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(203, 53);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(151, 154);
            this.ValuesListBox.TabIndex = 5;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(203, 36);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(81, 15);
            this.ValuesLabel.TabIndex = 4;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(6, 36);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.HorizontalScrollbar = true;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufacturer",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 53);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(151, 154);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.EnumsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.EnumsTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Enums;
        private GroupBox Enumerations;
        private Label IntValueLabel;
        private ListBox ValuesListBox;
        private Label ValuesLabel;
        private Label EnumsLabel;
        public ListBox EnumsListBox;
        private TextBox ValueTextBox;
        private GroupBox WeekdayParsing;
        private Label WeekdayParsingResult;
        private Button WeekdayButton;
        private TextBox WeekdayTextBox;
        private Label WeekdayLabel;
        private GroupBox SeasonHandle;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private Button SeasonButton;
    }
}