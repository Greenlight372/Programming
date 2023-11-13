namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            ordersLayoutPanel = new TableLayoutPanel();
            ordersPanel = new Panel();
            ordersDataGridView = new DataGridView();
            ordersLabel = new Label();
            infoLayoutPanel = new TableLayoutPanel();
            orderItemsPanel = new Panel();
            money = new Label();
            amountLabel = new Label();
            itemsListBox = new ListBox();
            orderItemsLabel = new Label();
            addressPanel = new Panel();
            addressControl = new Controls.AddressControl();
            selectedOrderPanel = new Panel();
            priorityOptionsPanel = new Panel();
            deliveryTimeComboBox = new ComboBox();
            deliveryTimeLabel = new Label();
            priorityOptionsLabel = new Label();
            statusComboBox = new ComboBox();
            createdTextBox = new TextBox();
            idTextBox = new TextBox();
            statusLabel = new Label();
            createdLabel = new Label();
            idLabel = new Label();
            selectedOrderLabel = new Label();
            id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerFullname = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            totalLabel = new Label();
            totalSum = new Label();
            ordersLayoutPanel.SuspendLayout();
            ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            infoLayoutPanel.SuspendLayout();
            orderItemsPanel.SuspendLayout();
            addressPanel.SuspendLayout();
            selectedOrderPanel.SuspendLayout();
            priorityOptionsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ordersLayoutPanel
            // 
            ordersLayoutPanel.ColumnCount = 2;
            ordersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.57143F));
            ordersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.42857F));
            ordersLayoutPanel.Controls.Add(ordersPanel, 0, 0);
            ordersLayoutPanel.Controls.Add(infoLayoutPanel, 1, 0);
            ordersLayoutPanel.Dock = DockStyle.Fill;
            ordersLayoutPanel.Location = new Point(0, 0);
            ordersLayoutPanel.Name = "ordersLayoutPanel";
            ordersLayoutPanel.RowCount = 1;
            ordersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ordersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ordersLayoutPanel.Size = new Size(700, 600);
            ordersLayoutPanel.TabIndex = 0;
            // 
            // ordersPanel
            // 
            ordersPanel.Controls.Add(ordersDataGridView);
            ordersPanel.Controls.Add(ordersLabel);
            ordersPanel.Dock = DockStyle.Fill;
            ordersPanel.Location = new Point(3, 3);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(285, 594);
            ordersPanel.TabIndex = 0;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersDataGridView.ColumnHeadersHeight = 24;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { id, Created, OrderStatus, CustomerFullname, Amount, DeliveryAddress, Total });
            ordersDataGridView.Location = new Point(3, 24);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 24;
            ordersDataGridView.RowTemplate.Height = 25;
            ordersDataGridView.ScrollBars = ScrollBars.Horizontal;
            ordersDataGridView.Size = new Size(279, 571);
            ordersDataGridView.TabIndex = 2;
            ordersDataGridView.SelectionChanged += ordersDataGridView_SelectionChanged;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ordersLabel.Location = new Point(3, 3);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(49, 17);
            ordersLabel.TabIndex = 1;
            ordersLabel.Text = "Orders";
            // 
            // infoLayoutPanel
            // 
            infoLayoutPanel.ColumnCount = 1;
            infoLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoLayoutPanel.Controls.Add(orderItemsPanel, 0, 2);
            infoLayoutPanel.Controls.Add(addressPanel, 0, 1);
            infoLayoutPanel.Controls.Add(selectedOrderPanel, 0, 0);
            infoLayoutPanel.Dock = DockStyle.Fill;
            infoLayoutPanel.Location = new Point(294, 3);
            infoLayoutPanel.Name = "infoLayoutPanel";
            infoLayoutPanel.RowCount = 3;
            infoLayoutPanel.RowStyles.Add(new RowStyle());
            infoLayoutPanel.RowStyles.Add(new RowStyle());
            infoLayoutPanel.RowStyles.Add(new RowStyle());
            infoLayoutPanel.Size = new Size(403, 594);
            infoLayoutPanel.TabIndex = 1;
            // 
            // orderItemsPanel
            // 
            orderItemsPanel.Controls.Add(totalSum);
            orderItemsPanel.Controls.Add(totalLabel);
            orderItemsPanel.Controls.Add(money);
            orderItemsPanel.Controls.Add(amountLabel);
            orderItemsPanel.Controls.Add(itemsListBox);
            orderItemsPanel.Controls.Add(orderItemsLabel);
            orderItemsPanel.Dock = DockStyle.Fill;
            orderItemsPanel.Location = new Point(3, 290);
            orderItemsPanel.Name = "orderItemsPanel";
            orderItemsPanel.Size = new Size(397, 301);
            orderItemsPanel.TabIndex = 0;
            // 
            // money
            // 
            money.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            money.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            money.Location = new Point(176, 179);
            money.Name = "money";
            money.Size = new Size(218, 30);
            money.TabIndex = 9;
            money.Text = "0";
            money.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(332, 162);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(62, 17);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.IntegralHeight = false;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(3, 20);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.ScrollAlwaysVisible = true;
            itemsListBox.Size = new Size(391, 139);
            itemsListBox.TabIndex = 3;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            orderItemsLabel.Location = new Point(3, 0);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(81, 17);
            orderItemsLabel.TabIndex = 2;
            orderItemsLabel.Text = "Order items";
            // 
            // addressPanel
            // 
            addressPanel.Controls.Add(addressControl);
            addressPanel.Dock = DockStyle.Fill;
            addressPanel.Location = new Point(3, 133);
            addressPanel.Name = "addressPanel";
            addressPanel.Size = new Size(397, 151);
            addressPanel.TabIndex = 1;
            // 
            // addressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = "000000";
            address1.Street = null;
            addressControl.Address = address1;
            addressControl.Dock = DockStyle.Fill;
            addressControl.IsReadOnly = true;
            addressControl.Location = new Point(0, 0);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(397, 151);
            addressControl.TabIndex = 0;
            // 
            // selectedOrderPanel
            // 
            selectedOrderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedOrderPanel.Controls.Add(priorityOptionsPanel);
            selectedOrderPanel.Controls.Add(statusComboBox);
            selectedOrderPanel.Controls.Add(createdTextBox);
            selectedOrderPanel.Controls.Add(idTextBox);
            selectedOrderPanel.Controls.Add(statusLabel);
            selectedOrderPanel.Controls.Add(createdLabel);
            selectedOrderPanel.Controls.Add(idLabel);
            selectedOrderPanel.Controls.Add(selectedOrderLabel);
            selectedOrderPanel.Location = new Point(3, 3);
            selectedOrderPanel.Name = "selectedOrderPanel";
            selectedOrderPanel.Size = new Size(397, 124);
            selectedOrderPanel.TabIndex = 2;
            // 
            // priorityOptionsPanel
            // 
            priorityOptionsPanel.Controls.Add(deliveryTimeComboBox);
            priorityOptionsPanel.Controls.Add(deliveryTimeLabel);
            priorityOptionsPanel.Controls.Add(priorityOptionsLabel);
            priorityOptionsPanel.Enabled = false;
            priorityOptionsPanel.Location = new Point(184, 0);
            priorityOptionsPanel.Name = "priorityOptionsPanel";
            priorityOptionsPanel.Size = new Size(214, 121);
            priorityOptionsPanel.TabIndex = 10;
            priorityOptionsPanel.Visible = false;
            // 
            // deliveryTimeComboBox
            // 
            deliveryTimeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryTimeComboBox.FormattingEnabled = true;
            deliveryTimeComboBox.ImeMode = ImeMode.Off;
            deliveryTimeComboBox.Items.AddRange(new object[] { "9:00-11:00", "11:00-13:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" });
            deliveryTimeComboBox.Location = new Point(90, 30);
            deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            deliveryTimeComboBox.Size = new Size(118, 23);
            deliveryTimeComboBox.TabIndex = 10;
            deliveryTimeComboBox.SelectedIndexChanged += deliveryTimeComboBox_SelectedIndexChanged;
            // 
            // deliveryTimeLabel
            // 
            deliveryTimeLabel.AutoSize = true;
            deliveryTimeLabel.Location = new Point(3, 33);
            deliveryTimeLabel.Name = "deliveryTimeLabel";
            deliveryTimeLabel.Size = new Size(81, 15);
            deliveryTimeLabel.TabIndex = 5;
            deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // priorityOptionsLabel
            // 
            priorityOptionsLabel.AutoSize = true;
            priorityOptionsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            priorityOptionsLabel.Location = new Point(3, 3);
            priorityOptionsLabel.Name = "priorityOptionsLabel";
            priorityOptionsLabel.Size = new Size(107, 17);
            priorityOptionsLabel.TabIndex = 4;
            priorityOptionsLabel.Text = "Priority Options";
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.ImeMode = ImeMode.Off;
            statusComboBox.Location = new Point(60, 88);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(118, 23);
            statusComboBox.TabIndex = 9;
            statusComboBox.SelectedValueChanged += statusComboBox_SelectedValueChanged;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(60, 59);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(118, 23);
            createdTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(60, 30);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(118, 23);
            idTextBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(3, 91);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(3, 62);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(51, 15);
            createdLabel.TabIndex = 5;
            createdLabel.Text = "Created:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 33);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 4;
            idLabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectedOrderLabel.Location = new Point(3, 3);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(98, 17);
            selectedOrderLabel.TabIndex = 3;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // id
            // 
            id.DataPropertyName = "GetId";
            id.FillWeight = 32F;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.SortMode = DataGridViewColumnSortMode.NotSortable;
            id.Width = 32;
            // 
            // Created
            // 
            Created.DataPropertyName = "GetDate";
            Created.FillWeight = 120F;
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            Created.Width = 120;
            // 
            // OrderStatus
            // 
            OrderStatus.FillWeight = 80F;
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            OrderStatus.Width = 80;
            // 
            // CustomerFullname
            // 
            CustomerFullname.DataPropertyName = "Fullname";
            CustomerFullname.FillWeight = 140F;
            CustomerFullname.HeaderText = "Customer Full Name";
            CustomerFullname.Name = "CustomerFullname";
            CustomerFullname.ReadOnly = true;
            CustomerFullname.SortMode = DataGridViewColumnSortMode.NotSortable;
            CustomerFullname.Width = 140;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.FillWeight = 80F;
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            Amount.Width = 80;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.DataPropertyName = "Address";
            DeliveryAddress.FillWeight = 320F;
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            DeliveryAddress.SortMode = DataGridViewColumnSortMode.NotSortable;
            DeliveryAddress.Width = 320;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.FillWeight = 80F;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.SortMode = DataGridViewColumnSortMode.NotSortable;
            Total.Width = 80;
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(340, 242);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(52, 17);
            totalLabel.TabIndex = 10;
            totalLabel.Text = "TOTAL:";
            // 
            // totalSum
            // 
            totalSum.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalSum.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalSum.Location = new Point(176, 259);
            totalSum.Name = "totalSum";
            totalSum.Size = new Size(218, 30);
            totalSum.TabIndex = 11;
            totalSum.Text = "0";
            totalSum.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ordersLayoutPanel);
            Name = "OrdersTab";
            Size = new Size(700, 600);
            ordersLayoutPanel.ResumeLayout(false);
            ordersPanel.ResumeLayout(false);
            ordersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            infoLayoutPanel.ResumeLayout(false);
            orderItemsPanel.ResumeLayout(false);
            orderItemsPanel.PerformLayout();
            addressPanel.ResumeLayout(false);
            selectedOrderPanel.ResumeLayout(false);
            selectedOrderPanel.PerformLayout();
            priorityOptionsPanel.ResumeLayout(false);
            priorityOptionsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ordersLayoutPanel;
        private Panel ordersPanel;
        private DataGridView ordersDataGridView;
        private Label ordersLabel;
        private TableLayoutPanel infoLayoutPanel;
        private Panel orderItemsPanel;
        private Label money;
        private Label amountLabel;
        private ListBox itemsListBox;
        private Label orderItemsLabel;
        private Panel addressPanel;
        private Controls.AddressControl addressControl;
        private Panel selectedOrderPanel;
        private Panel priorityOptionsPanel;
        private ComboBox deliveryTimeComboBox;
        private Label deliveryTimeLabel;
        private Label priorityOptionsLabel;
        private ComboBox statusComboBox;
        private TextBox createdTextBox;
        private TextBox idTextBox;
        private Label statusLabel;
        private Label createdLabel;
        private Label idLabel;
        private Label selectedOrderLabel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerFullname;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn DeliveryAddress;
        private DataGridViewTextBoxColumn Total;
        private Label totalSum;
        private Label totalLabel;
    }
}
