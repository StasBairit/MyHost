namespace MyHost
{
    partial class RoomBill
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.roomDataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.servisesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.dutyLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servisesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.roomDataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Счет за комнату";
            // 
            // roomDataGridView1
            // 
            this.roomDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomDataGridView1.Location = new System.Drawing.Point(3, 16);
            this.roomDataGridView1.Name = "roomDataGridView1";
            this.roomDataGridView1.Size = new System.Drawing.Size(706, 80);
            this.roomDataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.servisesDataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(24, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 193);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Счет за дополнительные услуги";
            // 
            // servisesDataGridView1
            // 
            this.servisesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servisesDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servisesDataGridView1.Location = new System.Drawing.Point(3, 16);
            this.servisesDataGridView1.Name = "servisesDataGridView1";
            this.servisesDataGridView1.Size = new System.Drawing.Size(703, 174);
            this.servisesDataGridView1.TabIndex = 0;
            this.servisesDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servisesDataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 373);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(320, 367);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(205, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // canselButton
            // 
            this.canselButton.Location = new System.Drawing.Point(531, 367);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(205, 23);
            this.canselButton.TabIndex = 8;
            this.canselButton.Text = "Отмена";
            this.canselButton.UseVisualStyleBackColor = true;
            this.canselButton.Click += new System.EventHandler(this.canselButton_Click);
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Location = new System.Drawing.Point(23, 344);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(41, 13);
            this.totalBillLabel.TabIndex = 9;
            this.totalBillLabel.Text = "Обшее";
            // 
            // dutyLabel
            // 
            this.dutyLabel.AutoSize = true;
            this.dutyLabel.Location = new System.Drawing.Point(24, 318);
            this.dutyLabel.Name = "dutyLabel";
            this.dutyLabel.Size = new System.Drawing.Size(38, 13);
            this.dutyLabel.TabIndex = 10;
            this.dutyLabel.Text = "Налог";
            // 
            // RoomBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 420);
            this.Controls.Add(this.dutyLabel);
            this.Controls.Add(this.totalBillLabel);
            this.Controls.Add(this.canselButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "RoomBill";
            this.Text = "Информация по счету";
            this.Load += new System.EventHandler(this.RoomBill_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.servisesDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.DataGridView servisesDataGridView1;
        private System.Windows.Forms.DataGridView roomDataGridView1;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.Label dutyLabel;
    }
}