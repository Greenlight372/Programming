namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            RectanglePanel = new Panel();
            RectangleTableLayout = new TableLayoutPanel();
            RectanglesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).BeginInit();
            RectangleTableLayout.SuspendLayout();
            SuspendLayout();
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
            RectanglesGroupBox.Size = new Size(266, 407);
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
            RemoveRectangleBox.Location = new Point(145, 195);
            RemoveRectangleBox.Name = "RemoveRectangleBox";
            RemoveRectangleBox.Size = new Size(32, 24);
            RemoveRectangleBox.TabIndex = 27;
            RemoveRectangleBox.TabStop = false;
            RemoveRectangleBox.Click += RemoveRectangleBox_Click;
            RemoveRectangleBox.MouseLeave += RemoveRectangleBox_MouseLeave;
            // 
            // AddRectangleBox
            // 
            AddRectangleBox.BackColor = Color.Black;
            AddRectangleBox.BackgroundImage = Properties.Resources.add_rectangle2;
            AddRectangleBox.BackgroundImageLayout = ImageLayout.Stretch;
            AddRectangleBox.ErrorImage = null;
            AddRectangleBox.InitialImage = null;
            AddRectangleBox.Location = new Point(70, 195);
            AddRectangleBox.Name = "AddRectangleBox";
            AddRectangleBox.Size = new Size(32, 24);
            AddRectangleBox.TabIndex = 26;
            AddRectangleBox.TabStop = false;
            AddRectangleBox.Click += AddRectangleBox_Click;
            AddRectangleBox.MouseLeave += AddRectangleBox_MouseLeave;
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.AutoSize = true;
            RectangleHeightLabel.Location = new Point(6, 355);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(46, 15);
            RectangleHeightLabel.TabIndex = 25;
            RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.AutoSize = true;
            RectangleWidthLabel.Location = new Point(6, 330);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(42, 15);
            RectangleWidthLabel.TabIndex = 24;
            RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.AutoSize = true;
            RectangleYLabel.Location = new Point(6, 306);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(17, 15);
            RectangleYLabel.TabIndex = 23;
            RectangleYLabel.Text = "Y:";
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.AutoSize = true;
            RectangleXLabel.Location = new Point(6, 281);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(17, 15);
            RectangleXLabel.TabIndex = 22;
            RectangleXLabel.Text = "X:";
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(6, 256);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(21, 15);
            RectangleIDLabel.TabIndex = 21;
            RectangleIDLabel.Text = "ID:";
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(67, 353);
            RectangleHeightTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(110, 23);
            RectangleHeightTextBox.TabIndex = 20;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(67, 328);
            RectangleWidthTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(110, 23);
            RectangleWidthTextBox.TabIndex = 19;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleYTextBox
            // 
            RectangleYTextBox.Location = new Point(67, 303);
            RectangleYTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleYTextBox.Name = "RectangleYTextBox";
            RectangleYTextBox.Size = new Size(110, 23);
            RectangleYTextBox.TabIndex = 18;
            RectangleYTextBox.TextChanged += RectangleYTextBox_TextChanged;
            // 
            // RectangleXTextBox
            // 
            RectangleXTextBox.Location = new Point(67, 278);
            RectangleXTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleXTextBox.Name = "RectangleXTextBox";
            RectangleXTextBox.Size = new Size(110, 23);
            RectangleXTextBox.TabIndex = 17;
            RectangleXTextBox.TextChanged += RectangleXTextBox_TextChanged;
            // 
            // RectangleIDTextBox
            // 
            RectangleIDTextBox.Location = new Point(67, 254);
            RectangleIDTextBox.Margin = new Padding(3, 2, 3, 2);
            RectangleIDTextBox.Name = "RectangleIDTextBox";
            RectangleIDTextBox.ReadOnly = true;
            RectangleIDTextBox.Size = new Size(110, 23);
            RectangleIDTextBox.TabIndex = 16;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(6, 236);
            SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            SelectedRectangleLabel.Size = new Size(109, 15);
            SelectedRectangleLabel.TabIndex = 15;
            SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.HorizontalScrollbar = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 21);
            RectanglesListBox.Margin = new Padding(3, 2, 3, 2);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(254, 169);
            RectanglesListBox.TabIndex = 14;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglePanel
            // 
            RectanglePanel.AllowDrop = true;
            RectanglePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(275, 2);
            RectanglePanel.Margin = new Padding(3, 2, 3, 2);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(298, 409);
            RectanglePanel.TabIndex = 13;
            // 
            // RectangleTableLayout
            // 
            RectangleTableLayout.ColumnCount = 2;
            RectangleTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272F));
            RectangleTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RectangleTableLayout.Controls.Add(RectanglePanel, 1, 0);
            RectangleTableLayout.Controls.Add(RectanglesGroupBox, 0, 0);
            RectangleTableLayout.Dock = DockStyle.Fill;
            RectangleTableLayout.Location = new Point(0, 0);
            RectangleTableLayout.Name = "RectangleTableLayout";
            RectangleTableLayout.RowCount = 1;
            RectangleTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RectangleTableLayout.Size = new Size(576, 413);
            RectangleTableLayout.TabIndex = 15;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleTableLayout);
            Name = "RectanglesCollisionControl";
            Size = new Size(576, 413);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveRectangleBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddRectangleBox).EndInit();
            RectangleTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
        private Panel RectanglePanel;
        private TableLayoutPanel RectangleTableLayout;
    }
}
