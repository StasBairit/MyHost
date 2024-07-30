using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class RoomDiscounts : Form
    {
        public RoomDiscounts()
        {
            InitializeComponent();
        }

        private void RoomDiscounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter.Fill(this.myDataSet.discounts);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                discountsTableAdapter.Update(myDataSet.discounts);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void RoomDiscounts_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roomdiscounts = null;
        }
    }
}