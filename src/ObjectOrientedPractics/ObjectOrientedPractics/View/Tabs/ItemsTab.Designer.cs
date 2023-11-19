namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            backgroundPanel = new TableLayoutPanel();
            itemsPanel = new Panel();
            orderComboBox = new ComboBox();
            orderLabel = new Label();
            findTextBox = new TextBox();
            findLabel = new Label();
            editButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            itemsListBox = new ListBox();
            itemsLabel = new Label();
            selectedItemLayoutPanel = new TableLayoutPanel();
            selectedItemPanel = new Panel();
            categoryComboBox = new ComboBox();
            categoryLabel = new Label();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            costTextBox = new TextBox();
            idTextBox = new TextBox();
            costLabel = new Label();
            idLabel = new Label();
            selectedItemLabel = new Label();
            buttonsPanel = new Panel();
            applyButton = new Button();
            cancelButton = new Button();
            backgroundPanel.SuspendLayout();
            itemsPanel.SuspendLayout();
            selectedItemLayoutPanel.SuspendLayout();
            selectedItemPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.ColumnCount = 2;
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.140625F));
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.859375F));
            backgroundPanel.Controls.Add(itemsPanel, 0, 0);
            backgroundPanel.Controls.Add(selectedItemLayoutPanel, 1, 0);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.RowCount = 1;
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            backgroundPanel.Size = new Size(512, 448);
            backgroundPanel.TabIndex = 0;
            // 
            // itemsPanel
            // 
            itemsPanel.Controls.Add(orderComboBox);
            itemsPanel.Controls.Add(orderLabel);
            itemsPanel.Controls.Add(findTextBox);
            itemsPanel.Controls.Add(findLabel);
            itemsPanel.Controls.Add(editButton);
            itemsPanel.Controls.Add(removeButton);
            itemsPanel.Controls.Add(addButton);
            itemsPanel.Controls.Add(itemsListBox);
            itemsPanel.Controls.Add(itemsLabel);
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(3, 3);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(220, 442);
            itemsPanel.TabIndex = 0;
            // 
            // orderComboBox
            // 
            orderComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            orderComboBox.FormattingEnabled = true;
            orderComboBox.Items.AddRange(new object[] { "Name (Alphabetic)", "Cost (Ascending)", "Cost (Descending)" });
            orderComboBox.Location = new Point(65, 371);
            orderComboBox.Name = "orderComboBox";
            orderComboBox.Size = new Size(152, 23);
            orderComboBox.TabIndex = 8;
            orderComboBox.SelectedIndexChanged += orderComboBox_SelectedIndexChanged;
            // 
            // orderLabel
            // 
            orderLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            orderLabel.AutoSize = true;
            orderLabel.Location = new Point(3, 374);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(56, 15);
            orderLabel.TabIndex = 7;
            orderLabel.Text = "Order by:";
            // 
            // findTextBox
            // 
            findTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            findTextBox.Location = new Point(65, 27);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(152, 23);
            findTextBox.TabIndex = 6;
            findTextBox.TextChanged += findTextBox_TextChanged;
            // 
            // findLabel
            // 
            findLabel.AutoSize = true;
            findLabel.Location = new Point(3, 30);
            findLabel.Name = "findLabel";
            findLabel.Size = new Size(33, 15);
            findLabel.TabIndex = 5;
            findLabel.Text = "Find:";
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editButton.Location = new Point(142, 397);
            editButton.Name = "editButton";
            editButton.Size = new Size(64, 45);
            editButton.TabIndex = 4;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(73, 397);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(64, 45);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 397);
            addButton.Name = "addButton";
            addButton.Size = new Size(64, 45);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.IntegralHeight = false;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(3, 56);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.ScrollAlwaysVisible = true;
            itemsListBox.Size = new Size(214, 309);
            itemsListBox.TabIndex = 1;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemsLabel.Location = new Point(3, 3);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(42, 17);
            itemsLabel.TabIndex = 0;
            itemsLabel.Text = "Items";
            // 
            // selectedItemLayoutPanel
            // 
            selectedItemLayoutPanel.ColumnCount = 1;
            selectedItemLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            selectedItemLayoutPanel.Controls.Add(selectedItemPanel, 0, 0);
            selectedItemLayoutPanel.Controls.Add(buttonsPanel, 0, 1);
            selectedItemLayoutPanel.Dock = DockStyle.Fill;
            selectedItemLayoutPanel.Location = new Point(229, 3);
            selectedItemLayoutPanel.Name = "selectedItemLayoutPanel";
            selectedItemLayoutPanel.RowCount = 2;
            selectedItemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 93.43891F));
            selectedItemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.561086F));
            selectedItemLayoutPanel.Size = new Size(280, 442);
            selectedItemLayoutPanel.TabIndex = 1;
            // 
            // selectedItemPanel
            // 
            selectedItemPanel.BackColor = SystemColors.ControlLightLight;
            selectedItemPanel.Controls.Add(categoryComboBox);
            selectedItemPanel.Controls.Add(categoryLabel);
            selectedItemPanel.Controls.Add(descriptionTextBox);
            selectedItemPanel.Controls.Add(descriptionLabel);
            selectedItemPanel.Controls.Add(nameTextBox);
            selectedItemPanel.Controls.Add(nameLabel);
            selectedItemPanel.Controls.Add(costTextBox);
            selectedItemPanel.Controls.Add(idTextBox);
            selectedItemPanel.Controls.Add(costLabel);
            selectedItemPanel.Controls.Add(idLabel);
            selectedItemPanel.Controls.Add(selectedItemLabel);
            selectedItemPanel.Dock = DockStyle.Fill;
            selectedItemPanel.Location = new Point(3, 3);
            selectedItemPanel.Name = "selectedItemPanel";
            selectedItemPanel.Size = new Size(274, 407);
            selectedItemPanel.TabIndex = 2;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.ImeMode = ImeMode.Off;
            categoryComboBox.Location = new Point(61, 82);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(210, 23);
            categoryComboBox.TabIndex = 10;
            categoryComboBox.SelectedValueChanged += categoryComboBox_SelectedValueChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(0, 85);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(0, 248);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(271, 153);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(0, 230);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(0, 132);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ScrollBars = ScrollBars.Vertical;
            nameTextBox.Size = new Size(271, 90);
            nameTextBox.TabIndex = 6;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(0, 114);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // costTextBox
            // 
            costTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costTextBox.Location = new Point(61, 53);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(210, 23);
            costTextBox.TabIndex = 4;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(61, 24);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(210, 23);
            idTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(0, 56);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 2;
            costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(0, 27);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // selectedItemLabel
            // 
            selectedItemLabel.AutoSize = true;
            selectedItemLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedItemLabel.Location = new Point(0, 0);
            selectedItemLabel.Name = "selectedItemLabel";
            selectedItemLabel.Size = new Size(97, 17);
            selectedItemLabel.TabIndex = 0;
            selectedItemLabel.Text = "Selected Items";
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(applyButton);
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(3, 416);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(274, 23);
            buttonsPanel.TabIndex = 3;
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.Location = new Point(115, -1);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 5;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(196, -1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            MinimumSize = new Size(512, 448);
            Name = "ItemsTab";
            Size = new Size(512, 448);
            backgroundPanel.ResumeLayout(false);
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            selectedItemLayoutPanel.ResumeLayout(false);
            selectedItemPanel.ResumeLayout(false);
            selectedItemPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel backgroundPanel;
        private Panel itemsPanel;
        private Label itemsLabel;
        private Button removeButton;
        private Button addButton;
        private ListBox itemsListBox;
        private TableLayoutPanel selectedItemLayoutPanel;
        private Panel selectedItemPanel;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private TextBox costTextBox;
        private TextBox idTextBox;
        private Label costLabel;
        private Label idLabel;
        private Label selectedItemLabel;
        private Panel buttonsPanel;
        private Button applyButton;
        private Button cancelButton;
        private Button editButton;
        private ComboBox orderComboBox;
        private Label orderLabel;
        private TextBox findTextBox;
        private Label findLabel;
    }
}
