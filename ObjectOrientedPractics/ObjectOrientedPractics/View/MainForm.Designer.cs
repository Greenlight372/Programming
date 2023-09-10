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
            this.shopTabControl = new System.Windows.Forms.TabControl();
            this.itemsPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.shopTabControl.SuspendLayout();
            this.itemsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopTabControl
            // 
            this.shopTabControl.Controls.Add(this.itemsPage);
            this.shopTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopTabControl.Location = new System.Drawing.Point(0, 0);
            this.shopTabControl.Name = "shopTabControl";
            this.shopTabControl.SelectedIndex = 0;
            this.shopTabControl.Size = new System.Drawing.Size(584, 473);
            this.shopTabControl.TabIndex = 0;
            // 
            // itemsPage
            // 
            this.itemsPage.Controls.Add(this.itemsTab);
            this.itemsPage.Location = new System.Drawing.Point(4, 24);
            this.itemsPage.Name = "itemsPage";
            this.itemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsPage.Size = new System.Drawing.Size(576, 445);
            this.itemsPage.TabIndex = 0;
            this.itemsPage.Text = "Items";
            this.itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.MinimumSize = new System.Drawing.Size(512, 448);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(570, 448);
            this.itemsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 473);
            this.Controls.Add(this.shopTabControl);
            this.MinimumSize = new System.Drawing.Size(600, 512);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Object Oriented Practics";
            this.shopTabControl.ResumeLayout(false);
            this.itemsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl shopTabControl;
        private TabPage itemsPage;
        private Tabs.ItemsTab itemsTab;
    }
}