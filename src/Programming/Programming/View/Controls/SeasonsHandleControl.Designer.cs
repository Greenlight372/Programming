namespace Programming.View.Controls
{
    partial class SeasonsHandleControl
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
            SeasonHandle = new GroupBox();
            SeasonButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            button1 = new Button();
            SeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandle
            // 
            SeasonHandle.AutoSize = true;
            SeasonHandle.Controls.Add(button1);
            SeasonHandle.Controls.Add(SeasonButton);
            SeasonHandle.Controls.Add(SeasonComboBox);
            SeasonHandle.Controls.Add(SeasonLabel);
            SeasonHandle.Dock = DockStyle.Fill;
            SeasonHandle.Location = new Point(0, 0);
            SeasonHandle.Margin = new Padding(3, 4, 3, 4);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Padding = new Padding(3, 4, 3, 4);
            SeasonHandle.Size = new Size(315, 237);
            SeasonHandle.TabIndex = 5;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(195, 48);
            SeasonButton.Margin = new Padding(3, 4, 3, 4);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(86, 31);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Location = new Point(7, 49);
            SeasonComboBox.Margin = new Padding(3, 4, 3, 4);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(181, 28);
            SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(3, 25);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(110, 20);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose season:";
            // 
            // button1
            // 
            button1.Location = new Point(7, 198);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 3;
            button1.Text = "Go!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SeasonsHandleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SeasonsHandleControl";
            Size = new Size(315, 237);
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SeasonHandle;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private Label SeasonLabel;
        private Button button1;
    }
}
