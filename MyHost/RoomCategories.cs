using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class RoomCategories : Form
    {
        public RoomCategories()
        {
            InitializeComponent();
        }

        private void RoomCategories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.room_categories' table. You can move, or remove it, as needed.
            this.room_categoriesTableAdapter.Fill(this.myDataSet.room_categories);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                room_categoriesTableAdapter.Update(myDataSet.room_categories);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения!");
            }
        }

        private void RoomCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roomcategories = null;
        }
    }
}