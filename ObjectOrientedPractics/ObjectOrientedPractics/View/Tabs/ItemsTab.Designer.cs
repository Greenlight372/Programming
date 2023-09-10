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
            this.backgroundPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectedItemsPanel = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.selectedItemsLabel = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.backgroundPanel.SuspendLayout();
            this.selectedItemsPanel.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.ColumnCount = 2;
            this.backgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60156F));
            this.backgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.39844F));
            this.backgroundPanel.Controls.Add(this.selectedItemsPanel, 1, 0);
            this.backgroundPanel.Controls.Add(this.itemsPanel, 0, 0);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.RowCount = 1;
            this.backgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backgroundPanel.Size = new System.Drawing.Size(512, 448);
            this.backgroundPanel.TabIndex = 0;
            // 
            // selectedItemsPanel
            // 
            this.selectedItemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedItemsPanel.Controls.Add(this.descriptionTextBox);
            this.selectedItemsPanel.Controls.Add(this.descriptionLabel);
            this.selectedItemsPanel.Controls.Add(this.nameTextBox);
            this.selectedItemsPanel.Controls.Add(this.nameLabel);
            this.selectedItemsPanel.Controls.Add(this.costTextBox);
            this.selectedItemsPanel.Controls.Add(this.idTextBox);
            this.selectedItemsPanel.Controls.Add(this.costLabel);
            this.selectedItemsPanel.Controls.Add(this.idLabel);
            this.selectedItemsPanel.Controls.Add(this.selectedItemsLabel);
            this.selectedItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemsPanel.Location = new System.Drawing.Point(215, 3);
            this.selectedItemsPanel.Name = "selectedItemsPanel";
            this.selectedItemsPanel.Size = new System.Drawing.Size(294, 442);
            this.selectedItemsPanel.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(3, 222);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(288, 151);
            this.descriptionTextBox.TabIndex = 8;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 204);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(3, 106);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.nameTextBox.Size = new System.Drawing.Size(288, 90);
            this.nameTextBox.TabIndex = 6;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costTextBox.Location = new System.Drawing.Point(43, 56);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(133, 23);
            this.costTextBox.TabIndex = 4;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(43, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(133, 23);
            this.idTextBox.TabIndex = 3;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(3, 59);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 15);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(3, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // selectedItemsLabel
            // 
            this.selectedItemsLabel.AutoSize = true;
            this.selectedItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedItemsLabel.Location = new System.Drawing.Point(3, 3);
            this.selectedItemsLabel.Name = "selectedItemsLabel";
            this.selectedItemsLabel.Size = new System.Drawing.Size(97, 17);
            this.selectedItemsLabel.TabIndex = 0;
            this.selectedItemsLabel.Text = "Selected Items";
            // 
            // itemsPanel
            // 
            this.itemsPanel.Controls.Add(this.removeButton);
            this.itemsPanel.Controls.Add(this.addButton);
            this.itemsPanel.Controls.Add(this.itemsListBox);
            this.itemsPanel.Controls.Add(this.itemsLabel);
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.Location = new System.Drawing.Point(3, 3);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(206, 442);
            this.itemsPanel.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(79, 391);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 45);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(3, 391);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 45);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.IntegralHeight = false;
            this.itemsListBox.ItemHeight = 15;
            this.itemsListBox.Location = new System.Drawing.Point(3, 24);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.ScrollAlwaysVisible = true;
            this.itemsListBox.Size = new System.Drawing.Size(200, 349);
            this.itemsListBox.TabIndex = 1;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsLabel.Location = new System.Drawing.Point(3, 3);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(42, 17);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(512, 448);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(512, 448);
            this.backgroundPanel.ResumeLayout(false);
            this.selectedItemsPanel.ResumeLayout(false);
            this.selectedItemsPanel.PerformLayout();
            this.itemsPanel.ResumeLayout(false);
            this.itemsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel backgroundPanel;
        private Panel selectedItemsPanel;
        private Label selectedItemsLabel;
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
    }
}
