namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            deliveryAddressLabel = new Label();
            postIndexLabel = new Label();
            postIndexTextBox = new TextBox();
            countryLabel = new Label();
            countryTextBox = new TextBox();
            cityLabel = new Label();
            cityTextBox = new TextBox();
            streetLabel = new Label();
            streetTextBox = new TextBox();
            buildingTextBox = new TextBox();
            apartmentTextBox = new TextBox();
            buildingLabel = new Label();
            apartmentLabel = new Label();
            SuspendLayout();
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deliveryAddressLabel.Location = new Point(0, 0);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new Size(113, 17);
            deliveryAddressLabel.TabIndex = 0;
            deliveryAddressLabel.Text = "Delivery Address";
            // 
            // postIndexLabel
            // 
            postIndexLabel.AutoSize = true;
            postIndexLabel.Location = new Point(3, 32);
            postIndexLabel.Name = "postIndexLabel";
            postIndexLabel.Size = new Size(65, 15);
            postIndexLabel.TabIndex = 1;
            postIndexLabel.Text = "Post Index:";
            // 
            // postIndexTextBox
            // 
            postIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            postIndexTextBox.Location = new Point(74, 29);
            postIndexTextBox.Name = "postIndexTextBox";
            postIndexTextBox.Size = new Size(110, 23);
            postIndexTextBox.TabIndex = 2;
            postIndexTextBox.TextChanged += postIndexTextBox_TextChanged;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(3, 61);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(53, 15);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(74, 58);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(110, 23);
            countryTextBox.TabIndex = 4;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(191, 61);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            cityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cityTextBox.Location = new Point(228, 58);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(74, 23);
            cityTextBox.TabIndex = 6;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(3, 90);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(40, 15);
            streetLabel.TabIndex = 7;
            streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            streetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            streetTextBox.Location = new Point(74, 87);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(228, 23);
            streetTextBox.TabIndex = 8;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // buildingTextBox
            // 
            buildingTextBox.Location = new Point(74, 116);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(74, 23);
            buildingTextBox.TabIndex = 9;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // apartmentTextBox
            // 
            apartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            apartmentTextBox.Location = new Point(228, 116);
            apartmentTextBox.Name = "apartmentTextBox";
            apartmentTextBox.Size = new Size(74, 23);
            apartmentTextBox.TabIndex = 10;
            apartmentTextBox.TextChanged += apartmentTextBox_TextChanged;
            // 
            // buildingLabel
            // 
            buildingLabel.AutoSize = true;
            buildingLabel.Location = new Point(3, 119);
            buildingLabel.Name = "buildingLabel";
            buildingLabel.Size = new Size(54, 15);
            buildingLabel.TabIndex = 11;
            buildingLabel.Text = "Building:";
            // 
            // apartmentLabel
            // 
            apartmentLabel.AutoSize = true;
            apartmentLabel.Location = new Point(155, 119);
            apartmentLabel.Name = "apartmentLabel";
            apartmentLabel.Size = new Size(67, 15);
            apartmentLabel.TabIndex = 12;
            apartmentLabel.Text = "Apartment:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(apartmentLabel);
            Controls.Add(buildingLabel);
            Controls.Add(apartmentTextBox);
            Controls.Add(buildingTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(streetLabel);
            Controls.Add(cityTextBox);
            Controls.Add(cityLabel);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(postIndexTextBox);
            Controls.Add(postIndexLabel);
            Controls.Add(deliveryAddressLabel);
            Name = "AddressControl";
            Size = new Size(308, 152);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label deliveryAddressLabel;
        private Label postIndexLabel;
        private Label countryLabel;
        private Label cityLabel;
        private Label streetLabel;
        private Label buildingLabel;
        private Label apartmentLabel;
        private TextBox postIndexTextBox;
        private TextBox countryTextBox;
        private TextBox cityTextBox;
        private TextBox streetTextBox;
        private TextBox buildingTextBox;
        private TextBox apartmentTextBox;
    }
}
