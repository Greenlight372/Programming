namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            cartsTabLayoutPanel = new TableLayoutPanel();
            leftPanel = new Panel();
            addButton = new Button();
            itemsListBox = new ListBox();
            itemsLabel = new Label();
            rightPanel = new Panel();
            createButton = new Button();
            removeButton = new Button();
            clearButton = new Button();
            money = new Label();
            amountLabel = new Label();
            cartListBox = new ListBox();
            cartLabel = new Label();
            customerComboBox = new ComboBox();
            customerLabel = new Label();
            cartsTabLayoutPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cartsTabLayoutPanel
            // 
            cartsTabLayoutPanel.ColumnCount = 2;
            cartsTabLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5F));
            cartsTabLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.5F));
            cartsTabLayoutPanel.Controls.Add(leftPanel, 0, 0);
            cartsTabLayoutPanel.Controls.Add(rightPanel, 1, 0);
            cartsTabLayoutPanel.Dock = DockStyle.Fill;
            cartsTabLayoutPanel.Location = new Point(0, 0);
            cartsTabLayoutPanel.Name = "cartsTabLayoutPanel";
            cartsTabLayoutPanel.RowCount = 1;
            cartsTabLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            cartsTabLayoutPanel.Size = new Size(600, 448);
            cartsTabLayoutPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(addButton);
            leftPanel.Controls.Add(itemsListBox);
            leftPanel.Controls.Add(itemsLabel);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(3, 3);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(201, 442);
            leftPanel.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 397);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 42);
            addButton.TabIndex = 4;
            addButton.Text = "Add To Cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // itemsListBox
            // 
            itemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.IntegralHeight = false;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(3, 20);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(195, 371);
            itemsListBox.TabIndex = 3;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemsLabel.Location = new Point(3, 0);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(42, 17);
            itemsLabel.TabIndex = 2;
            itemsLabel.Text = "Items";
            // 
            // rightPanel
            // 
            rightPanel.Controls.Add(createButton);
            rightPanel.Controls.Add(removeButton);
            rightPanel.Controls.Add(clearButton);
            rightPanel.Controls.Add(money);
            rightPanel.Controls.Add(amountLabel);
            rightPanel.Controls.Add(cartListBox);
            rightPanel.Controls.Add(cartLabel);
            rightPanel.Controls.Add(customerComboBox);
            rightPanel.Controls.Add(customerLabel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(210, 3);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(387, 442);
            rightPanel.TabIndex = 1;
            // 
            // createButton
            // 
            createButton.Location = new Point(3, 323);
            createButton.Name = "createButton";
            createButton.Size = new Size(88, 42);
            createButton.TabIndex = 11;
            createButton.Text = "Create Order";
            createButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Location = new Point(202, 323);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(88, 42);
            removeButton.TabIndex = 10;
            removeButton.Text = "Remove Item";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Location = new Point(296, 323);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 42);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // money
            // 
            money.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            money.AutoSize = true;
            money.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            money.Location = new Point(359, 290);
            money.Name = "money";
            money.Size = new Size(25, 30);
            money.TabIndex = 8;
            money.Text = "0";
            money.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            amountLabel.Location = new Point(322, 273);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(62, 17);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // cartListBox
            // 
            cartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartListBox.FormattingEnabled = true;
            cartListBox.IntegralHeight = false;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(3, 72);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(381, 198);
            cartListBox.TabIndex = 6;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cartLabel.Location = new Point(3, 54);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(32, 15);
            cartLabel.TabIndex = 5;
            cartLabel.Text = "Cart:";
            // 
            // customerComboBox
            // 
            customerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(81, 20);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(303, 23);
            customerComboBox.TabIndex = 4;
            customerComboBox.SelectedIndexChanged += customerComboBox_SelectedIndexChanged;
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customerLabel.Location = new Point(3, 20);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(72, 17);
            customerLabel.TabIndex = 3;
            customerLabel.Text = "Customer:";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cartsTabLayoutPanel);
            Name = "CartsTab";
            Size = new Size(600, 448);
            cartsTabLayoutPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel cartsTabLayoutPanel;
        private Panel leftPanel;
        private Button addButton;
        private ListBox itemsListBox;
        private Label itemsLabel;
        private Panel rightPanel;
        private Button createButton;
        private Button removeButton;
        private Button clearButton;
        private Label money;
        private Label amountLabel;
        private ListBox cartListBox;
        private Label cartLabel;
        private ComboBox customerComboBox;
        private Label customerLabel;
    }
}
