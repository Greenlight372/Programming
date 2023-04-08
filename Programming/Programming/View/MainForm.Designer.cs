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
            RectanglePanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            RectanglesGroupBox = new GroupBox();
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
            AddRectangleBox = new PictureBox();
            RemoveRectangleBox = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).BeginInit();
            SuspendLayout();
            // 
            // Classes
            // 
            Classes.Controls.Add(ClassesLayoutPanel);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(576, 413);
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
            ClassesLayoutPanel.Location = new Point(3, 3);
            ClassesLayoutPanel.Name = "ClassesLayoutPanel";
            ClassesLayoutPanel.RowCount = 1;
            ClassesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ClassesLayoutPanel.Size = new Size(570, 407);
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
            MoviesGroupBox.Location = new Point(288, 3);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(279, 401);
            MoviesGroupBox.TabIndex = 4;
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
            MoviesButton.Location = new Point(171, 306);
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
            DurationLabel.Location = new Point(171, 62);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(56, 15);
            DurationLabel.TabIndex = 4;
            DurationLabel.Text = "Duration:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(171, 36);
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
            MoviesListBox.Dock = DockStyle.Left;
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(3, 19);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(137, 379);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
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
            RectangleGroupBox.Location = new Point(3, 3);
            RectangleGroupBox.Name = "RectangleGroupBox";
            RectangleGroupBox.Size = new Size(279, 401);
            RectangleGroupBox.TabIndex = 5;
            RectangleGroupBox.TabStop = false;
            RectangleGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(171, 253);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 13;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(171, 235);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 12;
            IdLabel.Text = "ID:";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(171, 211);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(100, 23);
            CenterYTextBox.TabIndex = 11;
            // 
            // CenterYLabel
            // 
            CenterYLabel.AutoSize = true;
            CenterYLabel.Location = new Point(171, 193);
            CenterYLabel.Name = "CenterYLabel";
            CenterYLabel.Size = new Size(55, 15);
            CenterYLabel.TabIndex = 10;
            CenterYLabel.Text = "Center Y:";
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(171, 169);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(100, 23);
            CenterXTextBox.TabIndex = 9;
            // 
            // CenterXLabel
            // 
            CenterXLabel.AutoSize = true;
            CenterXLabel.Location = new Point(171, 151);
            CenterXLabel.Name = "CenterXLabel";
            CenterXLabel.Size = new Size(55, 15);
            CenterXLabel.TabIndex = 8;
            CenterXLabel.Text = "Center X:";
            // 
            // RectangleButton
            // 
            RectangleButton.Location = new Point(171, 306);
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
            RectangleListBox.Dock = DockStyle.Left;
            RectangleListBox.FormattingEnabled = true;
            RectangleListBox.ItemHeight = 15;
            RectangleListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectangleListBox.Location = new Point(3, 19);
            RectangleListBox.Name = "RectangleListBox";
            RectangleListBox.Size = new Size(137, 379);
            RectangleListBox.TabIndex = 0;
            RectangleListBox.SelectedIndexChanged += RectangleListBox_SelectedIndexChanged;
            // 
            // Enums
            // 
            Enums.Controls.Add(EnumsLayoutPanel);
            Enums.Location = new Point(4, 24);
            Enums.Margin = new Padding(3, 2, 3, 2);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3, 2, 3, 2);
            Enums.Size = new Size(576, 413);
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
            EnumsLayoutPanel.Location = new Point(3, 2);
            EnumsLayoutPanel.Name = "EnumsLayoutPanel";
            EnumsLayoutPanel.RowCount = 2;
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.54523F));
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.45477F));
            EnumsLayoutPanel.Size = new Size(570, 409);
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
            Enumerations.Location = new Point(3, 2);
            Enumerations.Margin = new Padding(3, 2, 3, 2);
            Enumerations.Name = "Enumerations";
            Enumerations.Padding = new Padding(3, 2, 3, 2);
            Enumerations.Size = new Size(564, 215);
            Enumerations.TabIndex = 2;
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
            IntValueLabel.Location = new Point(400, 35);
            IntValueLabel.Name = "IntValueLabel";
            IntValueLabel.Size = new Size(55, 15);
            IntValueLabel.TabIndex = 6;
            IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            ValuesLabel.Location = new Point(203, 35);
            ValuesLabel.Name = "ValuesLabel";
            ValuesLabel.Size = new Size(81, 15);
            ValuesLabel.TabIndex = 4;
            ValuesLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            EnumsLabel.AutoSize = true;
            EnumsLabel.Location = new Point(6, 35);
            EnumsLabel.Name = "EnumsLabel";
            EnumsLabel.Size = new Size(121, 15);
            EnumsLabel.TabIndex = 3;
            EnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            // EnumsLayoutSubpanel
            // 
            EnumsLayoutSubpanel.ColumnCount = 2;
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Controls.Add(WeekdayParsing, 1, 0);
            EnumsLayoutSubpanel.Controls.Add(SeasonHandle, 0, 0);
            EnumsLayoutSubpanel.Dock = DockStyle.Fill;
            EnumsLayoutSubpanel.Location = new Point(3, 222);
            EnumsLayoutSubpanel.Name = "EnumsLayoutSubpanel";
            EnumsLayoutSubpanel.RowCount = 1;
            EnumsLayoutSubpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Size = new Size(564, 184);
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
            WeekdayParsing.Location = new Point(285, 3);
            WeekdayParsing.Name = "WeekdayParsing";
            WeekdayParsing.Size = new Size(276, 178);
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
            // SeasonHandle
            // 
            SeasonHandle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SeasonHandle.AutoSize = true;
            SeasonHandle.Controls.Add(SeasonButton);
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(SeasonLabel);
            SeasonHandle.Location = new Point(3, 3);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(276, 178);
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
            // EnumsTabControl
            // 
            EnumsTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EnumsTabControl.Controls.Add(Enums);
            EnumsTabControl.Controls.Add(Classes);
            EnumsTabControl.Controls.Add(Rectangles);
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Margin = new Padding(3, 2, 3, 2);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(584, 441);
            EnumsTabControl.TabIndex = 0;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(tableLayoutPanel1);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Margin = new Padding(3, 2, 3, 2);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(576, 413);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // RectanglePanel
            // 
            RectanglePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(225, 2);
            RectanglePanel.Margin = new Padding(3, 2, 3, 2);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(348, 409);
            RectanglePanel.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5416679F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4583321F));
            tableLayoutPanel1.Controls.Add(RectanglePanel, 1, 0);
            tableLayoutPanel1.Controls.Add(RectanglesGroupBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(576, 413);
            tableLayoutPanel1.TabIndex = 14;
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
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(216, 407);
            RectanglesGroupBox.TabIndex = 14;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles:";
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.AutoSize = true;
            RectangleHeightLabel.Location = new Point(6, 366);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(46, 15);
            RectangleHeightLabel.TabIndex = 25;
            RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.AutoSize = true;
            RectangleWidthLabel.Location = new Point(6, 341);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(42, 15);
            RectangleWidthLabel.TabIndex = 24;
            RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.AutoSize = true;
            RectangleYLabel.Location = new Point(6, 317);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(17, 15);
            RectangleYLabel.TabIndex = 23;
            RectangleYLabel.Text = "Y:";
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.AutoSize = true;
            RectangleXLabel.Location = new Point(6, 292);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(17, 15);
            RectangleXLabel.TabIndex = 22;
            RectangleXLabel.Text = "X:";
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(6, 267);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(21, 15);
            RectangleIDLabel.TabIndex = 21;
            RectangleIDLabel.Text = "ID:";
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(67, 364);
            RectangleHeightTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(110, 23);
            RectangleHeightTextBox.TabIndex = 20;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(67, 339);
            RectangleWidthTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(110, 23);
            RectangleWidthTextBox.TabIndex = 19;
            // 
            // RectangleYTextBox
            // 
            RectangleYTextBox.Location = new Point(67, 314);
            RectangleYTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleYTextBox.Name = "RectangleYTextBox";
            RectangleYTextBox.Size = new Size(110, 23);
            RectangleYTextBox.TabIndex = 18;
            // 
            // RectangleXTextBox
            // 
            RectangleXTextBox.Location = new Point(67, 289);
            RectangleXTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleXTextBox.Name = "RectangleXTextBox";
            RectangleXTextBox.Size = new Size(110, 23);
            RectangleXTextBox.TabIndex = 17;
            // 
            // RectangleIDTextBox
            // 
            RectangleIDTextBox.Location = new Point(67, 265);
            RectangleIDTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleIDTextBox.Name = "RectangleIDTextBox";
            RectangleIDTextBox.Size = new Size(110, 23);
            RectangleIDTextBox.TabIndex = 16;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(6, 247);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(109, 15);
            SelectedRectangleLabel.TabIndex = 15;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 21);
            RectanglesListBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(207, 124);
            RectanglesListBox.TabIndex = 14;
            // 
            // AddRectangleBox
            // 
            AddRectangleBox.Image = Properties.Resources.add_rectangle;
            AddRectangleBox.InitialImage = null;
            AddRectangleBox.Location = new Point(6, 150);
            AddRectangleBox.Name = "AddRectangleBox";
            AddRectangleBox.Size = new Size(67, 50);
            AddRectangleBox.TabIndex = 26;
            AddRectangleBox.TabStop = false;
            // 
            // RemoveRectangleBox
            // 
            RemoveRectangleBox.Image = (Image)resources.GetObject("RemoveRectangleBox.Image");
            RemoveRectangleBox.InitialImage = null;
            RemoveRectangleBox.Location = new Point(146, 150);
            RemoveRectangleBox.Name = "RemoveRectangleBox";
            RemoveRectangleBox.Size = new Size(67, 50);
            RemoveRectangleBox.TabIndex = 27;
            RemoveRectangleBox.TabStop = false;
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
            MinimumSize = new Size(600, 478);
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
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).EndInit();
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