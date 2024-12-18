﻿namespace ObjectOrientedPractics.View
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
            cartsPage = new TabPage();
            cartsControl = new Tabs.CartsTab();
            ordersPage = new TabPage();
            ordersControl = new Tabs.OrdersTab();
            interfaceTab = new TabPage();
            interfaceControl = new Tabs.InterfaceTab();
            shopTabControl.SuspendLayout();
            itemsPage.SuspendLayout();
            customersPage.SuspendLayout();
            cartsPage.SuspendLayout();
            ordersPage.SuspendLayout();
            interfaceTab.SuspendLayout();
            SuspendLayout();
            // 
            // shopTabControl
            // 
            shopTabControl.Controls.Add(itemsPage);
            shopTabControl.Controls.Add(customersPage);
            shopTabControl.Controls.Add(cartsPage);
            shopTabControl.Controls.Add(ordersPage);
            shopTabControl.Controls.Add(interfaceTab);
            shopTabControl.Dock = DockStyle.Fill;
            shopTabControl.Location = new Point(0, 0);
            shopTabControl.Name = "shopTabControl";
            shopTabControl.SelectedIndex = 0;
            shopTabControl.Size = new Size(704, 681);
            shopTabControl.TabIndex = 0;
            // 
            // itemsPage
            // 
            itemsPage.Controls.Add(itemsControl);
            itemsPage.Location = new Point(4, 24);
            itemsPage.Name = "itemsPage";
            itemsPage.Padding = new Padding(3);
            itemsPage.Size = new Size(696, 653);
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
            itemsControl.Size = new Size(690, 647);
            itemsControl.TabIndex = 0;
            // 
            // customersPage
            // 
            customersPage.Controls.Add(customersControl);
            customersPage.Location = new Point(4, 24);
            customersPage.Name = "customersPage";
            customersPage.Padding = new Padding(3);
            customersPage.Size = new Size(696, 653);
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
            customersControl.Size = new Size(690, 647);
            customersControl.TabIndex = 0;
            // 
            // cartsPage
            // 
            cartsPage.Controls.Add(cartsControl);
            cartsPage.Location = new Point(4, 24);
            cartsPage.Name = "cartsPage";
            cartsPage.Padding = new Padding(3);
            cartsPage.Size = new Size(696, 653);
            cartsPage.TabIndex = 2;
            cartsPage.Text = "Carts";
            cartsPage.UseVisualStyleBackColor = true;
            // 
            // cartsControl
            // 
            cartsControl.Customers = null;
            cartsControl.Dock = DockStyle.Fill;
            cartsControl.Items = null;
            cartsControl.Location = new Point(3, 3);
            cartsControl.Name = "cartsControl";
            cartsControl.Size = new Size(690, 647);
            cartsControl.TabIndex = 0;
            // 
            // ordersPage
            // 
            ordersPage.Controls.Add(ordersControl);
            ordersPage.Location = new Point(4, 24);
            ordersPage.Name = "ordersPage";
            ordersPage.Padding = new Padding(3);
            ordersPage.Size = new Size(696, 653);
            ordersPage.TabIndex = 3;
            ordersPage.Text = "Orders";
            ordersPage.UseVisualStyleBackColor = true;
            // 
            // ordersControl
            // 
            ordersControl.Customers = null;
            ordersControl.Dock = DockStyle.Fill;
            ordersControl.Location = new Point(3, 3);
            ordersControl.Name = "ordersControl";
            ordersControl.Size = new Size(690, 647);
            ordersControl.TabIndex = 0;
            // 
            // interfaceTab
            // 
            interfaceTab.Controls.Add(interfaceControl);
            interfaceTab.Location = new Point(4, 24);
            interfaceTab.Name = "interfaceTab";
            interfaceTab.Padding = new Padding(3);
            interfaceTab.Size = new Size(696, 653);
            interfaceTab.TabIndex = 4;
            interfaceTab.Text = "Interface Test";
            interfaceTab.UseVisualStyleBackColor = true;
            // 
            // interfaceControl
            // 
            interfaceControl.Dock = DockStyle.Fill;
            interfaceControl.Location = new Point(3, 3);
            interfaceControl.Name = "interfaceControl";
            interfaceControl.Size = new Size(690, 647);
            interfaceControl.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 681);
            Controls.Add(shopTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(720, 720);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Oriented Practics";
            FormClosed += MainForm_FormClosed;
            shopTabControl.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            customersPage.ResumeLayout(false);
            cartsPage.ResumeLayout(false);
            ordersPage.ResumeLayout(false);
            interfaceTab.ResumeLayout(false);
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
        private TabPage cartsPage;
        private Tabs.OrdersTab ordersControl;
        private TabPage ordersPage;
        private Tabs.CartsTab cartsControl;
        private TabPage interfaceTab;
        private Tabs.InterfaceTab interfaceControl;
    }
}