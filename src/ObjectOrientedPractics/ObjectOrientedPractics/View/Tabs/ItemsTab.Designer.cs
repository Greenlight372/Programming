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
            itemsPanel = new Panel();
            removeButton = new Button();
            addButton = new Button();
            itemsListBox = new ListBox();
            itemsLabel = new Label();
            backgroundPanel.SuspendLayout();
            selectedItemPanel.SuspendLayout();
            itemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.ColumnCount = 2;
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.60156F));
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.39844F));
            backgroundPanel.Controls.Add(selectedItemPanel, 1, 0);
            backgroundPanel.Controls.Add(itemsPanel, 0, 0);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.RowCount = 1;
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            backgroundPanel.Size = new Size(512, 448);
            backgroundPanel.TabIndex = 0;
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
            selectedItemPanel.Location = new Point(215, 3);
            selectedItemPanel.Name = "selectedItemPanel";
            selectedItemPanel.Size = new Size(294, 442);
            selectedItemPanel.TabIndex = 1;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.ImeMode = ImeMode.Off;
            categoryComboBox.Location = new Point(64, 85);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(133, 23);
            categoryComboBox.TabIndex = 10;
            categoryComboBox.SelectedValueChanged += categoryComboBox_SelectedValueChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(3, 88);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 9;
            categoryLabel.Text = "Category:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(3, 251);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(288, 163);
            descriptionTextBox.TabIndex = 8;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(3, 233);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 7;
            descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(3, 135);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ScrollBars = ScrollBars.Vertical;
            nameTextBox.Size = new Size(288, 90);
            nameTextBox.TabIndex = 6;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // costTextBox
            // 
            costTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costTextBox.Location = new Point(64, 56);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(133, 23);
            costTextBox.TabIndex = 4;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(64, 27);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(133, 23);
            idTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(3, 59);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 2;
            costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // selectedItemLabel
            // 
            selectedItemLabel.AutoSize = true;
            selectedItemLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedItemLabel.Location = new Point(3, 3);
            selectedItemLabel.Name = "selectedItemLabel";
            selectedItemLabel.Size = new Size(97, 17);
            selectedItemLabel.TabIndex = 0;
            selectedItemLabel.Text = "Selected Items";
            // 
            // itemsPanel
            // 
            itemsPanel.Controls.Add(removeButton);
            itemsPanel.Controls.Add(addButton);
            itemsPanel.Controls.Add(itemsListBox);
            itemsPanel.Controls.Add(itemsLabel);
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(3, 3);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(206, 442);
            itemsPanel.TabIndex = 0;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(79, 391);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 45);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 391);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 45);
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
            itemsListBox.Location = new Point(3, 24);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.ScrollAlwaysVisible = true;
            itemsListBox.Size = new Size(200, 361);
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
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            MinimumSize = new Size(512, 448);
            Name = "ItemsTab";
            Size = new Size(512, 448);
            backgroundPanel.ResumeLayout(false);
            selectedItemPanel.ResumeLayout(false);
            selectedItemPanel.PerformLayout();
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel backgroundPanel;
        private Panel selectedItemPanel;
        private Label selectedItemLabel;
        private Panel itemsPanel;
        private Label itemsLabel;
        private Button removeButton;
        private Button addButton;
        private ListBox itemsListBox;
        private Label costLabel;
        private Label idLabel;
        private TextBox costTextBox;
        private TextBox idTextBox;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
    }
}
