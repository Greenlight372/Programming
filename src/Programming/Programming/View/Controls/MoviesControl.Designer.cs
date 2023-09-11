namespace Programming.View.Controls
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            MoviesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MoviesGroupBox
            // 
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
            MoviesGroupBox.Dock = DockStyle.Fill;
            MoviesGroupBox.Location = new Point(0, 0);
            MoviesGroupBox.Name = "MoviesGroupBox";
            MoviesGroupBox.Size = new Size(279, 401);
            MoviesGroupBox.TabIndex = 5;
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
            MoviesButton.TextChanged += MoviesButton_Click;
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
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MoviesGroupBox);
            Name = "MoviesControl";
            Size = new Size(279, 401);
            MoviesGroupBox.ResumeLayout(false);
            MoviesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
    }
}
