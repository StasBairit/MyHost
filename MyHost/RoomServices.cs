using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class RoomServices : Form
    {
        public RoomServices()
        {
            InitializeComponent();
        }

        private void RoomServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.extra_services' table. You can move, or remove it, as needed.
            this.extra_servicesTableAdapter.Fill(this.myDataSet.extra_services);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                extra_servicesTableAdapter.Update(myDataSet.extra_services);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void RoomServices_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roomservices = null;
        }
    }
}