namespace MyHost
{
    partial class RoomRates
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomRates));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.roomratesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDataSet = new MyHost.MyDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomrateidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratevalidfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratevalidtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratedaycostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratedepositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratemindaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratemaxdaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomrateminpeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomratemaxpeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomrateroomcategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomcategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_ratesTableAdapter = new MyHost.MyDataSetTableAdapters.room_ratesTableAdapter();
            this.room_categoriesTableAdapter = new MyHost.MyDataSetTableAdapters.room_categoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomratesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomcategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.roomratesBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(444, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(79, 22);
            this.bindingNavigatorAddNewItem.Text = "��������";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // roomratesBindingSource
            // 
            this.roomratesBindingSource.DataMember = "room_rates";
            this.roomratesBindingSource.DataSource = this.myDataSet;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "MyDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "��� {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(71, 22);
            this.bindingNavigatorDeleteItem.Text = "�������";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MyHost.Properties.Resources.ed;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "���������";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(920, 479);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(920, 504);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.bindingNavigator1);
            this.toolStripContainer1.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomrateidDataGridViewTextBoxColumn,
            this.roomratenameDataGridViewTextBoxColumn,
            this.roomratedescriptionDataGridViewTextBoxColumn,
            this.roomratevalidfromDataGridViewTextBoxColumn,
            this.roomratevalidtoDataGridViewTextBoxColumn,
            this.roomratedaycostDataGridViewTextBoxColumn,
            this.roomratedepositDataGridViewTextBoxColumn,
            this.roomratemindaysDataGridViewTextBoxColumn,
            this.roomratemaxdaysDataGridViewTextBoxColumn,
            this.roomrateminpeopleDataGridViewTextBoxColumn,
            this.roomratemaxpeopleDataGridViewTextBoxColumn,
            this.roomrateroomcategoryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.roomratesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(920, 479);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomrateidDataGridViewTextBoxColumn
            // 
            this.roomrateidDataGridViewTextBoxColumn.DataPropertyName = "room_rate_id";
            this.roomrateidDataGridViewTextBoxColumn.HeaderText = "room_rate_id";
            this.roomrateidDataGridViewTextBoxColumn.Name = "roomrateidDataGridViewTextBoxColumn";
            this.roomrateidDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomrateidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomratenameDataGridViewTextBoxColumn
            // 
            this.roomratenameDataGridViewTextBoxColumn.DataPropertyName = "room_rate_name";
            this.roomratenameDataGridViewTextBoxColumn.HeaderText = "������������";
            this.roomratenameDataGridViewTextBoxColumn.Name = "roomratenameDataGridViewTextBoxColumn";
            // 
            // roomratedescriptionDataGridViewTextBoxColumn
            // 
            this.roomratedescriptionDataGridViewTextBoxColumn.DataPropertyName = "room_rate_description";
            this.roomratedescriptionDataGridViewTextBoxColumn.HeaderText = "��������";
            this.roomratedescriptionDataGridViewTextBoxColumn.Name = "roomratedescriptionDataGridViewTextBoxColumn";
            this.roomratedescriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // roomratevalidfromDataGridViewTextBoxColumn
            // 
            this.roomratevalidfromDataGridViewTextBoxColumn.DataPropertyName = "room_rate_validfrom";
            this.roomratevalidfromDataGridViewTextBoxColumn.HeaderText = "������";
            this.roomratevalidfromDataGridViewTextBoxColumn.Name = "roomratevalidfromDataGridViewTextBoxColumn";
            this.roomratevalidfromDataGridViewTextBoxColumn.Width = 80;
            // 
            // roomratevalidtoDataGridViewTextBoxColumn
            // 
            this.roomratevalidtoDataGridViewTextBoxColumn.DataPropertyName = "room_rate_validto";
            this.roomratevalidtoDataGridViewTextBoxColumn.HeaderText = "��������� ��";
            this.roomratevalidtoDataGridViewTextBoxColumn.Name = "roomratevalidtoDataGridViewTextBoxColumn";
            this.roomratevalidtoDataGridViewTextBoxColumn.Width = 80;
            // 
            // roomratedaycostDataGridViewTextBoxColumn
            // 
            this.roomratedaycostDataGridViewTextBoxColumn.DataPropertyName = "room_rate_daycost";
            this.roomratedaycostDataGridViewTextBoxColumn.HeaderText = "�������� ���������";
            this.roomratedaycostDataGridViewTextBoxColumn.Name = "roomratedaycostDataGridViewTextBoxColumn";
            this.roomratedaycostDataGridViewTextBoxColumn.Width = 80;
            // 
            // roomratedepositDataGridViewTextBoxColumn
            // 
            this.roomratedepositDataGridViewTextBoxColumn.DataPropertyName = "room_rate_deposit";
            this.roomratedepositDataGridViewTextBoxColumn.HeaderText = "����������";
            this.roomratedepositDataGridViewTextBoxColumn.Name = "roomratedepositDataGridViewTextBoxColumn";
            this.roomratedepositDataGridViewTextBoxColumn.Width = 80;
            // 
            // roomratemindaysDataGridViewTextBoxColumn
            // 
            this.roomratemindaysDataGridViewTextBoxColumn.DataPropertyName = "room_rate_mindays";
            this.roomratemindaysDataGridViewTextBoxColumn.HeaderText = "room_rate_mindays";
            this.roomratemindaysDataGridViewTextBoxColumn.Name = "roomratemindaysDataGridViewTextBoxColumn";
            this.roomratemindaysDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomratemaxdaysDataGridViewTextBoxColumn
            // 
            this.roomratemaxdaysDataGridViewTextBoxColumn.DataPropertyName = "room_rate_maxdays";
            this.roomratemaxdaysDataGridViewTextBoxColumn.HeaderText = "room_rate_maxdays";
            this.roomratemaxdaysDataGridViewTextBoxColumn.Name = "roomratemaxdaysDataGridViewTextBoxColumn";
            this.roomratemaxdaysDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomrateminpeopleDataGridViewTextBoxColumn
            // 
            this.roomrateminpeopleDataGridViewTextBoxColumn.DataPropertyName = "room_rate_minpeople";
            this.roomrateminpeopleDataGridViewTextBoxColumn.HeaderText = "room_rate_minpeople";
            this.roomrateminpeopleDataGridViewTextBoxColumn.Name = "roomrateminpeopleDataGridViewTextBoxColumn";
            this.roomrateminpeopleDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomratemaxpeopleDataGridViewTextBoxColumn
            // 
            this.roomratemaxpeopleDataGridViewTextBoxColumn.DataPropertyName = "room_rate_maxpeople";
            this.roomratemaxpeopleDataGridViewTextBoxColumn.HeaderText = "����. �������";
            this.roomratemaxpeopleDataGridViewTextBoxColumn.Name = "roomratemaxpeopleDataGridViewTextBoxColumn";
            this.roomratemaxpeopleDataGridViewTextBoxColumn.Width = 50;
            // 
            // roomrateroomcategoryDataGridViewTextBoxColumn
            // 
            this.roomrateroomcategoryDataGridViewTextBoxColumn.DataPropertyName = "room_rate_roomcategory";
            this.roomrateroomcategoryDataGridViewTextBoxColumn.DataSource = this.roomcategoriesBindingSource;
            this.roomrateroomcategoryDataGridViewTextBoxColumn.DisplayMember = "room_category";
            this.roomrateroomcategoryDataGridViewTextBoxColumn.HeaderText = "��������� ������";
            this.roomrateroomcategoryDataGridViewTextBoxColumn.Name = "roomrateroomcategoryDataGridViewTextBoxColumn";
            this.roomrateroomcategoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomrateroomcategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roomrateroomcategoryDataGridViewTextBoxColumn.ValueMember = "room_category_id";
            // 
            // roomcategoriesBindingSource
            // 
            this.roomcategoriesBindingSource.DataMember = "room_categories";
            this.roomcategoriesBindingSource.DataSource = this.myDataSet;
            // 
            // room_ratesTableAdapter
            // 
            this.room_ratesTableAdapter.ClearBeforeFill = true;
            // 
            // room_categoriesTableAdapter
            // 
            this.room_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // RoomRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 504);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "RoomRates";
            this.Text = "������";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomRates_FormClosed);
            this.Load += new System.EventHandler(this.RoomRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomratesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomcategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private MyDataSet myDataSet;
        private System.Windows.Forms.BindingSource roomratesBindingSource;
        private MyHost.MyDataSetTableAdapters.room_ratesTableAdapter room_ratesTableAdapter;
        private System.Windows.Forms.BindingSource roomcategoriesBindingSource;
        private MyHost.MyDataSetTableAdapters.room_categoriesTableAdapter room_categoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomrateidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratevalidfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratevalidtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratedaycostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratedepositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratemindaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratemaxdaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomrateminpeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomratemaxpeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn roomrateroomcategoryDataGridViewTextBoxColumn;
    }
}