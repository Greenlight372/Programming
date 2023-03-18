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
            this.Classes = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RectangleGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.Classes.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectangleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.Enums);
            this.EnumsTabControl.Controls.Add(this.Classes);
            this.EnumsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsTabControl.Location = new System.Drawing.Point(0, 0);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.SelectedIndex = 0;
            this.EnumsTabControl.Size = new System.Drawing.Size(667, 588);
            this.EnumsTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.SeasonHandle);
            this.Enums.Controls.Add(this.WeekdayParsing);
            this.Enums.Controls.Add(this.Enumerations);
            this.Enums.Location = new System.Drawing.Point(4, 29);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(659, 555);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonHandle.AutoSize = true;
            this.SeasonHandle.Controls.Add(this.SeasonButton);
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.SeasonLabel);
            this.SeasonHandle.Location = new System.Drawing.Point(339, 315);
            this.SeasonHandle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonHandle.Size = new System.Drawing.Size(310, 225);
            this.SeasonHandle.TabIndex = 4;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(195, 48);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(86, 31);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(7, 49);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(181, 28);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(3, 25);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.SeasonLabel.TabIndex = 0;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WeekdayParsing.AutoSize = true;
            this.WeekdayParsing.Controls.Add(this.WeekdayParsingResult);
            this.WeekdayParsing.Controls.Add(this.WeekdayButton);
            this.WeekdayParsing.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsing.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsing.Location = new System.Drawing.Point(7, 315);
            this.WeekdayParsing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekdayParsing.Size = new System.Drawing.Size(326, 229);
            this.WeekdayParsing.TabIndex = 2;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingResult
            // 
            this.WeekdayParsingResult.AutoSize = true;
            this.WeekdayParsingResult.Location = new System.Drawing.Point(8, 84);
            this.WeekdayParsingResult.Name = "WeekdayParsingResult";
            this.WeekdayParsingResult.Size = new System.Drawing.Size(0, 20);
            this.WeekdayParsingResult.TabIndex = 3;
            // 
            // WeekdayButton
            // 
            this.WeekdayButton.Location = new System.Drawing.Point(187, 48);
            this.WeekdayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekdayButton.Name = "WeekdayButton";
            this.WeekdayButton.Size = new System.Drawing.Size(86, 31);
            this.WeekdayButton.TabIndex = 2;
            this.WeekdayButton.Text = "Parse";
            this.WeekdayButton.UseVisualStyleBackColor = true;
            this.WeekdayButton.Click += new System.EventHandler(this.WeekdayButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(8, 49);
            this.WeekdayTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(172, 27);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Location = new System.Drawing.Point(3, 25);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(158, 20);
            this.WeekdayLabel.TabIndex = 0;
            this.WeekdayLabel.Text = "Type value for parsing:";
            // 
            // Enumerations
            // 
            this.Enumerations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Enumerations.AutoSize = true;
            this.Enumerations.Controls.Add(this.ValueTextBox);
            this.Enumerations.Controls.Add(this.IntValueLabel);
            this.Enumerations.Controls.Add(this.ValuesListBox);
            this.Enumerations.Controls.Add(this.ValuesLabel);
            this.Enumerations.Controls.Add(this.EnumsLabel);
            this.Enumerations.Controls.Add(this.EnumsListBox);
            this.Enumerations.Location = new System.Drawing.Point(8, 5);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(641, 303);
            this.Enumerations.TabIndex = 1;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(457, 72);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(114, 27);
            this.ValueTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(457, 48);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.HorizontalScrollbar = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(232, 71);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(172, 204);
            this.ValuesListBox.TabIndex = 5;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(232, 48);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(100, 20);
            this.ValuesLabel.TabIndex = 4;
            this.ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(7, 48);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(149, 20);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.HorizontalScrollbar = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufacturer",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(7, 71);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(172, 204);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.MoviesGroupBox);
            this.Classes.Controls.Add(this.RectangleGroupBox);
            this.Classes.Location = new System.Drawing.Point(4, 29);
            this.Classes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Classes.Size = new System.Drawing.Size(659, 555);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesGroupBox.Controls.Add(this.ScoreTextBox);
            this.MoviesGroupBox.Controls.Add(this.ScoreLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesButton);
            this.MoviesGroupBox.Controls.Add(this.YearTextBox);
            this.MoviesGroupBox.Controls.Add(this.YearLabel);
            this.MoviesGroupBox.Controls.Add(this.DurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.DurationLabel);
            this.MoviesGroupBox.Controls.Add(this.TitleTextBox);
            this.MoviesGroupBox.Controls.Add(this.TitleLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(358, 8);
            this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoviesGroupBox.Size = new System.Drawing.Size(291, 532);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.Location = new System.Drawing.Point(169, 281);
            this.ScoreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(114, 27);
            this.ScoreTextBox.TabIndex = 11;
            this.ScoreTextBox.TextChanged += new System.EventHandler(this.ScoreTextBox_TextChanged);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(169, 257);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(49, 20);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "Score:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(169, 225);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(114, 27);
            this.GenreTextBox.TabIndex = 9;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(169, 201);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 8;
            this.GenreLabel.Text = "Genre:";
            // 
            // MoviesButton
            // 
            this.MoviesButton.Location = new System.Drawing.Point(170, 493);
            this.MoviesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(114, 31);
            this.MoviesButton.TabIndex = 1;
            this.MoviesButton.Text = "Find";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(169, 167);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(114, 27);
            this.YearTextBox.TabIndex = 7;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(169, 143);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(40, 20);
            this.YearLabel.TabIndex = 6;
            this.YearLabel.Text = "Year:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(169, 108);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(114, 27);
            this.DurationTextBox.TabIndex = 5;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(169, 84);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(70, 20);
            this.DurationLabel.TabIndex = 4;
            this.DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(169, 49);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(114, 27);
            this.TitleTextBox.TabIndex = 3;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(169, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Items.AddRange(new object[] {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5"});
            this.MoviesListBox.Location = new System.Drawing.Point(7, 29);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(137, 244);
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectangleGroupBox
            // 
            this.RectangleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleGroupBox.Controls.Add(this.RectangleButton);
            this.RectangleGroupBox.Controls.Add(this.ColorTextBox);
            this.RectangleGroupBox.Controls.Add(this.ColorLabel);
            this.RectangleGroupBox.Controls.Add(this.WidthTextBox);
            this.RectangleGroupBox.Controls.Add(this.WidthLabel);
            this.RectangleGroupBox.Controls.Add(this.LengthTextBox);
            this.RectangleGroupBox.Controls.Add(this.LengthLabel);
            this.RectangleGroupBox.Controls.Add(this.RectangleListBox);
            this.RectangleGroupBox.Location = new System.Drawing.Point(9, 8);
            this.RectangleGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangleGroupBox.Name = "RectangleGroupBox";
            this.RectangleGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangleGroupBox.Size = new System.Drawing.Size(291, 532);
            this.RectangleGroupBox.TabIndex = 0;
            this.RectangleGroupBox.TabStop = false;
            this.RectangleGroupBox.Text = "Rectangles";
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(169, 493);
            this.RectangleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(114, 31);
            this.RectangleButton.TabIndex = 1;
            this.RectangleButton.Text = "Find";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(169, 167);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(114, 27);
            this.ColorTextBox.TabIndex = 7;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(169, 143);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(169, 108);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(114, 27);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(169, 84);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 4;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(169, 49);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(114, 27);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(169, 25);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 20;
            this.RectangleListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"});
            this.RectangleListBox.Location = new System.Drawing.Point(7, 29);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(137, 244);
            this.RectangleListBox.TabIndex = 1;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(667, 588);
            this.Controls.Add(this.EnumsTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.EnumsTabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.Enums.PerformLayout();
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.Classes.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectangleGroupBox.ResumeLayout(false);
            this.RectangleGroupBox.PerformLayout();
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
        private TabPage Classes;
        private GroupBox RectangleGroupBox;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private ListBox RectangleListBox;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private Button RectangleButton;
        private GroupBox MoviesGroupBox;
        private Button MoviesButton;
        private TextBox YearTextBox;
        private Label YearLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private ListBox MoviesListBox;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox ScoreTextBox;
        private Label ScoreLabel;
    }
}