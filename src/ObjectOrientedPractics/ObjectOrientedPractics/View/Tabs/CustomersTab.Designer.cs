﻿using ObjectOrientedPractics.View.Controls;

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
            Model.Address address1 = new Model.Address();
            backgroundPanel = new TableLayoutPanel();
            itemsPanel = new Panel();
            removeButton = new Button();
            addButton = new Button();
            customersListBox = new ListBox();
            customersLabel = new Label();
            selectedCustomerBackgroundPanel = new TableLayoutPanel();
            selectedCustomerPanel = new Panel();
            fullnameTextBox = new TextBox();
            idTextBox = new TextBox();
            fullnameLabel = new Label();
            idLabel = new Label();
            selectedCustomerLabel = new Label();
            addressControlPanel = new Panel();
            customerAddressControl = new AddressControl();
            backgroundPanel.SuspendLayout();
            itemsPanel.SuspendLayout();
            selectedCustomerBackgroundPanel.SuspendLayout();
            selectedCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundPanel
            // 
            backgroundPanel.ColumnCount = 2;
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.40625F));
            backgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.59375F));
            backgroundPanel.Controls.Add(itemsPanel, 0, 0);
            backgroundPanel.Controls.Add(selectedCustomerBackgroundPanel, 1, 0);
            backgroundPanel.Dock = DockStyle.Fill;
            backgroundPanel.Location = new Point(0, 0);
            backgroundPanel.Name = "backgroundPanel";
            backgroundPanel.RowCount = 1;
            backgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            backgroundPanel.Size = new Size(512, 448);
            backgroundPanel.TabIndex = 1;
            // 
            // itemsPanel
            // 
            itemsPanel.Controls.Add(removeButton);
            itemsPanel.Controls.Add(addButton);
            itemsPanel.Controls.Add(customersListBox);
            itemsPanel.Controls.Add(customersLabel);
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
            // customersListBox
            // 
            customersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customersListBox.FormattingEnabled = true;
            customersListBox.IntegralHeight = false;
            customersListBox.ItemHeight = 15;
            customersListBox.Location = new Point(3, 24);
            customersListBox.Name = "customersListBox";
            customersListBox.ScrollAlwaysVisible = true;
            customersListBox.Size = new Size(200, 361);
            customersListBox.TabIndex = 1;
            customersListBox.SelectedIndexChanged += customersListBox_SelectedIndexChanged;
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customersLabel.Location = new Point(3, 3);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(73, 17);
            customersLabel.TabIndex = 0;
            customersLabel.Text = "Customers";
            // 
            // selectedCustomerBackgroundPanel
            // 
            selectedCustomerBackgroundPanel.ColumnCount = 1;
            selectedCustomerBackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            selectedCustomerBackgroundPanel.Controls.Add(selectedCustomerPanel, 0, 0);
            selectedCustomerBackgroundPanel.Controls.Add(addressControlPanel, 0, 1);
            selectedCustomerBackgroundPanel.Dock = DockStyle.Fill;
            selectedCustomerBackgroundPanel.Location = new Point(215, 3);
            selectedCustomerBackgroundPanel.Name = "selectedCustomerBackgroundPanel";
            selectedCustomerBackgroundPanel.RowCount = 2;
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 76.47059F));
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.5294113F));
            selectedCustomerBackgroundPanel.Size = new Size(294, 442);
            selectedCustomerBackgroundPanel.TabIndex = 1;
            // 
            // selectedCustomerPanel
            // 
            selectedCustomerPanel.BackColor = SystemColors.ControlLightLight;
            selectedCustomerPanel.Controls.Add(customerAddressControl);
            selectedCustomerPanel.Controls.Add(fullnameTextBox);
            selectedCustomerPanel.Controls.Add(idTextBox);
            selectedCustomerPanel.Controls.Add(fullnameLabel);
            selectedCustomerPanel.Controls.Add(idLabel);
            selectedCustomerPanel.Controls.Add(selectedCustomerLabel);
            selectedCustomerPanel.Dock = DockStyle.Fill;
            selectedCustomerPanel.Location = new Point(3, 3);
            selectedCustomerPanel.Name = "selectedCustomerPanel";
            selectedCustomerPanel.Size = new Size(288, 332);
            selectedCustomerPanel.TabIndex = 2;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullnameTextBox.Location = new Point(61, 53);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(221, 23);
            fullnameTextBox.TabIndex = 4;
            fullnameTextBox.TextChanged += fullnameTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(61, 24);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(133, 23);
            idTextBox.TabIndex = 3;
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new Point(0, 56);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new Size(59, 15);
            fullnameLabel.TabIndex = 2;
            fullnameLabel.Text = "Fullname:";
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
            // selectedCustomerLabel
            // 
            selectedCustomerLabel.AutoSize = true;
            selectedCustomerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedCustomerLabel.Location = new Point(0, 0);
            selectedCustomerLabel.Name = "selectedCustomerLabel";
            selectedCustomerLabel.Size = new Size(122, 17);
            selectedCustomerLabel.TabIndex = 0;
            selectedCustomerLabel.Text = "Selected Customer";
            // 
            // addressControlPanel
            // 
            addressControlPanel.Dock = DockStyle.Fill;
            addressControlPanel.Location = new Point(3, 341);
            addressControlPanel.Name = "addressControlPanel";
            addressControlPanel.Size = new Size(288, 98);
            addressControlPanel.TabIndex = 3;
            // 
            // customerAddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "";
            address1.Street = "";
            customerAddressControl.AddressProperty = address1;
            customerAddressControl.Location = new Point(0, 82);
            customerAddressControl.Name = "customerAddressControl";
            customerAddressControl.Size = new Size(291, 247);
            customerAddressControl.TabIndex = 5;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            MinimumSize = new Size(512, 448);
            Name = "CustomersTab";
            Size = new Size(512, 448);
            backgroundPanel.ResumeLayout(false);
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            selectedCustomerBackgroundPanel.ResumeLayout(false);
            selectedCustomerPanel.ResumeLayout(false);
            selectedCustomerPanel.PerformLayout();
            ResumeLayout(false);
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
        private TextBox fullnameTextBox;
        private TextBox idTextBox;
        private Label fullnameLabel;
        private Label idLabel;
        private Label selectedCustomerLabel;
        private Panel addressControlPanel;
        private AddressControl customerAddressControl;
    }
}