namespace ObjectOrientedPractics.View.Tabs
{
    partial class InterfaceTab
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
            testingLabel = new Label();
            boolLabel = new Label();
            testingLabel_2 = new Label();
            iCompLabel = new Label();
            SuspendLayout();
            // 
            // testingLabel
            // 
            testingLabel.AutoSize = true;
            testingLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            testingLabel.Location = new Point(3, 0);
            testingLabel.Name = "testingLabel";
            testingLabel.Size = new Size(467, 19);
            testingLabel.TabIndex = 0;
            testingLabel.Text = "Comparing an original object to a cloned one (true if ==, false if !=):";
            // 
            // boolLabel
            // 
            boolLabel.AutoSize = true;
            boolLabel.Location = new Point(476, 4);
            boolLabel.Name = "boolLabel";
            boolLabel.Size = new Size(0, 15);
            boolLabel.TabIndex = 1;
            // 
            // testingLabel_2
            // 
            testingLabel_2.AutoSize = true;
            testingLabel_2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            testingLabel_2.Location = new Point(3, 51);
            testingLabel_2.Name = "testingLabel_2";
            testingLabel_2.Size = new Size(237, 19);
            testingLabel_2.TabIndex = 2;
            testingLabel_2.Text = "Comparison via IComparable<T>:";
            // 
            // iCompLabel
            // 
            iCompLabel.AutoSize = true;
            iCompLabel.Location = new Point(246, 53);
            iCompLabel.Name = "iCompLabel";
            iCompLabel.Size = new Size(0, 15);
            iCompLabel.TabIndex = 3;
            // 
            // InterfaceTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(iCompLabel);
            Controls.Add(testingLabel_2);
            Controls.Add(boolLabel);
            Controls.Add(testingLabel);
            Name = "InterfaceTab";
            Size = new Size(577, 87);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testingLabel;
        private Label boolLabel;
        private Label testingLabel_2;
        private Label iCompLabel;
    }
}
