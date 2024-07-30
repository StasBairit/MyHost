using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyHost.reports.excel;

namespace MyHost
{
    public partial class RoomBooking : Form
    {
        public static int BookingId = -1;

        private void SelectBooking()
        {
            try
            {
                BookingId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                room_booking_extra_serviceTableAdapter.Fill(myDataSet.room_booking_extra_service, BookingId);
            }
            catch
            { }
        }

        public RoomBooking()
        {
            InitializeComponent();
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.myDataSet.customers);
            // TODO: This line of code loads data into the 'myDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.myDataSet.rooms);
            // TODO: This line of code loads data into the 'myDataSet.extra_services' table. You can move, or remove it, as needed.
            this.extra_servicesTableAdapter.Fill(this.myDataSet.extra_services);
            // TODO: This line of code loads data into the 'myDataSet.room_booking' table. You can move, or remove it, as needed.
            this.room_bookingTableAdapter.Fill(this.myDataSet.room_booking);

            //////////////////////////////////
            if (BookingId != -1)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
                //dataGridView1_RowHeaderMouseClick(sender, e);
            }
            dataGridView1.Select();
            panel1.Height = 0;

        }

        private void RoomBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.roombooking = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectBooking();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectBooking();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.SelectBooking();
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.CurrentRow.Cells[1].Value = BookingId.ToString();
            }
            catch
            { }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView2.Update();
                room_booking_extra_serviceTableAdapter.Update(myDataSet.room_booking_extra_service);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (BookingId != -1)
            {
                RoomBookingCancelation form = new RoomBookingCancelation();
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.ShowDialog();
            }
        }

        private void RoomBooking_Activated(object sender, EventArgs e)
        {
            try
            {
                this.Invalidate();
                room_bookingTableAdapter.Fill(myDataSet.room_booking);
            }
            catch
            { }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //string fName = dataGridView1.CurrentRow.Cells["customer_id"].Value.ToString();
            string fName = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //string fName = "AAAAAAA";
            RoomBill rb = new RoomBill(fName);
            rb.Show();
            //Cheque cheq = new Cheque();
            //cheq.print();
        }
    }
}