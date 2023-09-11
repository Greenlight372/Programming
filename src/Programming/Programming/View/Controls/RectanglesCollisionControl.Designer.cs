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
            RectanglesGroupBox.Location = new Point(3, 4);
            RectanglesGroupBox.Margin = new Padding(3, 4, 3, 4);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Padding = new Padding(3, 4, 3, 4);
            RectanglesGroupBox.Size = new Size(305, 543);
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
            RemoveRectangleBox.Location = new Point(166, 260);
            RemoveRectangleBox.Margin = new Padding(3, 4, 3, 4);
            RemoveRectangleBox.Name = "RemoveRectangleBox";
            RemoveRectangleBox.Size = new Size(37, 32);
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
            AddRectangleBox.Location = new Point(80, 260);
            AddRectangleBox.Margin = new Padding(3, 4, 3, 4);
            AddRectangleBox.Name = "AddRectangleBox";
            AddRectangleBox.Size = new Size(37, 32);
            AddRectangleBox.TabIndex = 26;
            AddRectangleBox.TabStop = false;
            AddRectangleBox.Click += AddRectangleBox_Click;
            AddRectangleBox.MouseLeave += AddRectangleBox_MouseLeave;
            AddRectangleBox.MouseMove += AddRectangleBox_MouseMove;
            // 
            // RectangleHeightLabel
            // 
            RectangleHeightLabel.AutoSize = true;
            RectangleHeightLabel.Location = new Point(7, 473);
            RectangleHeightLabel.Name = "RectangleHeightLabel";
            RectangleHeightLabel.Size = new Size(57, 20);
            RectangleHeightLabel.TabIndex = 25;
            RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthLabel
            // 
            RectangleWidthLabel.AutoSize = true;
            RectangleWidthLabel.Location = new Point(7, 440);
            RectangleWidthLabel.Name = "RectangleWidthLabel";
            RectangleWidthLabel.Size = new Size(52, 20);
            RectangleWidthLabel.TabIndex = 24;
            RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYLabel
            // 
            RectangleYLabel.AutoSize = true;
            RectangleYLabel.Location = new Point(7, 408);
            RectangleYLabel.Name = "RectangleYLabel";
            RectangleYLabel.Size = new Size(20, 20);
            RectangleYLabel.TabIndex = 23;
            RectangleYLabel.Text = "Y:";
            // 
            // RectangleXLabel
            // 
            RectangleXLabel.AutoSize = true;
            RectangleXLabel.Location = new Point(7, 375);
            RectangleXLabel.Name = "RectangleXLabel";
            RectangleXLabel.Size = new Size(21, 20);
            RectangleXLabel.TabIndex = 22;
            RectangleXLabel.Text = "X:";
            // 
            // RectangleIDLabel
            // 
            RectangleIDLabel.AutoSize = true;
            RectangleIDLabel.Location = new Point(7, 341);
            RectangleIDLabel.Name = "RectangleIDLabel";
            RectangleIDLabel.Size = new Size(27, 20);
            RectangleIDLabel.TabIndex = 21;
            RectangleIDLabel.Text = "ID:";
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(77, 471);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(125, 27);
            RectangleHeightTextBox.TabIndex = 20;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(77, 437);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(125, 27);
            RectangleWidthTextBox.TabIndex = 19;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleYTextBox
            // 
            RectangleYTextBox.Location = new Point(77, 404);
            RectangleYTextBox.Name = "RectangleYTextBox";
            RectangleYTextBox.Size = new Size(125, 27);
            RectangleYTextBox.TabIndex = 18;
            RectangleYTextBox.TextChanged += RectangleYTextBox_TextChanged;
            // 
            // RectangleXTextBox
            // 
            RectangleXTextBox.Location = new Point(77, 371);
            RectangleXTextBox.Name = "RectangleXTextBox";
            RectangleXTextBox.Size = new Size(125, 27);
            RectangleXTextBox.TabIndex = 17;
            RectangleXTextBox.TextChanged += RectangleXTextBox_TextChanged;
            // 
            // RectangleIDTextBox
            // 
            RectangleIDTextBox.Location = new Point(77, 339);
            RectangleIDTextBox.Name = "RectangleIDTextBox";
            RectangleIDTextBox.ReadOnly = true;
            RectangleIDTextBox.Size = new Size(125, 27);
            RectangleIDTextBox.TabIndex = 16;
            // 
            // SelectedRectangleLabel
            // 
            SelectedRectangleLabel.AutoSize = true;
            SelectedRectangleLabel.Location = new Point(7, 315);
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
            RectanglesListBox.Size = new Size(290, 224);
            RectanglesListBox.TabIndex = 14;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglePanel
            // 
            RectanglePanel.AllowDrop = true;
            RectanglePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglePanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanel.Location = new Point(314, 3);
            RectanglePanel.Name = "RectanglePanel";
            RectanglePanel.Size = new Size(341, 545);
            RectanglePanel.TabIndex = 13;
            // 
            // RectangleTableLayout
            // 
            RectangleTableLayout.ColumnCount = 2;
            RectangleTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 311F));
            RectangleTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RectangleTableLayout.Controls.Add(RectanglePanel, 1, 0);
            RectangleTableLayout.Controls.Add(RectanglesGroupBox, 0, 0);
            RectangleTableLayout.Dock = DockStyle.Fill;
            RectangleTableLayout.Location = new Point(0, 0);
            RectangleTableLayout.Margin = new Padding(3, 4, 3, 4);
            RectangleTableLayout.Name = "RectangleTableLayout";
            RectangleTableLayout.RowCount = 1;
            RectangleTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RectangleTableLayout.Size = new Size(658, 551);
            RectangleTableLayout.TabIndex = 15;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleTableLayout);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RectanglesCollisionControl";
            Size = new Size(658, 551);
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
