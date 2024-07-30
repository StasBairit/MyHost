using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class RoomRates : Form
    {
        public RoomRates()
        {
            InitializeComponent();
        }

        private void RoomRates_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roomrates = null;
        }

        private void RoomRates_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.room_categories' table. You can move, or remove it, as needed.
            this.room_categoriesTableAdapter.Fill(this.myDataSet.room_categories);
            // TODO: This line of code loads data into the 'myDataSet.room_rates' table. You can move, or remove it, as needed.
            this.room_ratesTableAdapter.Fill(this.myDataSet.room_rates);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                room_ratesTableAdapter.Update(myDataSet.room_rates);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows[RowIndex].Cells[3].Value = DateTime.Today.ToShortDateString();
            }
            catch
            {
 
            }
        }
    }
}