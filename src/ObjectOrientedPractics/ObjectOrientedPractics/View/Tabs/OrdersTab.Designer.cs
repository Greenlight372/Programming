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
            id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerFullname = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
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
            statusComboBox = new ComboBox();
            createdTextBox = new TextBox();
            idTextBox = new TextBox();
            statusLabel = new Label();
            createdLabel = new Label();
            idLabel = new Label();
            selectedOrderLabel = new Label();
            ordersLayoutPanel.SuspendLayout();
            ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            infoLayoutPanel.SuspendLayout();
            orderItemsPanel.SuspendLayout();
            addressPanel.SuspendLayout();
            selectedOrderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ordersLayoutPanel
            // 
            ordersLayoutPanel.ColumnCount = 2;
            ordersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.42857F));
            ordersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.57143F));
            ordersLayoutPanel.Controls.Add(ordersPanel, 0, 0);
            ordersLayoutPanel.Controls.Add(infoLayoutPanel, 1, 0);
            ordersLayoutPanel.Dock = DockStyle.Fill;
            ordersLayoutPanel.Location = new Point(0, 0);
            ordersLayoutPanel.Name = "ordersLayoutPanel";
            ordersLayoutPanel.RowCount = 1;
            ordersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ordersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ordersLayoutPanel.Size = new Size(700, 512);
            ordersLayoutPanel.TabIndex = 0;
            // 
            // ordersPanel
            // 
            ordersPanel.Controls.Add(ordersDataGridView);
            ordersPanel.Controls.Add(ordersLabel);
            ordersPanel.Dock = DockStyle.Fill;
            ordersPanel.Location = new Point(3, 3);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(318, 506);
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
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { id, Created, OrderStatus, CustomerFullname, Amount, DeliveryAddress });
            ordersDataGridView.Location = new Point(3, 20);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 24;
            ordersDataGridView.RowTemplate.Height = 25;
            ordersDataGridView.ScrollBars = ScrollBars.Horizontal;
            ordersDataGridView.Size = new Size(312, 483);
            ordersDataGridView.TabIndex = 2;
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
            Created.FillWeight = 75F;
            Created.HeaderText = "Created";
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.SortMode = DataGridViewColumnSortMode.NotSortable;
            Created.Width = 75;
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
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.DataPropertyName = "Address";
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            DeliveryAddress.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ordersLabel.Location = new Point(3, 0);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(49, 17);
            ordersLabel.TabIndex = 1;
            ordersLabel.Text = "Orders";
            // 
            // infoLayoutPanel
            // 
            infoLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            infoLayoutPanel.ColumnCount = 1;
            infoLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            infoLayoutPanel.Controls.Add(orderItemsPanel, 0, 2);
            infoLayoutPanel.Controls.Add(addressPanel, 0, 1);
            infoLayoutPanel.Controls.Add(selectedOrderPanel, 0, 0);
            infoLayoutPanel.Location = new Point(327, 3);
            infoLayoutPanel.Name = "infoLayoutPanel";
            infoLayoutPanel.RowCount = 3;
            infoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            infoLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 219F));
            infoLayoutPanel.Size = new Size(370, 506);
            infoLayoutPanel.TabIndex = 1;
            // 
            // orderItemsPanel
            // 
            orderItemsPanel.Controls.Add(money);
            orderItemsPanel.Controls.Add(amountLabel);
            orderItemsPanel.Controls.Add(itemsListBox);
            orderItemsPanel.Controls.Add(orderItemsLabel);
            orderItemsPanel.Dock = DockStyle.Fill;
            orderItemsPanel.Location = new Point(3, 290);
            orderItemsPanel.Name = "orderItemsPanel";
            orderItemsPanel.Size = new Size(364, 213);
            orderItemsPanel.TabIndex = 0;
            // 
            // money
            // 
            money.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            money.AutoSize = true;
            money.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            money.Location = new Point(336, 179);
            money.Name = "money";
            money.Size = new Size(25, 30);
            money.TabIndex = 9;
            money.Text = "0";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(299, 162);
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
            itemsListBox.Size = new Size(358, 139);
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
            addressPanel.Size = new Size(364, 151);
            addressPanel.TabIndex = 1;
            // 
            // addressControl
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = "000000";
            address1.Street = " ";
            addressControl.Address = address1;
            addressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl.Location = new Point(0, 0);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(364, 151);
            addressControl.TabIndex = 1;
            // 
            // selectedOrderPanel
            // 
            selectedOrderPanel.Controls.Add(statusComboBox);
            selectedOrderPanel.Controls.Add(createdTextBox);
            selectedOrderPanel.Controls.Add(idTextBox);
            selectedOrderPanel.Controls.Add(statusLabel);
            selectedOrderPanel.Controls.Add(createdLabel);
            selectedOrderPanel.Controls.Add(idLabel);
            selectedOrderPanel.Controls.Add(selectedOrderLabel);
            selectedOrderPanel.Dock = DockStyle.Fill;
            selectedOrderPanel.Location = new Point(3, 3);
            selectedOrderPanel.Name = "selectedOrderPanel";
            selectedOrderPanel.Size = new Size(364, 124);
            selectedOrderPanel.TabIndex = 2;
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(72, 88);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(167, 23);
            statusComboBox.TabIndex = 9;
            // 
            // createdTextBox
            // 
            createdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createdTextBox.Location = new Point(72, 59);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(167, 23);
            createdTextBox.TabIndex = 8;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(72, 30);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(167, 23);
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
            selectedOrderLabel.Location = new Point(3, 0);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(98, 17);
            selectedOrderLabel.TabIndex = 3;
            selectedOrderLabel.Text = "Selected Order";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ordersLayoutPanel);
            Name = "OrdersTab";
            Size = new Size(700, 512);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ordersLayoutPanel;
        private Panel ordersPanel;
        private DataGridView ordersDataGridView;
        private Label ordersLabel;
        private TableLayoutPanel infoLayoutPanel;
        private Panel orderItemsPanel;
        private Label amountLabel;
        private ListBox itemsListBox;
        private Label orderItemsLabel;
        private Label money;
        private Panel addressPanel;
        private Controls.AddressControl addressControl;
        private Panel selectedOrderPanel;
        private Label selectedOrderLabel;
        private ComboBox statusComboBox;
        private TextBox createdTextBox;
        private TextBox idTextBox;
        private Label statusLabel;
        private Label createdLabel;
        private Label idLabel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerFullname;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn DeliveryAddress;
    }
}
