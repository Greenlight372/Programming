namespace NotesApp.View
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
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedNoteBox = new GroupBox();
            NoteCategoryComboBox = new ComboBox();
            NoteCreationDataTextBox = new TextBox();
            NoteTextTextBox = new TextBox();
            NoteNameTextBox = new TextBox();
            NoteCategoryLabel = new Label();
            NoteCreationDataLabel = new Label();
            NoteTextLabel = new Label();
            NoteNameLabel = new Label();
            NotesListPanel = new Panel();
            AddButton = new Button();
            NoteListBox = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            SelectedNoteBox.SuspendLayout();
            NotesListPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 293F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(SelectedNoteBox, 1, 0);
            tableLayoutPanel1.Controls.Add(NotesListPanel, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(713, 545);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedNoteBox
            // 
            SelectedNoteBox.Controls.Add(NoteCategoryComboBox);
            SelectedNoteBox.Controls.Add(NoteCreationDataTextBox);
            SelectedNoteBox.Controls.Add(NoteTextTextBox);
            SelectedNoteBox.Controls.Add(NoteNameTextBox);
            SelectedNoteBox.Controls.Add(NoteCategoryLabel);
            SelectedNoteBox.Controls.Add(NoteCreationDataLabel);
            SelectedNoteBox.Controls.Add(NoteTextLabel);
            SelectedNoteBox.Controls.Add(NoteNameLabel);
            SelectedNoteBox.Location = new Point(296, 4);
            SelectedNoteBox.Margin = new Padding(3, 4, 3, 4);
            SelectedNoteBox.Name = "SelectedNoteBox";
            SelectedNoteBox.Padding = new Padding(3, 4, 3, 4);
            SelectedNoteBox.Size = new Size(414, 340);
            SelectedNoteBox.TabIndex = 1;
            SelectedNoteBox.TabStop = false;
            SelectedNoteBox.Text = "Selected Note";
            // 
            // NoteCategoryComboBox
            // 
            NoteCategoryComboBox.FormattingEnabled = true;
            NoteCategoryComboBox.Location = new Point(106, 283);
            NoteCategoryComboBox.Margin = new Padding(3, 4, 3, 4);
            NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            NoteCategoryComboBox.Size = new Size(138, 28);
            NoteCategoryComboBox.TabIndex = 7;
            // 
            // NoteCreationDataTextBox
            // 
            NoteCreationDataTextBox.Location = new Point(106, 244);
            NoteCreationDataTextBox.Margin = new Padding(3, 4, 3, 4);
            NoteCreationDataTextBox.Name = "NoteCreationDataTextBox";
            NoteCreationDataTextBox.Size = new Size(297, 27);
            NoteCreationDataTextBox.TabIndex = 6;
            // 
            // NoteTextTextBox
            // 
            NoteTextTextBox.Location = new Point(106, 77);
            NoteTextTextBox.Margin = new Padding(3, 4, 3, 4);
            NoteTextTextBox.Multiline = true;
            NoteTextTextBox.Name = "NoteTextTextBox";
            NoteTextTextBox.ScrollBars = ScrollBars.Vertical;
            NoteTextTextBox.Size = new Size(297, 157);
            NoteTextTextBox.TabIndex = 5;
            // 
            // NoteNameTextBox
            // 
            NoteNameTextBox.Location = new Point(106, 39);
            NoteNameTextBox.Margin = new Padding(3, 4, 3, 4);
            NoteNameTextBox.Name = "NoteNameTextBox";
            NoteNameTextBox.Size = new Size(297, 27);
            NoteNameTextBox.TabIndex = 4;
            // 
            // NoteCategoryLabel
            // 
            NoteCategoryLabel.AutoSize = true;
            NoteCategoryLabel.Location = new Point(33, 287);
            NoteCategoryLabel.Name = "NoteCategoryLabel";
            NoteCategoryLabel.Size = new Size(72, 20);
            NoteCategoryLabel.TabIndex = 3;
            NoteCategoryLabel.Text = "Category:";
            // 
            // NoteCreationDataLabel
            // 
            NoteCreationDataLabel.AutoSize = true;
            NoteCreationDataLabel.Location = new Point(6, 248);
            NoteCreationDataLabel.Name = "NoteCreationDataLabel";
            NoteCreationDataLabel.Size = new Size(104, 20);
            NoteCreationDataLabel.TabIndex = 2;
            NoteCreationDataLabel.Text = "Creation Data:";
            // 
            // NoteTextLabel
            // 
            NoteTextLabel.AutoSize = true;
            NoteTextLabel.Location = new Point(31, 81);
            NoteTextLabel.Name = "NoteTextLabel";
            NoteTextLabel.Size = new Size(76, 20);
            NoteTextLabel.TabIndex = 1;
            NoteTextLabel.Text = "Note Text:";
            // 
            // NoteNameLabel
            // 
            NoteNameLabel.AutoSize = true;
            NoteNameLabel.Location = new Point(18, 43);
            NoteNameLabel.Name = "NoteNameLabel";
            NoteNameLabel.Size = new Size(89, 20);
            NoteNameLabel.TabIndex = 0;
            NoteNameLabel.Text = "Note Name:";
            // 
            // NotesListPanel
            // 
            NotesListPanel.Controls.Add(AddButton);
            NotesListPanel.Controls.Add(NoteListBox);
            NotesListPanel.Dock = DockStyle.Fill;
            NotesListPanel.Location = new Point(3, 4);
            NotesListPanel.Margin = new Padding(3, 4, 3, 4);
            NotesListPanel.Name = "NotesListPanel";
            NotesListPanel.Size = new Size(287, 537);
            NotesListPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(9, 500);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 1;
            AddButton.Text = "AddButton";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // NoteListBox
            // 
            NoteListBox.FormattingEnabled = true;
            NoteListBox.ItemHeight = 20;
            NoteListBox.Location = new Point(3, 4);
            NoteListBox.Margin = new Padding(3, 4, 3, 4);
            NoteListBox.Name = "NoteListBox";
            NoteListBox.Size = new Size(278, 464);
            NoteListBox.TabIndex = 0;
            NoteListBox.SelectedIndexChanged += NoteListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 545);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "NotesApp";
            tableLayoutPanel1.ResumeLayout(false);
            SelectedNoteBox.ResumeLayout(false);
            SelectedNoteBox.PerformLayout();
            NotesListPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SelectedNoteBox;
        private TextBox NoteCreationDataTextBox;
        private TextBox NoteTextTextBox;
        private TextBox NoteNameTextBox;
        private Label NoteCategoryLabel;
        private Label NoteCreationDataLabel;
        private Label NoteTextLabel;
        private Label NoteNameLabel;
        private Panel NotesListPanel;
        private ComboBox NoteCategoryComboBox;
        private ListBox NoteListBox;
        private Button AddButton;
    }
}