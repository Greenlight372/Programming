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
            Enums = new TabPage();
            EnumsLayoutPanel = new TableLayoutPanel();
            EnumsLayoutSubpanel = new TableLayoutPanel();
            seasonsHandleControl1 = new Controls.SeasonsHandleControl();
            weekdayControl1 = new Controls.WeekdayControl();
            EnumsTabControl = new TabControl();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new Controls.RectanglesCollisionControl();
            enumerationsControl1 = new Controls.EnumerationsControl();
            rectanglesControl1 = new Controls.RectanglesControl();
            moviesControl1 = new Controls.MoviesControl();
            Classes.SuspendLayout();
            ClassesLayoutPanel.SuspendLayout();
            Enums.SuspendLayout();
            EnumsLayoutPanel.SuspendLayout();
            EnumsLayoutSubpanel.SuspendLayout();
            EnumsTabControl.SuspendLayout();
            Rectangles.SuspendLayout();
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
            ClassesLayoutPanel.Controls.Add(rectanglesControl1, 0, 0);
            ClassesLayoutPanel.Controls.Add(moviesControl1, 1, 0);
            ClassesLayoutPanel.Location = new Point(3, 3);
            ClassesLayoutPanel.Name = "ClassesLayoutPanel";
            ClassesLayoutPanel.RowCount = 1;
            ClassesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ClassesLayoutPanel.Size = new Size(570, 407);
            ClassesLayoutPanel.TabIndex = 0;
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
            EnumsLayoutPanel.Controls.Add(EnumsLayoutSubpanel, 0, 1);
            EnumsLayoutPanel.Controls.Add(enumerationsControl1, 0, 0);
            EnumsLayoutPanel.Dock = DockStyle.Fill;
            EnumsLayoutPanel.Location = new Point(3, 2);
            EnumsLayoutPanel.Name = "EnumsLayoutPanel";
            EnumsLayoutPanel.RowCount = 2;
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 53.54523F));
            EnumsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 46.45477F));
            EnumsLayoutPanel.Size = new Size(570, 409);
            EnumsLayoutPanel.TabIndex = 5;
            // 
            // EnumsLayoutSubpanel
            // 
            EnumsLayoutSubpanel.ColumnCount = 2;
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Controls.Add(seasonsHandleControl1, 0, 0);
            EnumsLayoutSubpanel.Controls.Add(weekdayControl1, 1, 0);
            EnumsLayoutSubpanel.Dock = DockStyle.Fill;
            EnumsLayoutSubpanel.Location = new Point(3, 222);
            EnumsLayoutSubpanel.Name = "EnumsLayoutSubpanel";
            EnumsLayoutSubpanel.RowCount = 1;
            EnumsLayoutSubpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EnumsLayoutSubpanel.Size = new Size(564, 184);
            EnumsLayoutSubpanel.TabIndex = 3;
            // 
            // seasonsHandleControl1
            // 
            seasonsHandleControl1.Dock = DockStyle.Fill;
            seasonsHandleControl1.Location = new Point(3, 3);
            seasonsHandleControl1.Name = "seasonsHandleControl1";
            seasonsHandleControl1.Size = new Size(276, 178);
            seasonsHandleControl1.TabIndex = 3;
            // 
            // weekdayControl1
            // 
            weekdayControl1.Dock = DockStyle.Fill;
            weekdayControl1.Location = new Point(285, 3);
            weekdayControl1.Name = "weekdayControl1";
            weekdayControl1.Size = new Size(276, 178);
            weekdayControl1.TabIndex = 4;
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
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Margin = new Padding(3, 2, 3, 2);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(576, 413);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(576, 413);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Dock = DockStyle.Fill;
            enumerationsControl1.Location = new Point(3, 3);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(564, 213);
            enumerationsControl1.TabIndex = 4;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Dock = DockStyle.Fill;
            rectanglesControl1.Location = new Point(3, 3);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(279, 401);
            rectanglesControl1.TabIndex = 5;
            // 
            // moviesControl1
            // 
            moviesControl1.Dock = DockStyle.Fill;
            moviesControl1.Location = new Point(288, 3);
            moviesControl1.Name = "moviesControl1";
            moviesControl1.Size = new Size(279, 401);
            moviesControl1.TabIndex = 6;
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
            MinimumSize = new Size(600, 474);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Classes.ResumeLayout(false);
            Classes.PerformLayout();
            ClassesLayoutPanel.ResumeLayout(false);
            Enums.ResumeLayout(false);
            EnumsLayoutPanel.ResumeLayout(false);
            EnumsLayoutSubpanel.ResumeLayout(false);
            EnumsTabControl.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Classes;
        private TableLayoutPanel ClassesLayoutPanel;
        private TabPage Enums;
        private TabControl EnumsTabControl;
        private TableLayoutPanel EnumsLayoutPanel;
        private TableLayoutPanel EnumsLayoutSubpanel;
        private TabPage Rectangles;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private Controls.SeasonsHandleControl seasonsHandleControl1;
        private Controls.WeekdayControl weekdayControl1;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
        private Controls.EnumerationsControl enumerationsControl1;
    }
}