﻿namespace Programming.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EnumsTabControl = new TabControl();
            Enums = new TabPage();
            SeasonHandle = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            WeekdayParsing = new GroupBox();
            WeekdayParsingResult = new Label();
            WeekdayButton = new Button();
            WeekdayTextBox = new TextBox();
            WeekdayLabel = new Label();
            Enumerations = new GroupBox();
            ValueTextBox = new TextBox();
            IntValueLabel = new Label();
            ValuesListBox = new ListBox();
            ValuesLabel = new Label();
            EnumsLabel = new Label();
            EnumsListBox = new ListBox();
            Classes = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            MoviesGroupBox = new GroupBox();
            ScoreTextBox = new TextBox();
            ScoreLabel = new Label();
            GenreTextBox = new TextBox();
            GenreLabel = new Label();
            MoviesButton = new Button();
            YearTextBox = new TextBox();
            YearLabel = new Label();
            DurationTextBox = new TextBox();
            DurationLabel = new Label();
            TitleTextBox = new TextBox();
            TitleLabel = new Label();
            MoviesListBox = new ListBox();
            RectangleGroupBox = new GroupBox();
            RectangleButton = new Button();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            LengthTextBox = new TextBox();
            LengthLabel = new Label();
            RectangleListBox = new ListBox();
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
            SeasonHandle.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            Enumerations.SuspendLayout();
            Classes.SuspendLayout();
            MoviesGroupBox.SuspendLayout();
            RectangleGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnumsTabControl.Controls.Add(Enums);
            EnumsTabControl.Controls.Add(Classes);
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Margin = new Padding(3, 2, 3, 2);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(584, 441);
            EnumsTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(SeasonHandle);
            Enums.Controls.Add(WeekdayParsing);
            Enums.Controls.Add(Enumerations);
            Enums.Location = new Point(4, 24);
            Enums.Margin = new Padding(3, 2, 3, 2);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3, 2, 3, 2);
            Enums.Size = new Size(576, 413);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonHandle
            // 
            SeasonHandle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SeasonHandle.AutoSize = true;
            SeasonHandle.Controls.Add(SeasonButton);
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(SeasonLabel);
            SeasonHandle.Location = new Point(297, 236);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(271, 169);
            SeasonHandle.TabIndex = 4;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(171, 36);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(75, 23);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(6, 37);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(159, 23);
            SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(3, 19);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(89, 15);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeekdayParsing.AutoSize = true;
            WeekdayParsing.Controls.Add(WeekdayParsingResult);
            WeekdayParsing.Controls.Add(WeekdayButton);
            WeekdayParsing.Controls.Add(WeekdayTextBox);
            WeekdayParsing.Controls.Add(WeekdayLabel);
            WeekdayParsing.Location = new Point(6, 236);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(285, 172);
            WeekdayParsing.TabIndex = 2;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingResult
            // 
            WeekdayParsingResult.AutoSize = true;
            WeekdayParsingResult.Location = new Point(7, 63);
            WeekdayParsingResult.Name = "WeekdayParsingResult";
            WeekdayParsingResult.Size = new Size(0, 15);
            WeekdayParsingResult.TabIndex = 3;
            // 
            // WeekdayButton
            // 
            WeekdayButton.Location = new Point(164, 36);
            WeekdayButton.Name = "WeekdayButton";
            WeekdayButton.Size = new Size(75, 23);
            WeekdayButton.TabIndex = 2;
            WeekdayButton.Text = "Parse";
            WeekdayButton.UseVisualStyleBackColor = true;
            WeekdayButton.Click += WeekdayButton_Click;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(7, 37);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(151, 23);
            WeekdayTextBox.TabIndex = 1;
            // 
            // WeekdayLabel
            // 
            WeekdayLabel.AutoSize = true;
            WeekdayLabel.Location = new Point(3, 19);
            WeekdayLabel.Name = "WeekdayLabel";
            WeekdayLabel.Size = new Size(125, 15);
            WeekdayLabel.TabIndex = 0;
            WeekdayLabel.Text = "Type value for parsing:";
            // 
            // Enumerations
            // 
            Enumerations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Enumerations.AutoSize = true;
            Enumerations.Controls.Add(ValueTextBox);
            Enumerations.Controls.Add(IntValueLabel);
            Enumerations.Controls.Add(ValuesListBox);
            Enumerations.Controls.Add(ValuesLabel);
            Enumerations.Controls.Add(EnumsLabel);
            Enumerations.Controls.Add(EnumsListBox);
            Enumerations.Location = new Point(7, 4);
            Enumerations.Margin = new Padding(3, 2, 3, 2);
            Enumerations.Name = "Enumerations";
            Enumerations.Padding = new Padding(3, 2, 3, 2);
            Enumerations.Size = new Size(564, 247);
            Enumerations.TabIndex = 1;
            Enumerations.TabStop = false;
            Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(400, 54);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(100, 23);
            ValueTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(400, 36);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 6;
            IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.HorizontalScrollbar = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(203, 53);
            ValuesListBox.Margin = new Padding(3, 2, 3, 2);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(151, 154);
            ValuesListBox.TabIndex = 5;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // ValuesLabel
            // 
            ValuesLabel.AutoSize = true;
            ValuesLabel.Location = new Point(203, 36);
            ValuesLabel.Name = "ValuesLabel";
            ValuesLabel.Size = new Size(81, 15);
            ValuesLabel.TabIndex = 4;
            ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(6, 36);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(121, 15);
            EnumsLabel.TabIndex = 3;
            EnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.HorizontalScrollbar = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufacturer", "Season", "Weekday" });
            EnumsListBox.Location = new Point(6, 53);
            EnumsListBox.Margin = new Padding(3, 2, 3, 2);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(151, 154);
            EnumsListBox.TabIndex = 2;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // Classes
            // 
            Classes.Controls.Add(tableLayoutPanel1);
            Classes.Controls.Add(MoviesGroupBox);
            Classes.Controls.Add(RectangleGroupBox);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(576, 413);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 290F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47F));
            tableLayoutPanel1.Size = new Size(570, 407);
            tableLayoutPanel1.TabIndex = 13;
            tableLayoutPanel1.Visible = false;
            // 
            // MoviesGroupBox
            // 
            MoviesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MoviesGroupBox.Controls.Add(ScoreTextBox);
            MoviesGroupBox.Controls.Add(ScoreLabel);
            MoviesGroupBox.Controls.Add(GenreTextBox);
            MoviesGroupBox.Controls.Add(GenreLabel);
            MoviesGroupBox.Controls.Add(MoviesButton);
            MoviesGroupBox.Controls.Add(YearTextBox);
            MoviesGroupBox.Controls.Add(YearLabel);
            MoviesGroupBox.Controls.Add(DurationTextBox);
            MoviesGroupBox.Controls.Add(DurationLabel);
            MoviesGroupBox.Controls.Add(TitleTextBox);
            MoviesGroupBox.Controls.Add(TitleLabel);
            MoviesGroupBox.Controls.Add(MoviesListBox);
            MoviesGroupBox.Location = new Point(3, 3);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(276, 407);
            MoviesGroupBox.TabIndex = 1;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.Location = new Point(171, 211);
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.Size = new Size(100, 23);
            ScoreTextBox.TabIndex = 11;
            ScoreTextBox.TextChanged += ScoreTextBox_TextChanged;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(171, 193);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(39, 15);
            ScoreLabel.TabIndex = 10;
            ScoreLabel.Text = "Score:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(171, 169);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(100, 23);
            GenreTextBox.TabIndex = 9;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(171, 151);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre:";
            // 
            // MoviesButton
            // 
            MoviesButton.Location = new Point(171, 272);
            MoviesButton.Name = "MoviesButton";
            MoviesButton.Size = new Size(100, 23);
            MoviesButton.TabIndex = 1;
            MoviesButton.Text = "Find";
            MoviesButton.UseVisualStyleBackColor = true;
            MoviesButton.Click += MoviesButton_Click;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(171, 125);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(100, 23);
            YearTextBox.TabIndex = 7;
            YearTextBox.TextChanged += YearTextBox_TextChanged;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(171, 107);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(32, 15);
            YearLabel.TabIndex = 6;
            YearLabel.Text = "Year:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(171, 81);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(100, 23);
            DurationTextBox.TabIndex = 5;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(171, 63);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(56, 15);
            DurationLabel.TabIndex = 4;
            DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(171, 37);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(100, 23);
            TitleTextBox.TabIndex = 3;
            TitleTextBox.TextChanged += TitleTextBox_TextChanged;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(171, 18);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(32, 15);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(5, 18);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(137, 184);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
            // 
            // RectangleGroupBox
            // 
            RectangleGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RectangleGroupBox.Controls.Add(RectangleButton);
            RectangleGroupBox.Controls.Add(ColorTextBox);
            RectangleGroupBox.Controls.Add(ColorLabel);
            RectangleGroupBox.Controls.Add(WidthTextBox);
            RectangleGroupBox.Controls.Add(WidthLabel);
            RectangleGroupBox.Controls.Add(LengthTextBox);
            RectangleGroupBox.Controls.Add(LengthLabel);
            RectangleGroupBox.Controls.Add(RectangleListBox);
            RectangleGroupBox.Location = new Point(297, 3);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(276, 407);
            RectangleGroupBox.TabIndex = 0;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(171, 272);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(100, 23);
            RectangleButton.TabIndex = 1;
            RectangleButton.Text = "Find";
            RectangleButton.UseVisualStyleBackColor = true;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(171, 125);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(100, 23);
            ColorTextBox.TabIndex = 7;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(171, 107);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(39, 15);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(171, 81);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(100, 23);
            WidthTextBox.TabIndex = 5;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(171, 63);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(42, 15);
            WidthLabel.TabIndex = 4;
            WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(171, 37);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(100, 23);
            LengthTextBox.TabIndex = 3;
            LengthTextBox.TextChanged += LengthTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(171, 18);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(47, 15);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.ItemHeight = 15;
            RectangleListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox.Location = new Point(5, 18);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(137, 184);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(584, 441);
            Controls.Add(EnumsTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(600, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            EnumsTabControl.ResumeLayout(false);
            Enums.ResumeLayout(false);
            Enums.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            Enumerations.ResumeLayout(false);
            Enumerations.PerformLayout();
            Classes.ResumeLayout(false);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}