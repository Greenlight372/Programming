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
            this.shopTabControl = new System.Windows.Forms.TabControl();
            this.itemsPage = new System.Windows.Forms.TabPage();
            this.itemsUserControl = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersPage = new System.Windows.Forms.TabPage();
            this.customersUserControl = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.shopTabControl.SuspendLayout();
            this.itemsPage.SuspendLayout();
            this.customersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopTabControl
            // 
            this.shopTabControl.Controls.Add(this.itemsPage);
            this.shopTabControl.Controls.Add(this.customersPage);
            this.shopTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopTabControl.Location = new System.Drawing.Point(0, 0);
            this.shopTabControl.Name = "shopTabControl";
            this.shopTabControl.SelectedIndex = 0;
            this.shopTabControl.Size = new System.Drawing.Size(584, 473);
            this.shopTabControl.TabIndex = 0;
            // 
            // itemsPage
            // 
            this.itemsPage.Controls.Add(this.itemsUserControl);
            this.itemsPage.Location = new System.Drawing.Point(4, 24);
            this.itemsPage.Name = "itemsPage";
            this.itemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsPage.Size = new System.Drawing.Size(576, 445);
            this.itemsPage.TabIndex = 0;
            this.itemsPage.Text = "Items";
            this.itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsUserControl
            // 
            this.itemsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsUserControl.Location = new System.Drawing.Point(3, 3);
            this.itemsUserControl.MinimumSize = new System.Drawing.Size(512, 448);
            this.itemsUserControl.Name = "itemsUserControl";
            this.itemsUserControl.Size = new System.Drawing.Size(570, 448);
            this.itemsUserControl.TabIndex = 0;
            // 
            // customersPage
            // 
            this.customersPage.Controls.Add(this.customersUserControl);
            this.customersPage.Location = new System.Drawing.Point(4, 24);
            this.customersPage.Name = "customersPage";
            this.customersPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersPage.Size = new System.Drawing.Size(576, 445);
            this.customersPage.TabIndex = 1;
            this.customersPage.Text = "Customers";
            this.customersPage.UseVisualStyleBackColor = true;
            // 
            // customersUserControl
            // 
            this.customersUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersUserControl.Location = new System.Drawing.Point(3, 3);
            this.customersUserControl.MinimumSize = new System.Drawing.Size(512, 448);
            this.customersUserControl.Name = "customersUserControl";
            this.customersUserControl.Size = new System.Drawing.Size(570, 448);
            this.customersUserControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 473);
            this.Controls.Add(this.shopTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 512);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Oriented Practics";
            this.shopTabControl.ResumeLayout(false);
            this.itemsPage.ResumeLayout(false);
            this.customersPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl shopTabControl;
        private TabPage itemsPage;
        private Tabs.ItemsTab itemsTab;
        private TabPage customersPage;
        private Tabs.CustomersTab customersTab1;
        private Tabs.ItemsTab itemsUserControl;
        private Tabs.CustomersTab customersUserControl;
    }
}