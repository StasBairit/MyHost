namespace MyHost
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.���������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_rooms = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_customers = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_booking = new System.Windows.Forms.ToolStripMenuItem();
            this.����������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.�����������ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_roomcategories = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_features = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_services = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_roomrates = new System.Windows.Forms.ToolStripMenuItem();
            this.mm_discounts = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.���������ToolStripMenuItem,
            this.�����������ToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(1400, 28);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ���������ToolStripMenuItem
            // 
            this.���������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mm_rooms,
            this.mm_customers,
            this.mm_booking,
            this.����������ToolStripMenuItem});
            this.���������ToolStripMenuItem.Name = "���������ToolStripMenuItem";
            this.���������ToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.���������ToolStripMenuItem.Text = "��������";
            // 
            // mm_rooms
            // 
            this.mm_rooms.Name = "mm_rooms";
            this.mm_rooms.Size = new System.Drawing.Size(268, 26);
            this.mm_rooms.Text = "������������ ������";
            this.mm_rooms.Click += new System.EventHandler(this.mm_rooms_Click);
            // 
            // mm_customers
            // 
            this.mm_customers.Name = "mm_customers";
            this.mm_customers.Size = new System.Drawing.Size(268, 26);
            this.mm_customers.Text = "����������� ������";
            this.mm_customers.Click += new System.EventHandler(this.mm_customers_Click);
            // 
            // mm_booking
            // 
            this.mm_booking.Name = "mm_booking";
            this.mm_booking.Size = new System.Drawing.Size(268, 26);
            this.mm_booking.Text = "������ �����";
            this.mm_booking.Click += new System.EventHandler(this.mm_booking_Click);
            // 
            // ����������ToolStripMenuItem
            // 
            this.����������ToolStripMenuItem.Name = "����������ToolStripMenuItem";
            this.����������ToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.����������ToolStripMenuItem.Text = "����� �� ������� �����";
            this.����������ToolStripMenuItem.Click += new System.EventHandler(this.����������ToolStripMenuItem_Click);
            // 
            // �����������ToolStripMenuItem
            // 
            this.�����������ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mm_roomcategories,
            this.mm_features,
            this.mm_services,
            this.mm_roomrates,
            this.mm_discounts});
            this.�����������ToolStripMenuItem.Name = "�����������ToolStripMenuItem";
            this.�����������ToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.�����������ToolStripMenuItem.Text = "�����������";
            // 
            // mm_roomcategories
            // 
            this.mm_roomcategories.Name = "mm_roomcategories";
            this.mm_roomcategories.Size = new System.Drawing.Size(232, 26);
            this.mm_roomcategories.Text = "��������� �������";
            this.mm_roomcategories.Click += new System.EventHandler(this.mm_roomcategories_Click);
            // 
            // mm_features
            // 
            this.mm_features.Name = "mm_features";
            this.mm_features.Size = new System.Drawing.Size(232, 26);
            this.mm_features.Text = "������";
            this.mm_features.Click += new System.EventHandler(this.mm_features_Click);
            // 
            // mm_services
            // 
            this.mm_services.Name = "mm_services";
            this.mm_services.Size = new System.Drawing.Size(232, 26);
            this.mm_services.Text = "�������";
            this.mm_services.Click += new System.EventHandler(this.mm_services_Click);
            // 
            // mm_roomrates
            // 
            this.mm_roomrates.Name = "mm_roomrates";
            this.mm_roomrates.Size = new System.Drawing.Size(232, 26);
            this.mm_roomrates.Text = "����� ����";
            this.mm_roomrates.Click += new System.EventHandler(this.mm_roomrates_Click);
            // 
            // mm_discounts
            // 
            this.mm_discounts.Name = "mm_discounts";
            this.mm_discounts.Size = new System.Drawing.Size(232, 26);
            this.mm_discounts.Text = "������";
            this.mm_discounts.Click += new System.EventHandler(this.mm_discounts_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 819);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1400, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 841);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "�� ���� ����������";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem �����������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mm_roomcategories;
        private System.Windows.Forms.ToolStripMenuItem mm_features;
        private System.Windows.Forms.ToolStripMenuItem mm_services;
        private System.Windows.Forms.ToolStripMenuItem mm_roomrates;
        private System.Windows.Forms.ToolStripMenuItem mm_discounts;
        private System.Windows.Forms.ToolStripMenuItem ���������ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mm_rooms;
        private System.Windows.Forms.ToolStripMenuItem mm_customers;
        private System.Windows.Forms.ToolStripMenuItem mm_booking;
        private System.Windows.Forms.ToolStripMenuItem ����������ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

