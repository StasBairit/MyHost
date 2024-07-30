namespace MyHost
{
    partial class DateReport
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
            this.fromDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.okButton = new System.Windows.Forms.Button();
            this.canButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromDateTimePicker1
            // 
            this.fromDateTimePicker1.Location = new System.Drawing.Point(26, 12);
            this.fromDateTimePicker1.Name = "fromDateTimePicker1";
            this.fromDateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.fromDateTimePicker1.TabIndex = 0;
            // 
            // toDateTimePicker2
            // 
            this.toDateTimePicker2.Location = new System.Drawing.Point(26, 50);
            this.toDateTimePicker2.Name = "toDateTimePicker2";
            this.toDateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.toDateTimePicker2.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(205, 11);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Печать";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.Location = new System.Drawing.Point(205, 50);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(75, 23);
            this.canButton.TabIndex = 3;
            this.canButton.Text = "Выход";
            this.canButton.UseVisualStyleBackColor = true;
            // 
            // DateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 99);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.toDateTimePicker2);
            this.Controls.Add(this.fromDateTimePicker1);
            this.Name = "DateReport";
            this.Text = "Отчет за период";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromDateTimePicker1;
        private System.Windows.Forms.DateTimePicker toDateTimePicker2;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
    }
}