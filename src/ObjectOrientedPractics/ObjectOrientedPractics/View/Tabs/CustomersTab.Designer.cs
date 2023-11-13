using ObjectOrientedPractics.View.Controls;

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
            editButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            customersListBox = new ListBox();
            customersLabel = new Label();
            selectedCustomerBackgroundPanel = new TableLayoutPanel();
            applyChangesPanel = new Panel();
            cancelButton = new Button();
            applyButton = new Button();
            selectedCustomerPanel = new Panel();
            isPriorityCheckBox = new CheckBox();
            fullnameTextBox = new TextBox();
            idTextBox = new TextBox();
            fullnameLabel = new Label();
            idLabel = new Label();
            selectedCustomerLabel = new Label();
            addressControlPanel = new Panel();
            addressControl = new AddressControl();
            discountsPanel = new Panel();
            removeDiscountButton = new Button();
            addDiscountButton = new Button();
            discountsListBox = new ListBox();
            discountsLabel = new Label();
            backgroundPanel.SuspendLayout();
            itemsPanel.SuspendLayout();
            selectedCustomerBackgroundPanel.SuspendLayout();
            applyChangesPanel.SuspendLayout();
            selectedCustomerPanel.SuspendLayout();
            addressControlPanel.SuspendLayout();
            discountsPanel.SuspendLayout();
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
            backgroundPanel.Size = new Size(512, 600);
            backgroundPanel.TabIndex = 1;
            // 
            // itemsPanel
            // 
            itemsPanel.Controls.Add(editButton);
            itemsPanel.Controls.Add(removeButton);
            itemsPanel.Controls.Add(addButton);
            itemsPanel.Controls.Add(customersListBox);
            itemsPanel.Controls.Add(customersLabel);
            itemsPanel.Dock = DockStyle.Fill;
            itemsPanel.Location = new Point(3, 3);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.Size = new Size(206, 594);
            itemsPanel.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editButton.Location = new Point(142, 549);
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
            removeButton.Location = new Point(73, 549);
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
            addButton.Location = new Point(3, 549);
            addButton.Name = "addButton";
            addButton.Size = new Size(64, 45);
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
            customersListBox.Size = new Size(200, 519);
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
            selectedCustomerBackgroundPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selectedCustomerBackgroundPanel.Controls.Add(applyChangesPanel, 0, 3);
            selectedCustomerBackgroundPanel.Controls.Add(selectedCustomerPanel, 0, 0);
            selectedCustomerBackgroundPanel.Controls.Add(addressControlPanel, 0, 1);
            selectedCustomerBackgroundPanel.Controls.Add(discountsPanel, 0, 2);
            selectedCustomerBackgroundPanel.Dock = DockStyle.Fill;
            selectedCustomerBackgroundPanel.Location = new Point(215, 3);
            selectedCustomerBackgroundPanel.Name = "selectedCustomerBackgroundPanel";
            selectedCustomerBackgroundPanel.RowCount = 4;
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.3529415F));
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35.0588226F));
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5882339F));
            selectedCustomerBackgroundPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 167F));
            selectedCustomerBackgroundPanel.Size = new Size(294, 594);
            selectedCustomerBackgroundPanel.TabIndex = 1;
            // 
            // applyChangesPanel
            // 
            applyChangesPanel.Controls.Add(cancelButton);
            applyChangesPanel.Controls.Add(applyButton);
            applyChangesPanel.Dock = DockStyle.Fill;
            applyChangesPanel.Location = new Point(3, 428);
            applyChangesPanel.Name = "applyChangesPanel";
            applyChangesPanel.Size = new Size(288, 163);
            applyChangesPanel.TabIndex = 5;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(213, 139);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Tag = "Apply";
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // applyButton
            // 
            applyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            applyButton.Location = new Point(132, 139);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 0;
            applyButton.Tag = "Apply";
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // selectedCustomerPanel
            // 
            selectedCustomerPanel.BackColor = SystemColors.ControlLightLight;
            selectedCustomerPanel.Controls.Add(isPriorityCheckBox);
            selectedCustomerPanel.Controls.Add(fullnameTextBox);
            selectedCustomerPanel.Controls.Add(idTextBox);
            selectedCustomerPanel.Controls.Add(fullnameLabel);
            selectedCustomerPanel.Controls.Add(idLabel);
            selectedCustomerPanel.Controls.Add(selectedCustomerLabel);
            selectedCustomerPanel.Dock = DockStyle.Fill;
            selectedCustomerPanel.Location = new Point(3, 3);
            selectedCustomerPanel.Name = "selectedCustomerPanel";
            selectedCustomerPanel.Size = new Size(288, 106);
            selectedCustomerPanel.TabIndex = 2;
            // 
            // isPriorityCheckBox
            // 
            isPriorityCheckBox.AutoSize = true;
            isPriorityCheckBox.Location = new Point(61, 82);
            isPriorityCheckBox.Name = "isPriorityCheckBox";
            isPriorityCheckBox.Size = new Size(75, 19);
            isPriorityCheckBox.TabIndex = 5;
            isPriorityCheckBox.Text = "Is Priority";
            isPriorityCheckBox.UseVisualStyleBackColor = true;
            isPriorityCheckBox.CheckedChanged += isPriorityCheckBox_CheckedChanged;
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
            addressControlPanel.Controls.Add(addressControl);
            addressControlPanel.Dock = DockStyle.Fill;
            addressControlPanel.Location = new Point(3, 115);
            addressControlPanel.Name = "addressControlPanel";
            addressControlPanel.Size = new Size(288, 143);
            addressControlPanel.TabIndex = 3;
            // 
            // addressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = null;
            address1.Street = null;
            addressControl.Address = address1;
            addressControl.Dock = DockStyle.Fill;
            addressControl.IsReadOnly = false;
            addressControl.Location = new Point(0, 0);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(288, 143);
            addressControl.TabIndex = 0;
            addressControl.Enter += addressControl_Enter;
            addressControl.Leave += addressControl_Leave;
            // 
            // discountsPanel
            // 
            discountsPanel.Controls.Add(removeDiscountButton);
            discountsPanel.Controls.Add(addDiscountButton);
            discountsPanel.Controls.Add(discountsListBox);
            discountsPanel.Controls.Add(discountsLabel);
            discountsPanel.Dock = DockStyle.Fill;
            discountsPanel.Location = new Point(3, 264);
            discountsPanel.Name = "discountsPanel";
            discountsPanel.Size = new Size(288, 158);
            discountsPanel.TabIndex = 6;
            // 
            // removeDiscountButton
            // 
            removeDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeDiscountButton.Location = new Point(224, 71);
            removeDiscountButton.Name = "removeDiscountButton";
            removeDiscountButton.Size = new Size(64, 45);
            removeDiscountButton.TabIndex = 4;
            removeDiscountButton.Text = "Remove";
            removeDiscountButton.UseVisualStyleBackColor = true;
            removeDiscountButton.Click += removeDiscountButton_Click;
            // 
            // addDiscountButton
            // 
            addDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addDiscountButton.Location = new Point(224, 20);
            addDiscountButton.Name = "addDiscountButton";
            addDiscountButton.Size = new Size(64, 45);
            addDiscountButton.TabIndex = 3;
            addDiscountButton.Text = "Add";
            addDiscountButton.UseVisualStyleBackColor = true;
            addDiscountButton.Click += addDiscountButton_Click;
            // 
            // discountsListBox
            // 
            discountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            discountsListBox.FormattingEnabled = true;
            discountsListBox.IntegralHeight = false;
            discountsListBox.ItemHeight = 15;
            discountsListBox.Location = new Point(0, 20);
            discountsListBox.Name = "discountsListBox";
            discountsListBox.ScrollAlwaysVisible = true;
            discountsListBox.Size = new Size(218, 135);
            discountsListBox.TabIndex = 2;
            // 
            // discountsLabel
            // 
            discountsLabel.AutoSize = true;
            discountsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            discountsLabel.Location = new Point(0, 0);
            discountsLabel.Name = "discountsLabel";
            discountsLabel.Size = new Size(69, 17);
            discountsLabel.TabIndex = 1;
            discountsLabel.Text = "Discounts";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(backgroundPanel);
            MinimumSize = new Size(512, 600);
            Name = "CustomersTab";
            Size = new Size(512, 600);
            backgroundPanel.ResumeLayout(false);
            itemsPanel.ResumeLayout(false);
            itemsPanel.PerformLayout();
            selectedCustomerBackgroundPanel.ResumeLayout(false);
            applyChangesPanel.ResumeLayout(false);
            selectedCustomerPanel.ResumeLayout(false);
            selectedCustomerPanel.PerformLayout();
            addressControlPanel.ResumeLayout(false);
            discountsPanel.ResumeLayout(false);
            discountsPanel.PerformLayout();
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
        private Button editButton;
        private AddressControl addressControl;
        private CheckBox isPriorityCheckBox;
        private Panel applyChangesPanel;
        private Button cancelButton;
        private Button applyButton;
        private Panel discountsPanel;
        private Button removeDiscountButton;
        private Button addDiscountButton;
        private ListBox discountsListBox;
        private Label discountsLabel;
    }
}
