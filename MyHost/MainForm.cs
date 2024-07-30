using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyHost
{
    public partial class MainForm : Form
    {
        public static RoomCategories roomcategories = null;
        public static RoomDiscounts  roomdiscounts  = null;
        public static RoomFeatures   roomfeatures   = null;
        public static RoomRates      roomrates      = null;
        public static RoomServices   roomservices   = null;
        public static Rooms          rooms          = null;
        public static RoomBooking    roombooking    = null;

        public static DateReport datereport = null;

        public static Customers customers = null;
        public static Canceled canceled = null;

        public static void ShowSaveError()
        {
            MessageBox.Show("Ошибка сохранения данных!");
        }

        private void CreateChild(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
        }

        private void ActivateForm(Form form)
        {
            form.Show();
            form.Activate();
        }

        public static void ShowExceptionDetails(Exception exc)
        {
            MessageBox.Show("Exception message: " + exc.Message
                            + "\n"
                            + "Exception source: " + exc.Source
                            + "\n"
                            + "Exception stack trace: " + exc.StackTrace);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void mm_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите завершить работу программы?"
                , "Потверждение"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void mm_roomcategories_Click(object sender, EventArgs e)
        {
            if (roomcategories == null)
            {
                roomcategories = new RoomCategories();
                this.CreateChild(roomcategories);
            }
            this.ActivateForm(roomcategories);
        }

        private void mm_features_Click(object sender, EventArgs e)
        {
            if (roomfeatures == null)
            {
                roomfeatures = new RoomFeatures();
                this.CreateChild(roomfeatures);
            }
            this.ActivateForm(roomfeatures);
        }

        private void mm_services_Click(object sender, EventArgs e)
        {
            if (roomservices == null)
            {
                roomservices = new RoomServices();
                this.CreateChild(roomservices);
            }
            this.ActivateForm(roomservices);
        }

        private void mm_roomrates_Click(object sender, EventArgs e)
        {
            if (roomrates == null)
            {
                roomrates = new RoomRates();
                this.CreateChild(roomrates);
            }
            this.ActivateForm(roomrates);
        }

        private void mm_discounts_Click(object sender, EventArgs e)
        {
            if (roomdiscounts == null)
            {
                roomdiscounts = new RoomDiscounts();
                this.CreateChild(roomdiscounts);
            }
            this.ActivateForm(roomdiscounts);
        }

        private void mm_customers_Click(object sender, EventArgs e)
        {
            if (customers == null)
            {
                customers = new Customers();
                this.CreateChild(customers);
            }
            this.ActivateForm(customers);
        }

        private void mm_rooms_Click(object sender, EventArgs e)
        {
            if (rooms == null)
            {
                rooms = new Rooms();
                this.CreateChild(rooms);
            }
            this.ActivateForm(rooms);
        }

        public void mm_booking_Click(object sender, EventArgs e)
        {
            if (roombooking == null)
            {
                roombooking  = new RoomBooking();
                this.CreateChild(roombooking);
            }
            this.ActivateForm(roombooking);
        }

        private void отмененныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canceled == null)
            {
                canceled = new Canceled();
                this.CreateChild(canceled);
            }
            this.ActivateForm(canceled);
        }

        private void финансыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void финансыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (datereport == null)
            {
                datereport = new DateReport();
                this.CreateChild(datereport);
            }
            this.ActivateForm(datereport);
        }
    }
}