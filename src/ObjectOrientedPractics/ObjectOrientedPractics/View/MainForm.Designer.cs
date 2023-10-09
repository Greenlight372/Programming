namespace ObjectOrientedPractics.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            shopTabControl = new TabControl();
            itemsPage = new TabPage();
            itemsControl = new Tabs.ItemsTab();
            customersPage = new TabPage();
            customersControl = new Tabs.CustomersTab();
            shopTabControl.SuspendLayout();
            itemsPage.SuspendLayout();
            customersPage.SuspendLayout();
            SuspendLayout();
            // 
            // shopTabControl
            // 
            shopTabControl.Controls.Add(itemsPage);
            shopTabControl.Controls.Add(customersPage);
            shopTabControl.Dock = DockStyle.Fill;
            shopTabControl.Location = new Point(0, 0);
            shopTabControl.Name = "shopTabControl";
            shopTabControl.SelectedIndex = 0;
            shopTabControl.Size = new Size(584, 473);
            shopTabControl.TabIndex = 0;
            // 
            // itemsPage
            // 
            itemsPage.Controls.Add(itemsControl);
            itemsPage.Location = new Point(4, 24);
            itemsPage.Name = "itemsPage";
            itemsPage.Padding = new Padding(3);
            itemsPage.Size = new Size(576, 445);
            itemsPage.TabIndex = 0;
            itemsPage.Text = "Items";
            itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsControl
            // 
            itemsControl.Dock = DockStyle.Fill;
            itemsControl.Items = null;
            itemsControl.Location = new Point(3, 3);
            itemsControl.MinimumSize = new Size(512, 448);
            itemsControl.Name = "itemsControl";
            itemsControl.Size = new Size(570, 448);
            itemsControl.TabIndex = 0;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersControl);
            customersPage.Location = new Point(4, 24);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(576, 445);
            customersPage.TabIndex = 1;
            customersPage.Text = "Customers";
            customersPage.UseVisualStyleBackColor = true;
            // 
            // customersControl
            // 
            customersControl.Customers = null;
            customersControl.Dock = DockStyle.Fill;
            customersControl.Location = new Point(3, 3);
            customersControl.MinimumSize = new Size(512, 448);
            customersControl.Name = "customersControl";
            customersControl.Size = new Size(570, 448);
            customersControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 473);
            Controls.Add(shopTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 512);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Oriented Practics";
            shopTabControl.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            customersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl shopTabControl;
        private TabPage itemsPage;
        private Tabs.ItemsTab itemsTab;
        private TabPage customersPage;
        private Tabs.CustomersTab customersTab;
        private Tabs.ItemsTab itemsControl;
        private Tabs.CustomersTab customersControl;
        private Tabs.CustomersTab customersTab2;
        private Tabs.CustomersTab customersUserControl;
    }
}