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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedNoteBox = new System.Windows.Forms.GroupBox();
            this.CancelChangesPictureBox = new System.Windows.Forms.PictureBox();
            this.ApplyChangesPictureBox = new System.Windows.Forms.PictureBox();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteCreationDataTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextTextBox = new System.Windows.Forms.TextBox();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.NoteCreationDataLabel = new System.Windows.Forms.Label();
            this.NoteTextLabel = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NotesListPanel = new System.Windows.Forms.Panel();
            this.RemoveNotePictureBox = new System.Windows.Forms.PictureBox();
            this.EditNotePictureBox = new System.Windows.Forms.PictureBox();
            this.AddNotePictureBox = new System.Windows.Forms.PictureBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SelectedNoteBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelChangesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyChangesPictureBox)).BeginInit();
            this.NotesListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveNotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNotePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNotePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.SelectedNoteBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NotesListPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedNoteBox
            // 
            this.SelectedNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedNoteBox.Controls.Add(this.CancelChangesPictureBox);
            this.SelectedNoteBox.Controls.Add(this.ApplyChangesPictureBox);
            this.SelectedNoteBox.Controls.Add(this.NoteCategoryComboBox);
            this.SelectedNoteBox.Controls.Add(this.NoteCreationDataTextBox);
            this.SelectedNoteBox.Controls.Add(this.NoteTextTextBox);
            this.SelectedNoteBox.Controls.Add(this.NoteNameTextBox);
            this.SelectedNoteBox.Controls.Add(this.NoteCategoryLabel);
            this.SelectedNoteBox.Controls.Add(this.NoteCreationDataLabel);
            this.SelectedNoteBox.Controls.Add(this.NoteTextLabel);
            this.SelectedNoteBox.Controls.Add(this.NoteNameLabel);
            this.SelectedNoteBox.Location = new System.Drawing.Point(259, 3);
            this.SelectedNoteBox.Name = "SelectedNoteBox";
            this.SelectedNoteBox.Size = new System.Drawing.Size(446, 403);
            this.SelectedNoteBox.TabIndex = 1;
            this.SelectedNoteBox.TabStop = false;
            this.SelectedNoteBox.Text = "Selected Note";
            // 
            // CancelChangesPictureBox
            // 
            this.CancelChangesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChangesPictureBox.Image = global::NotesApp.Properties.Resources.CancelButton;
            this.CancelChangesPictureBox.Location = new System.Drawing.Point(413, 379);
            this.CancelChangesPictureBox.Name = "CancelChangesPictureBox";
            this.CancelChangesPictureBox.Size = new System.Drawing.Size(24, 24);
            this.CancelChangesPictureBox.TabIndex = 9;
            this.CancelChangesPictureBox.TabStop = false;
            this.CancelChangesPictureBox.Click += new System.EventHandler(this.CancelChangesPictureBox_Click);
            // 
            // ApplyChangesPictureBox
            // 
            this.ApplyChangesPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplyChangesPictureBox.Image = global::NotesApp.Properties.Resources.ApplyButton;
            this.ApplyChangesPictureBox.Location = new System.Drawing.Point(383, 379);
            this.ApplyChangesPictureBox.Name = "ApplyChangesPictureBox";
            this.ApplyChangesPictureBox.Size = new System.Drawing.Size(24, 24);
            this.ApplyChangesPictureBox.TabIndex = 8;
            this.ApplyChangesPictureBox.TabStop = false;
            this.ApplyChangesPictureBox.Click += new System.EventHandler(this.ApplyChangesPictureBox_Click);
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(93, 58);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(121, 23);
            this.NoteCategoryComboBox.TabIndex = 7;
            // 
            // NoteCreationDataTextBox
            // 
            this.NoteCreationDataTextBox.Location = new System.Drawing.Point(93, 87);
            this.NoteCreationDataTextBox.Name = "NoteCreationDataTextBox";
            this.NoteCreationDataTextBox.ReadOnly = true;
            this.NoteCreationDataTextBox.Size = new System.Drawing.Size(260, 23);
            this.NoteCreationDataTextBox.TabIndex = 6;
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextTextBox.Location = new System.Drawing.Point(93, 116);
            this.NoteTextTextBox.Multiline = true;
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextTextBox.Size = new System.Drawing.Size(344, 251);
            this.NoteTextTextBox.TabIndex = 5;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Location = new System.Drawing.Point(93, 29);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(260, 23);
            this.NoteNameTextBox.TabIndex = 4;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.NoteNameTextBox_TextChanged);
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Location = new System.Drawing.Point(29, 61);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(58, 15);
            this.NoteCategoryLabel.TabIndex = 3;
            this.NoteCategoryLabel.Text = "Category:";
            // 
            // NoteCreationDataLabel
            // 
            this.NoteCreationDataLabel.AutoSize = true;
            this.NoteCreationDataLabel.Location = new System.Drawing.Point(5, 90);
            this.NoteCreationDataLabel.Name = "NoteCreationDataLabel";
            this.NoteCreationDataLabel.Size = new System.Drawing.Size(82, 15);
            this.NoteCreationDataLabel.TabIndex = 2;
            this.NoteCreationDataLabel.Text = "Creation Data:";
            // 
            // NoteTextLabel
            // 
            this.NoteTextLabel.AutoSize = true;
            this.NoteTextLabel.Location = new System.Drawing.Point(27, 119);
            this.NoteTextLabel.Name = "NoteTextLabel";
            this.NoteTextLabel.Size = new System.Drawing.Size(60, 15);
            this.NoteTextLabel.TabIndex = 1;
            this.NoteTextLabel.Text = "Note Text:";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(16, 32);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(71, 15);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "Note Name:";
            // 
            // NotesListPanel
            // 
            this.NotesListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListPanel.Controls.Add(this.RemoveNotePictureBox);
            this.NotesListPanel.Controls.Add(this.EditNotePictureBox);
            this.NotesListPanel.Controls.Add(this.AddNotePictureBox);
            this.NotesListPanel.Controls.Add(this.NoteListBox);
            this.NotesListPanel.Location = new System.Drawing.Point(3, 3);
            this.NotesListPanel.Name = "NotesListPanel";
            this.NotesListPanel.Size = new System.Drawing.Size(250, 403);
            this.NotesListPanel.TabIndex = 2;
            // 
            // RemoveNotePictureBox
            // 
            this.RemoveNotePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveNotePictureBox.Image = global::NotesApp.Properties.Resources.RemoveNote_New;
            this.RemoveNotePictureBox.Location = new System.Drawing.Point(43, 373);
            this.RemoveNotePictureBox.Name = "RemoveNotePictureBox";
            this.RemoveNotePictureBox.Size = new System.Drawing.Size(34, 31);
            this.RemoveNotePictureBox.TabIndex = 3;
            this.RemoveNotePictureBox.TabStop = false;
            this.RemoveNotePictureBox.Click += new System.EventHandler(this.RemoveNotePictureBox_Click);
            // 
            // EditNotePictureBox
            // 
            this.EditNotePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditNotePictureBox.Image = global::NotesApp.Properties.Resources.EditNote_New;
            this.EditNotePictureBox.Location = new System.Drawing.Point(83, 373);
            this.EditNotePictureBox.Name = "EditNotePictureBox";
            this.EditNotePictureBox.Size = new System.Drawing.Size(34, 31);
            this.EditNotePictureBox.TabIndex = 2;
            this.EditNotePictureBox.TabStop = false;
            this.EditNotePictureBox.Click += new System.EventHandler(this.EditNotePictureBox_Click);
            // 
            // AddNotePictureBox
            // 
            this.AddNotePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddNotePictureBox.Image = global::NotesApp.Properties.Resources.AddNote_New;
            this.AddNotePictureBox.InitialImage = null;
            this.AddNotePictureBox.Location = new System.Drawing.Point(3, 373);
            this.AddNotePictureBox.Name = "AddNotePictureBox";
            this.AddNotePictureBox.Size = new System.Drawing.Size(34, 31);
            this.AddNotePictureBox.TabIndex = 1;
            this.AddNotePictureBox.TabStop = false;
            this.AddNotePictureBox.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.ItemHeight = 15;
            this.NoteListBox.Location = new System.Drawing.Point(3, 3);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(244, 364);
            this.NoteListBox.TabIndex = 0;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(724, 448);
            this.Name = "MainForm";
            this.Text = "NotesApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.SelectedNoteBox.ResumeLayout(false);
            this.SelectedNoteBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelChangesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyChangesPictureBox)).EndInit();
            this.NotesListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveNotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNotePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNotePictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private PictureBox RemoveNotePictureBox;
        private PictureBox EditNotePictureBox;
        private PictureBox AddNotePictureBox;
        private PictureBox CancelChangesPictureBox;
        private PictureBox ApplyChangesPictureBox;
    }
}