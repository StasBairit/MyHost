using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyHost.reports.excel;

namespace MyHost
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.customers = null;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.myDataSet.customers);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                customersTableAdapter.Update(myDataSet.customers);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            reportCustomers rep = new reportCustomers();
            rep.printReport(this.dataGridView1);
         }
    }
}