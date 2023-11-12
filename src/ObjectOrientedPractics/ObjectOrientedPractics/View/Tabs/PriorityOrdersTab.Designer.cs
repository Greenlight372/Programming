namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            tableLayoutPanel = new TableLayoutPanel();
            priorityOrdersPanel = new Panel();
            deliveryTimeComboBox = new ComboBox();
            deliveryTimeLabel = new Label();
            priorityOptionsLabel = new Label();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            createdTextBox = new TextBox();
            idTextBox = new TextBox();
            createdLabel = new Label();
            Idlabel = new Label();
            selectedOrderLabel = new Label();
            addressControlPanel = new Panel();
            addressControl = new Controls.AddressControl();
            orderItemsPanel = new Panel();
            money = new Label();
            amountLabel = new Label();
            clearButton = new Button();
            removeButton = new Button();
            addButton = new Button();
            orderItemsListBox = new ListBox();
            orderItemsLabel = new Label();
            tableLayoutPanel.SuspendLayout();
            priorityOrdersPanel.SuspendLayout();
            addressControlPanel.SuspendLayout();
            orderItemsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(priorityOrdersPanel, 0, 0);
            tableLayoutPanel.Controls.Add(addressControlPanel, 0, 1);
            tableLayoutPanel.Controls.Add(orderItemsPanel, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6328125F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.90625F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4609375F));
            tableLayoutPanel.Size = new Size(512, 512);
            tableLayoutPanel.TabIndex = 0;
            // 
            // priorityOrdersPanel
            // 
            priorityOrdersPanel.Controls.Add(deliveryTimeComboBox);
            priorityOrdersPanel.Controls.Add(deliveryTimeLabel);
            priorityOrdersPanel.Controls.Add(priorityOptionsLabel);
            priorityOrdersPanel.Controls.Add(statusLabel);
            priorityOrdersPanel.Controls.Add(statusComboBox);
            priorityOrdersPanel.Controls.Add(createdTextBox);
            priorityOrdersPanel.Controls.Add(idTextBox);
            priorityOrdersPanel.Controls.Add(createdLabel);
            priorityOrdersPanel.Controls.Add(Idlabel);
            priorityOrdersPanel.Controls.Add(selectedOrderLabel);
            priorityOrdersPanel.Dock = DockStyle.Fill;
            priorityOrdersPanel.Location = new Point(3, 3);
            priorityOrdersPanel.Name = "priorityOrdersPanel";
            priorityOrdersPanel.Size = new Size(506, 115);
            priorityOrdersPanel.TabIndex = 0;
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.Items.AddRange(new object[] { "9:00-11:00", "11:00-13:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" });
            deliveryTimeComboBox.Location = new Point(357, 29);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(146, 23);
            deliveryTimeComboBox.TabIndex = 9;
            deliveryTimeComboBox.SelectedIndexChanged += deliveryTimeComboBox_SelectedIndexChanged;
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(270, 32);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(81, 15);
            deliveryTimeLabel.TabIndex = 8;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            priorityOptionsLabel.Location = new Point(270, 3);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new Size(107, 17);
            priorityOptionsLabel.TabIndex = 7;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(3, 90);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(60, 87);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(146, 23);
            statusComboBox.TabIndex = 5;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(60, 58);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(146, 23);
            createdTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(60, 29);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(146, 23);
            idTextBox.TabIndex = 3;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(3, 61);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(51, 15);
            createdLabel.TabIndex = 2;
            createdLabel.Text = "Created:";
            // 
            // Idlabel
            // 
            Idlabel.AutoSize = true;
            Idlabel.Location = new Point(3, 32);
            Idlabel.Name = "Idlabel";
            Idlabel.Size = new Size(21, 15);
            Idlabel.TabIndex = 1;
            Idlabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedOrderLabel.Location = new Point(3, 3);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(98, 17);
            selectedOrderLabel.TabIndex = 0;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // addressControlPanel
            // 
            addressControlPanel.Controls.Add(addressControl);
            addressControlPanel.Dock = DockStyle.Fill;
            addressControlPanel.Location = new Point(3, 124);
            addressControlPanel.Name = "addressControlPanel";
            addressControlPanel.Size = new Size(506, 142);
            addressControlPanel.TabIndex = 1;
            // 
            // addressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = "000000";
            address1.Street = "";
            addressControl.Address = address1;
            addressControl.IsReadOnly = false;
            addressControl.Location = new Point(0, 0);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(351, 142);
            addressControl.TabIndex = 0;
            addressControl.Enter += addressControl_Enter;
            // 
            // orderItemsPanel
            // 
            orderItemsPanel.Controls.Add(money);
            orderItemsPanel.Controls.Add(amountLabel);
            orderItemsPanel.Controls.Add(clearButton);
            orderItemsPanel.Controls.Add(removeButton);
            orderItemsPanel.Controls.Add(addButton);
            orderItemsPanel.Controls.Add(orderItemsListBox);
            orderItemsPanel.Controls.Add(orderItemsLabel);
            orderItemsPanel.Dock = DockStyle.Fill;
            orderItemsPanel.Location = new Point(3, 272);
            orderItemsPanel.Name = "orderItemsPanel";
            orderItemsPanel.Size = new Size(506, 237);
            orderItemsPanel.TabIndex = 2;
            // 
            // money
            // 
            money.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            money.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            money.Location = new Point(285, 170);
            money.Name = "money";
            money.Size = new Size(218, 30);
            money.TabIndex = 10;
            money.Text = "0";
            money.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(441, 153);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(62, 17);
            amountLabel.TabIndex = 6;
            amountLabel.Text = "Amount:";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearButton.Location = new Point(405, 203);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(98, 31);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear Order";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(107, 203);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(98, 31);
            removeButton.TabIndex = 4;
            removeButton.Text = "Remove Item";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 203);
            addButton.Name = "addButton";
            addButton.Size = new Size(98, 31);
            addButton.TabIndex = 3;
            addButton.Text = "Add Item";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // orderItemsListBox
            // 
            orderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsListBox.FormattingEnabled = true;
            orderItemsListBox.IntegralHeight = false;
            orderItemsListBox.ItemHeight = 15;
            orderItemsListBox.Location = new Point(3, 23);
            orderItemsListBox.Name = "orderItemsListBox";
            orderItemsListBox.ScrollAlwaysVisible = true;
            orderItemsListBox.Size = new Size(500, 127);
            orderItemsListBox.TabIndex = 2;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            orderItemsLabel.Location = new Point(3, 3);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(81, 17);
            orderItemsLabel.TabIndex = 1;
            orderItemsLabel.Text = "Order Items";
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Name = "PriorityOrdersTab";
            Size = new Size(512, 512);
            tableLayoutPanel.ResumeLayout(false);
            priorityOrdersPanel.ResumeLayout(false);
            priorityOrdersPanel.PerformLayout();
            addressControlPanel.ResumeLayout(false);
            orderItemsPanel.ResumeLayout(false);
            orderItemsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel priorityOrdersPanel;
        private Label selectedOrderLabel;
        private ComboBox deliveryTimeComboBox;
        private Label deliveryTimeLabel;
        private Label priorityOptionsLabel;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private TextBox createdTextBox;
        private TextBox idTextBox;
        private Label createdLabel;
        private Label Idlabel;
        private Panel addressControlPanel;
        private Controls.AddressControl addressControl;
        private Panel orderItemsPanel;
        private Label amountLabel;
        private Button clearButton;
        private Button removeButton;
        private Button addButton;
        private ListBox orderItemsListBox;
        private Label orderItemsLabel;
        private Label money;
    }
}
