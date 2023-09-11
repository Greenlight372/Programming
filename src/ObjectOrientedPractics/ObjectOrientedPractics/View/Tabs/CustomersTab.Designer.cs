namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.itemsPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.customersLabel = new System.Windows.Forms.Label();
            this.selectedCustomerBackgroundPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectedCustomerPanel = new System.Windows.Forms.Panel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundPanel.SuspendLayout();
            this.itemsPanel.SuspendLayout();
            this.selectedCustomerBackgroundPanel.SuspendLayout();
            this.selectedCustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.ColumnCount = 2;
            this.backgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.60156F));
            this.backgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.39844F));
            this.backgroundPanel.Controls.Add(this.itemsPanel, 0, 0);
            this.backgroundPanel.Controls.Add(this.selectedCustomerBackgroundPanel, 1, 0);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.RowCount = 1;
            this.backgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.backgroundPanel.Size = new System.Drawing.Size(512, 448);
            this.backgroundPanel.TabIndex = 1;
            // 
            // itemsPanel
            // 
            this.itemsPanel.Controls.Add(this.removeButton);
            this.itemsPanel.Controls.Add(this.addButton);
            this.itemsPanel.Controls.Add(this.customersListBox);
            this.itemsPanel.Controls.Add(this.customersLabel);
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
            // customersListBox
            // 
            this.customersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.IntegralHeight = false;
            this.customersListBox.ItemHeight = 15;
            this.customersListBox.Location = new System.Drawing.Point(3, 24);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.ScrollAlwaysVisible = true;
            this.customersListBox.Size = new System.Drawing.Size(200, 361);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customersLabel.Location = new System.Drawing.Point(3, 3);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(73, 17);
            this.customersLabel.TabIndex = 0;
            this.customersLabel.Text = "Customers";
            // 
            // selectedCustomerBackgroundPanel
            // 
            this.selectedCustomerBackgroundPanel.ColumnCount = 1;
            this.selectedCustomerBackgroundPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedCustomerBackgroundPanel.Controls.Add(this.selectedCustomerPanel, 0, 0);
            this.selectedCustomerBackgroundPanel.Controls.Add(this.panel2, 0, 1);
            this.selectedCustomerBackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCustomerBackgroundPanel.Location = new System.Drawing.Point(215, 3);
            this.selectedCustomerBackgroundPanel.Name = "selectedCustomerBackgroundPanel";
            this.selectedCustomerBackgroundPanel.RowCount = 2;
            this.selectedCustomerBackgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.16742F));
            this.selectedCustomerBackgroundPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.83258F));
            this.selectedCustomerBackgroundPanel.Size = new System.Drawing.Size(294, 442);
            this.selectedCustomerBackgroundPanel.TabIndex = 1;
            // 
            // selectedCustomerPanel
            // 
            this.selectedCustomerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedCustomerPanel.Controls.Add(this.addressTextBox);
            this.selectedCustomerPanel.Controls.Add(this.AddressLabel);
            this.selectedCustomerPanel.Controls.Add(this.fullnameTextBox);
            this.selectedCustomerPanel.Controls.Add(this.idTextBox);
            this.selectedCustomerPanel.Controls.Add(this.fullnameLabel);
            this.selectedCustomerPanel.Controls.Add(this.idLabel);
            this.selectedCustomerPanel.Controls.Add(this.selectedCustomerLabel);
            this.selectedCustomerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCustomerPanel.Location = new System.Drawing.Point(3, 3);
            this.selectedCustomerPanel.Name = "selectedCustomerPanel";
            this.selectedCustomerPanel.Size = new System.Drawing.Size(288, 229);
            this.selectedCustomerPanel.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(61, 82);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.addressTextBox.Size = new System.Drawing.Size(221, 141);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(0, 85);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(52, 15);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnameTextBox.Location = new System.Drawing.Point(61, 53);
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(221, 23);
            this.fullnameTextBox.TabIndex = 4;
            this.fullnameTextBox.TextChanged += new System.EventHandler(this.fullnameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(61, 24);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(133, 23);
            this.idTextBox.TabIndex = 3;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(0, 56);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(59, 15);
            this.fullnameLabel.TabIndex = 2;
            this.fullnameLabel.Text = "Fullname:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(0, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedCustomerLabel.Location = new System.Drawing.Point(0, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(122, 17);
            this.selectedCustomerLabel.TabIndex = 0;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 201);
            this.panel2.TabIndex = 3;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backgroundPanel);
            this.MinimumSize = new System.Drawing.Size(512, 448);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(512, 448);
            this.backgroundPanel.ResumeLayout(false);
            this.itemsPanel.ResumeLayout(false);
            this.itemsPanel.PerformLayout();
            this.selectedCustomerBackgroundPanel.ResumeLayout(false);
            this.selectedCustomerPanel.ResumeLayout(false);
            this.selectedCustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel backgroundPanel;
        private Panel itemsPanel;
        private Button removeButton;
        private Button addButton;
        private ListBox customersListBox;
        private Label customersLabel;
        private TableLayoutPanel selectedCustomerBackgroundPanel;
        private Panel selectedCustomerPanel;
        private TextBox addressTextBox;
        private Label AddressLabel;
        private TextBox fullnameTextBox;
        private TextBox idTextBox;
        private Label fullnameLabel;
        private Label idLabel;
        private Label selectedCustomerLabel;
        private Panel panel2;
    }
}
