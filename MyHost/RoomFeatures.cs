using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class RoomFeatures : Form
    {
        public RoomFeatures()
        {
            InitializeComponent();
        }

        private void RoomFeatures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.extra_features' table. You can move, or remove it, as needed.
            this.extra_featuresTableAdapter.Fill(this.myDataSet.extra_features);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                extra_featuresTableAdapter.Update(myDataSet.extra_features);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void RoomFeatures_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roomfeatures = null;
        }
    }
}