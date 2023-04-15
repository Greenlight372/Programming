namespace Programming.View
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
            Classes = new TabPage();
            ClassesLayoutPanel = new TableLayoutPanel();
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
            IdTextBox = new TextBox();
            IdLabel = new Label();
            CenterYTextBox = new TextBox();
            CenterYLabel = new Label();
            CenterXTextBox = new TextBox();
            CenterXLabel = new Label();
            RectangleButton = new Button();
            ColorTextBox = new TextBox();
            ColorLabel = new Label();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            LengthTextBox = new TextBox();
            LengthLabel = new Label();
            RectangleListBox = new ListBox();
            Enums = new TabPage();
            EnumsLayoutPanel = new TableLayoutPanel();
            Enumerations = new GroupBox();
            ValueTextBox = new TextBox();
            IntValueLabel = new Label();
            ValuesListBox = new ListBox();
            ValuesLabel = new Label();
            EnumsLabel = new Label();
            EnumsListBox = new ListBox();
            EnumsLayoutSubpanel = new TableLayoutPanel();
            WeekdayParsing = new GroupBox();
            WeekdayParsingResult = new Label();
            WeekdayButton = new Button();
            WeekdayTextBox = new TextBox();
            WeekdayLabel = new Label();
            SeasonHandle = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            EnumsTabControl = new TabControl();
            Rectangles = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            RectanglePanel = new Panel();
            RectanglesGroupBox = new GroupBox();
            RemoveRectangleBox = new PictureBox();
            AddRectangleBox = new PictureBox();
            RectangleHeightLabel = new Label();
            RectangleWidthLabel = new Label();
            RectangleYLabel = new Label();
            RectangleXLabel = new Label();
            RectangleIDLabel = new Label();
            RectangleHeightTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectangleYTextBox = new TextBox();
            RectangleXTextBox = new TextBox();
            RectangleIDTextBox = new TextBox();
            SelectedRectangleLabel = new Label();
            RectanglesListBox = new ListBox();
            Classes.SuspendLayout();
            ClassesLayoutPanel.SuspendLayout();
            MoviesGroupBox.SuspendLayout();
            RectangleGroupBox.SuspendLayout();
            Enums.SuspendLayout();
            EnumsLayoutPanel.SuspendLayout();
            Enumerations.SuspendLayout();
            EnumsLayoutSubpanel.SuspendLayout();
            WeekdayParsing.SuspendLayout();
            SeasonHandle.SuspendLayout();
            EnumsTabControl.SuspendLayout();
            Rectangles.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).BeginInit();
            SuspendLayout();
            // 
            // Classes
            // 
            Classes.Controls.Add(ClassesLayoutPanel);
            Classes.Location = new Point(4, 29);
            Classes.Margin = new Padding(3, 4, 3, 4);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3, 4, 3, 4);
            Classes.Size = new Size(659, 555);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // ClassesLayoutPanel
            // 
            ClassesLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ClassesLayoutPanel.AutoSize = true;
            ClassesLayoutPanel.ColumnCount = 2;
            ClassesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ClassesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ClassesLayoutPanel.Controls.Add(MoviesGroupBox, 1, 0);
            ClassesLayoutPanel.Controls.Add(RectangleGroupBox, 0, 0);
            ClassesLayoutPanel.Location = new Point(3, 4);
            ClassesLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            ClassesLayoutPanel.Name = "ClassesLayoutPanel";
            ClassesLayoutPanel.RowCount = 1;
            ClassesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ClassesLayoutPanel.Size = new Size(651, 543);
            ClassesLayoutPanel.TabIndex = 0;
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
            MoviesGroupBox.Location = new Point(328, 4);
            MoviesGroupBox.Margin = new Padding(3, 4, 3, 4);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Padding = new Padding(3, 4, 3, 4);
            MoviesGroupBox.Size = new Size(320, 535);
            MoviesGroupBox.TabIndex = 4;
            MoviesGroupBox.TabStop = false;
            MoviesGroupBox.Text = "Movies";
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.Location = new Point(195, 281);
            ScoreTextBox.Margin = new Padding(3, 4, 3, 4);
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.Size = new Size(114, 27);
            ScoreTextBox.TabIndex = 11;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Location = new Point(195, 257);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(49, 20);
            ScoreLabel.TabIndex = 10;
            ScoreLabel.Text = "Score:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(195, 225);
            GenreTextBox.Margin = new Padding(3, 4, 3, 4);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(114, 27);
            GenreTextBox.TabIndex = 9;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(195, 201);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre:";
            // 
            // MoviesButton
            // 
            MoviesButton.Location = new Point(195, 408);
            MoviesButton.Margin = new Padding(3, 4, 3, 4);
            MoviesButton.Name = "MoviesButton";
            MoviesButton.Size = new Size(114, 31);
            MoviesButton.TabIndex = 1;
            MoviesButton.Text = "Find";
            MoviesButton.UseVisualStyleBackColor = true;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(195, 167);
            YearTextBox.Margin = new Padding(3, 4, 3, 4);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(114, 27);
            YearTextBox.TabIndex = 7;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(195, 143);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(40, 20);
            YearLabel.TabIndex = 6;
            YearLabel.Text = "Year:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(195, 108);
            DurationTextBox.Margin = new Padding(3, 4, 3, 4);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(114, 27);
            DurationTextBox.TabIndex = 5;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(195, 83);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(70, 20);
            DurationLabel.TabIndex = 4;
            DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(195, 48);
            TitleTextBox.Margin = new Padding(3, 4, 3, 4);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(114, 27);
            TitleTextBox.TabIndex = 3;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(195, 24);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(41, 20);
            TitleLabel.TabIndex = 2;
            TitleLabel.Text = "Title:";
            // 
            // MoviesListBox
            // 
            MoviesListBox.Dock = DockStyle.Left;
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 20;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(3, 24);
            MoviesListBox.Margin = new Padding(3, 4, 3, 4);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(156, 507);
            MoviesListBox.TabIndex = 0;
            // 
            // RectangleGroupBox
            // 
            RectangleGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectangleGroupBox.Controls.Add(IdTextBox);
            RectangleGroupBox.Controls.Add(IdLabel);
            RectangleGroupBox.Controls.Add(CenterYTextBox);
            RectangleGroupBox.Controls.Add(CenterYLabel);
            RectangleGroupBox.Controls.Add(CenterXTextBox);
            RectangleGroupBox.Controls.Add(CenterXLabel);
            RectangleGroupBox.Controls.Add(RectangleButton);
            RectangleGroupBox.Controls.Add(ColorTextBox);
            RectangleGroupBox.Controls.Add(ColorLabel);
            RectangleGroupBox.Controls.Add(WidthTextBox);
            RectangleGroupBox.Controls.Add(WidthLabel);
            RectangleGroupBox.Controls.Add(LengthTextBox);
            RectangleGroupBox.Controls.Add(LengthLabel);
            RectangleGroupBox.Controls.Add(RectangleListBox);
            RectangleGroupBox.Location = new Point(3, 4);
            RectangleGroupBox.Margin = new Padding(3, 4, 3, 4);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Padding = new Padding(3, 4, 3, 4);
            RectangleGroupBox.Size = new Size(319, 535);
            RectangleGroupBox.TabIndex = 5;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(195, 337);
            IdTextBox.Margin = new Padding(3, 4, 3, 4);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(114, 27);
            IdTextBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(195, 313);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "ID:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(195, 281);
            CenterYTextBox.Margin = new Padding(3, 4, 3, 4);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(114, 27);
            CenterYTextBox.TabIndex = 11;
            // 
            // CenterYLabel
            // 
            CenterYLabel.AutoSize = true;
            CenterYLabel.Location = new Point(195, 257);
            CenterYLabel.Name = "CenterYLabel";
            CenterYLabel.Size = new Size(67, 20);
            CenterYLabel.TabIndex = 10;
            CenterYLabel.Text = "Center Y:";
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(195, 225);
            CenterXTextBox.Margin = new Padding(3, 4, 3, 4);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(114, 27);
            CenterXTextBox.TabIndex = 9;
            // 
            // CenterXLabel
            // 
            CenterXLabel.AutoSize = true;
            CenterXLabel.Location = new Point(195, 201);
            CenterXLabel.Name = "CenterXLabel";
            CenterXLabel.Size = new Size(68, 20);
            CenterXLabel.TabIndex = 8;
            CenterXLabel.Text = "Center X:";
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(195, 408);
            RectangleButton.Margin = new Padding(3, 4, 3, 4);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(114, 31);
            RectangleButton.TabIndex = 1;
            RectangleButton.Text = "Find";
            RectangleButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(195, 167);
            ColorTextBox.Margin = new Padding(3, 4, 3, 4);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(114, 27);
            ColorTextBox.TabIndex = 7;
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Location = new Point(195, 143);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(48, 20);
            ColorLabel.TabIndex = 6;
            ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(195, 108);
            WidthTextBox.Margin = new Padding(3, 4, 3, 4);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(114, 27);
            WidthTextBox.TabIndex = 5;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(195, 84);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 4;
            WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            LengthTextBox.Location = new Point(195, 49);
            LengthTextBox.Margin = new Padding(3, 4, 3, 4);
            LengthTextBox.Name = "LengthTextBox";
            LengthTextBox.Size = new Size(114, 27);
            LengthTextBox.TabIndex = 3;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(195, 24);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 2;
            LengthLabel.Text = "Length:";
            // 
            // RectangleListBox
            // 
            RectangleListBox.Dock = DockStyle.Left;
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.ItemHeight = 20;
            RectangleListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox.Location = new Point(3, 24);
            RectangleListBox.Margin = new Padding(3, 4, 3, 4);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(156, 507);
            RectangleListBox.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(EnumsLayoutPanel);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(659, 555);
            Enums.TabIndex = 0;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // EnumsLayoutPanel
            // 
            EnumsLayoutPanel.ColumnCount = 1;
            EnumsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutPanel.Controls.Add(Enumerations, 0, 0);
            EnumsLayoutPanel.Controls.Add(EnumsLayoutSubpanel, 0, 1);
            EnumsLayoutPanel.Dock = DockStyle.Fill;
            EnumsLayoutPanel.Location = new Point(3, 3);
            EnumsLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            EnumsLayoutPanel.Name = "EnumsLayoutPanel";
            EnumsLayoutPanel.RowCount = 2;
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.54523F));
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.45477F));
            EnumsLayoutPanel.Size = new Size(653, 549);
            EnumsLayoutPanel.TabIndex = 5;
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
            Enumerations.Location = new Point(3, 3);
            Enumerations.Name = "Enumerations";
            Enumerations.Size = new Size(647, 287);
            Enumerations.TabIndex = 2;
            Enumerations.TabStop = false;
            Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(457, 72);
            ValueTextBox.Margin = new Padding(3, 4, 3, 4);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.ReadOnly = true;
            ValueTextBox.Size = new Size(114, 27);
            ValueTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            IntValueLabel.AutoSize = true;
            IntValueLabel.Location = new Point(457, 47);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(68, 20);
            IntValueLabel.TabIndex = 6;
            IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.HorizontalScrollbar = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(232, 71);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(172, 204);
            ValuesListBox.TabIndex = 5;
            // 
            // ValuesLabel
            // 
            ValuesLabel.AutoSize = true;
            ValuesLabel.Location = new Point(232, 47);
            ValuesLabel.Name = "ValuesLabel";
            ValuesLabel.Size = new Size(100, 20);
            ValuesLabel.TabIndex = 4;
            ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(7, 47);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(149, 20);
            EnumsLabel.TabIndex = 3;
            EnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.HorizontalScrollbar = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Manufacturer", "Season", "Weekday" });
            EnumsListBox.Location = new Point(7, 71);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(172, 204);
            EnumsListBox.TabIndex = 2;
            // 
            // EnumsLayoutSubpanel
            // 
            EnumsLayoutSubpanel.ColumnCount = 2;
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Controls.Add(WeekdayParsing, 1, 0);
            EnumsLayoutSubpanel.Controls.Add(SeasonHandle, 0, 0);
            EnumsLayoutSubpanel.Dock = DockStyle.Fill;
            EnumsLayoutSubpanel.Location = new Point(3, 297);
            EnumsLayoutSubpanel.Margin = new Padding(3, 4, 3, 4);
            EnumsLayoutSubpanel.Name = "EnumsLayoutSubpanel";
            EnumsLayoutSubpanel.RowCount = 1;
            EnumsLayoutSubpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Size = new Size(647, 248);
            EnumsLayoutSubpanel.TabIndex = 3;
            // 
            // WeekdayParsing
            // 
            WeekdayParsing.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WeekdayParsing.AutoSize = true;
            WeekdayParsing.Controls.Add(WeekdayParsingResult);
            WeekdayParsing.Controls.Add(WeekdayButton);
            WeekdayParsing.Controls.Add(WeekdayTextBox);
            WeekdayParsing.Controls.Add(WeekdayLabel);
            WeekdayParsing.Location = new Point(326, 4);
            WeekdayParsing.Margin = new Padding(3, 4, 3, 4);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Padding = new Padding(3, 4, 3, 4);
            WeekdayParsing.Size = new Size(318, 240);
            WeekdayParsing.TabIndex = 2;
            WeekdayParsing.TabStop = false;
            WeekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingResult
            // 
            WeekdayParsingResult.AutoSize = true;
            WeekdayParsingResult.Location = new Point(8, 84);
            WeekdayParsingResult.Name = "WeekdayParsingResult";
            WeekdayParsingResult.Size = new Size(0, 20);
            WeekdayParsingResult.TabIndex = 3;
            // 
            // WeekdayButton
            // 
            WeekdayButton.Location = new Point(187, 48);
            WeekdayButton.Margin = new Padding(3, 4, 3, 4);
            WeekdayButton.Name = "WeekdayButton";
            WeekdayButton.Size = new Size(86, 31);
            WeekdayButton.TabIndex = 2;
            WeekdayButton.Text = "Parse";
            WeekdayButton.UseVisualStyleBackColor = true;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(8, 49);
            WeekdayTextBox.Margin = new Padding(3, 4, 3, 4);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(172, 27);
            WeekdayTextBox.TabIndex = 1;
            // 
            // WeekdayLabel
            // 
            WeekdayLabel.AutoSize = true;
            WeekdayLabel.Location = new Point(3, 25);
            WeekdayLabel.Name = "WeekdayLabel";
            WeekdayLabel.Size = new Size(158, 20);
            WeekdayLabel.TabIndex = 0;
            WeekdayLabel.Text = "Type value for parsing:";
            // 
            // SeasonHandle
            // 
            SeasonHandle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SeasonHandle.AutoSize = true;
            SeasonHandle.Controls.Add(SeasonButton);
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(SeasonLabel);
            SeasonHandle.Location = new Point(3, 4);
            SeasonHandle.Margin = new Padding(3, 4, 3, 4);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Padding = new Padding(3, 4, 3, 4);
            SeasonHandle.Size = new Size(317, 240);
            SeasonHandle.TabIndex = 4;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(195, 48);
            SeasonButton.Margin = new Padding(3, 4, 3, 4);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(86, 31);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(7, 49);
            SeasonComboBox.Margin = new Padding(3, 4, 3, 4);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(181, 28);
            SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(3, 25);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(110, 20);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnumsTabControl.Controls.Add(Enums);
            EnumsTabControl.Controls.Add(Classes);
            EnumsTabControl.Controls.Add(Rectangles);
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(667, 588);
            EnumsTabControl.TabIndex = 0;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(tableLayoutPanel1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(659, 555);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.27083F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.72917F));
            tableLayoutPanel1.Controls.Add(RectanglePanel, 1, 0);
            tableLayoutPanel1.Controls.Add(RectanglesGroupBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(659, 555);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // RectanglePanel
            // 
            RectanglePanel.AllowDrop = true;
            RectanglePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(294, 3);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(362, 549);
            RectanglePanel.TabIndex = 13;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(RemoveRectangleBox);
            RectanglesGroupBox.Controls.Add(AddRectangleBox);
            RectanglesGroupBox.Controls.Add(RectangleHeightLabel);
            RectanglesGroupBox.Controls.Add(RectangleWidthLabel);
            RectanglesGroupBox.Controls.Add(RectangleYLabel);
            RectanglesGroupBox.Controls.Add(RectangleXLabel);
            RectanglesGroupBox.Controls.Add(RectangleIDLabel);
            RectanglesGroupBox.Controls.Add(RectangleHeightTextBox);
            RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
            RectanglesGroupBox.Controls.Add(RectangleYTextBox);
            RectanglesGroupBox.Controls.Add(RectangleXTextBox);
            RectanglesGroupBox.Controls.Add(RectangleIDTextBox);
            RectanglesGroupBox.Controls.Add(SelectedRectangleLabel);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(3, 4);
            RectanglesGroupBox.Margin = new Padding(3, 4, 3, 4);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Padding = new Padding(3, 4, 3, 4);
            RectanglesGroupBox.Size = new Size(285, 547);
            RectanglesGroupBox.TabIndex = 14;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles:";
            // 
            // RemoveRectangleBox
            // 
            RemoveRectangleBox.BackColor = Color.Black;
            RemoveRectangleBox.BackgroundImage = Properties.Resources.del_rectangle2;
            RemoveRectangleBox.BackgroundImageLayout = ImageLayout.Stretch;
            RemoveRectangleBox.InitialImage = null;
            RemoveRectangleBox.Location = new Point(149, 199);
            RemoveRectangleBox.Margin = new Padding(3, 4, 3, 4);
            RemoveRectangleBox.Name = "RemoveRectangleBox";
            RemoveRectangleBox.Size = new Size(64, 48);
            RemoveRectangleBox.TabIndex = 27;
            RemoveRectangleBox.TabStop = false;
            RemoveRectangleBox.Click += RemoveRectangleBox_Click;
            RemoveRectangleBox.MouseLeave += RemoveRectangleBox_MouseLeave;
            RemoveRectangleBox.MouseMove += RemoveRectangleBox_MouseMove;
            // 
            // AddRectangleBox
            // 
            AddRectangleBox.BackColor = Color.Black;
            AddRectangleBox.BackgroundImage = Properties.Resources.add_rectangle2;
            AddRectangleBox.BackgroundImageLayout = ImageLayout.Stretch;
            AddRectangleBox.ErrorImage = null;
            AddRectangleBox.InitialImage = null;
            AddRectangleBox.Location = new Point(71, 199);
            AddRectangleBox.Margin = new Padding(3, 4, 3, 4);
            AddRectangleBox.Name = "AddRectangleBox";
            AddRectangleBox.Size = new Size(64, 48);
            AddRectangleBox.TabIndex = 26;
            AddRectangleBox.TabStop = false;
            AddRectangleBox.Click += AddRectangleBox_Click;
            AddRectangleBox.MouseLeave += AddRectangleBox_MouseLeave;
            AddRectangleBox.MouseMove += AddRectangleBox_MouseMove;
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.AutoSize = true;
            RectangleHeightLabel.Location = new Point(7, 488);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(57, 20);
            RectangleHeightLabel.TabIndex = 25;
            RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.AutoSize = true;
            RectangleWidthLabel.Location = new Point(7, 455);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(52, 20);
            RectangleWidthLabel.TabIndex = 24;
            RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.AutoSize = true;
            RectangleYLabel.Location = new Point(7, 423);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(20, 20);
            RectangleYLabel.TabIndex = 23;
            RectangleYLabel.Text = "Y:";
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.AutoSize = true;
            RectangleXLabel.Location = new Point(7, 389);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(21, 20);
            RectangleXLabel.TabIndex = 22;
            RectangleXLabel.Text = "X:";
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(7, 356);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(27, 20);
            RectangleIDLabel.TabIndex = 21;
            RectangleIDLabel.Text = "ID:";
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(77, 485);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(125, 27);
            RectangleHeightTextBox.TabIndex = 20;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(77, 452);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(125, 27);
            RectangleWidthTextBox.TabIndex = 19;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleYTextBox
            // 
            RectangleYTextBox.Location = new Point(77, 419);
            RectangleYTextBox.Name = "RectangleYTextBox";
            RectangleYTextBox.Size = new Size(125, 27);
            RectangleYTextBox.TabIndex = 18;
            RectangleYTextBox.TextChanged += RectangleYTextBox_TextChanged;
            // 
            // RectangleXTextBox
            // 
            RectangleXTextBox.Location = new Point(77, 385);
            RectangleXTextBox.Name = "RectangleXTextBox";
            RectangleXTextBox.Size = new Size(125, 27);
            RectangleXTextBox.TabIndex = 17;
            RectangleXTextBox.TextChanged += RectangleXTextBox_TextChanged;
            // 
            // RectangleIDTextBox
            // 
            RectangleIDTextBox.Location = new Point(77, 353);
            RectangleIDTextBox.Name = "RectangleIDTextBox";
            RectangleIDTextBox.ReadOnly = true;
            RectangleIDTextBox.Size = new Size(125, 27);
            RectangleIDTextBox.TabIndex = 16;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(7, 329);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(139, 20);
            SelectedRectangleLabel.TabIndex = 15;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.HorizontalScrollbar = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Location = new Point(7, 28);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(270, 164);
            RectanglesListBox.TabIndex = 14;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(667, 588);
            Controls.Add(EnumsTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(683, 619);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Classes.ResumeLayout(false);
            Classes.PerformLayout();
            ClassesLayoutPanel.ResumeLayout(false);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            RectangleGroupBox.ResumeLayout(false);
            RectangleGroupBox.PerformLayout();
            Enums.ResumeLayout(false);
            EnumsLayoutPanel.ResumeLayout(false);
            EnumsLayoutPanel.PerformLayout();
            Enumerations.ResumeLayout(false);
            Enumerations.PerformLayout();
            EnumsLayoutSubpanel.ResumeLayout(false);
            EnumsLayoutSubpanel.PerformLayout();
            WeekdayParsing.ResumeLayout(false);
            WeekdayParsing.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            EnumsTabControl.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage Classes;
        private TableLayoutPanel ClassesLayoutPanel;
        private GroupBox MoviesGroupBox;
        private TextBox ScoreTextBox;
        private Label ScoreLabel;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private Button MoviesButton;
        private TextBox YearTextBox;
        private Label YearLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox TitleTextBox;
        private Label TitleLabel;
        private ListBox MoviesListBox;
        private TabPage Enums;
        private TabControl EnumsTabControl;
        private GroupBox RectangleGroupBox;
        private Button RectangleButton;
        private TextBox ColorTextBox;
        private Label ColorLabel;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LengthTextBox;
        private Label LengthLabel;
        private ListBox RectangleListBox;
        private TextBox CenterYTextBox;
        private Label CenterYLabel;
        private TextBox CenterXTextBox;
        private Label CenterXLabel;
        private TextBox IdTextBox;
        private Label IdLabel;
        private TableLayoutPanel EnumsLayoutPanel;
        private GroupBox Enumerations;
        private TextBox ValueTextBox;
        private Label IntValueLabel;
        private ListBox ValuesListBox;
        private Label ValuesLabel;
        private Label EnumsLabel;
        public ListBox EnumsListBox;
        private TableLayoutPanel EnumsLayoutSubpanel;
        private GroupBox WeekdayParsing;
        private Label WeekdayParsingResult;
        private Button WeekdayButton;
        private TextBox WeekdayTextBox;
        private Label WeekdayLabel;
        private GroupBox SeasonHandle;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private TabPage Rectangles;
        private Panel RectanglePanel;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox RectanglesGroupBox;
        private PictureBox RemoveRectangleBox;
        private PictureBox AddRectangleBox;
        private Label RectangleHeightLabel;
        private Label RectangleWidthLabel;
        private Label RectangleYLabel;
        private Label RectangleXLabel;
        private Label RectangleIDLabel;
        private TextBox RectangleHeightTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectangleYTextBox;
        private TextBox RectangleXTextBox;
        private TextBox RectangleIDTextBox;
        private Label SelectedRectangleLabel;
        private ListBox RectanglesListBox;
    }
}